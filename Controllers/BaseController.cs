using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using fPOP_REST.Data;
using fPOP_REST.Interface;

namespace fPOP_REST.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseController<TEntity> : ControllerBase
        where TEntity : class, IEntity
    {
        protected readonly FirePopDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public BaseController(FirePopDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        // GET: api/[controller]
        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TEntity>>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public virtual async Task<ActionResult<TEntity>> GetById(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            return entity;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Put(int? id, TEntity entity)
        {
            // Here's where the error is happening
            if (id != ((IEntity)entity).Id)
            {
                return BadRequest();
            }

            _context.Entry(entity).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public virtual async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
            
            // Use the interface to access Id
            return CreatedAtAction("GetById", new { id = ((IEntity)entity).Id }, entity);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int? id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        protected virtual bool EntityExists(int? id)
        {
            // Use a generic way to check for entity existence
            return _dbSet.Any(e => ((IEntity)e).Id == id);
        }
    }
}