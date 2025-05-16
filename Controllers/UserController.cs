using fPOP_REST.Data;
using fPOP_REST.Model;
using fPOP_REST.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace fPOP_REST.Controllers;

public class UserController : BaseController<User>
{
    public UserController(fPOP_Context context) : base(context) { }

    [HttpGet("phone/{phone}")]
    public async Task<ActionResult<User>> GetByPhoneNumber(string phone)
    {
        var user = await _dbSet.FirstOrDefaultAsync(u => u.Phone == phone);
        
        if (user == null)
        {
            return NotFound();
        }

        return user;
    }
    
    
    [HttpPost("register")]
    public async Task<ActionResult<User>> Register([FromBody] RegisterUserDto registerDto)
    {
        var existingUser = await _dbSet.FirstOrDefaultAsync(u => u.Phone == registerDto.Phone);
        if (existingUser != null)
        {
            return Conflict("User with this phone number already exists");
        }

        var user = new User
        {
            Name = registerDto.Name,
            Email = registerDto.Email,
            Phone = registerDto.Phone,
            Password = registerDto.Password,
            Birthday = registerDto.Birthday,
            FirstLanguage = registerDto.FirstLanguage
        };
        
        user.Gender = registerDto.Gender ?? user.Gender;
        user.Religion = registerDto.Religion ?? user.Religion;
        user.CountryOfBirth = registerDto.CountryOfBirth ?? user.CountryOfBirth;
        user.CountryOfResidence = registerDto.CountryOfResidence ?? user.CountryOfResidence;
        user.PoliticalOrientation = registerDto.PoliticalOrientation ?? user.PoliticalOrientation;
        user.SexualOrientation = registerDto.SexualOrientation ?? user.SexualOrientation;
        user.SecondLanguage = registerDto.SecondLanguage ?? user.SecondLanguage;
        user.FavoriteAnimal = registerDto.FavoriteAnimal ?? user.FavoriteAnimal;
        user.ChosenDefaultPreferences = registerDto.ChosenDefaultPreferences ?? user.ChosenDefaultPreferences;
        user.UserDefinedPreferences = registerDto.UserDefinedPreferences ?? user.UserDefinedPreferences;
        user.FavoriteDirectors = registerDto.FavoriteDirectors ?? user.FavoriteDirectors;
        user.FavoriteActors = registerDto.FavoriteActors ?? user.FavoriteActors;
        
        _dbSet.Add(user);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = user.Id }, user);
    }
    
    [HttpPatch("{phone}/profile_update")]
    public async Task<ActionResult<User>> UpdateProfile(string phone, [FromBody] UserProfileUpdateDto profileData)
    {
        var user = await _dbSet.FirstOrDefaultAsync(u => u.Phone == phone);
        if (user == null)
        {
            return NotFound();
        }
        
        user.Gender = profileData.Gender ?? user.Gender;
        user.Religion = profileData.Religion ?? user.Religion;
        user.CountryOfBirth = profileData.CountryOfBirth ?? user.CountryOfBirth;
        user.CountryOfResidence = profileData.CountryOfResidence ?? user.CountryOfResidence;
        user.PoliticalOrientation = profileData.PoliticalOrientation ?? user.PoliticalOrientation;
        user.SexualOrientation = profileData.SexualOrientation ?? user.SexualOrientation;
        user.SecondLanguage = profileData.SecondLanguage ?? user.SecondLanguage;
        user.ProfilePicture = profileData.ProfilePicture ?? user.ProfilePicture;
        user.ChosenDefaultPreferences = profileData.ChosenDefaultPreferences ?? user.ChosenDefaultPreferences;
        user.UserDefinedPreferences = profileData.UserDefinedPreferences ?? user.UserDefinedPreferences;
        user.StarredMovies = profileData.StarredMovies ?? user.StarredMovies;
        user.FavoriteDirectors = profileData.FavoriteDirectors ?? user.FavoriteDirectors;
        user.FavoriteActors = profileData.FavoriteActors ?? user.FavoriteActors;
        user.Birthday = profileData.Birthday ?? user.Birthday;
        user.Name = profileData.Name ?? user.Name;
        user.Email = profileData.Email ?? user.Email;
        user.Password = profileData.Password ?? user.Password;
        user.Phone = profileData.Phone ?? user.Phone;
        user.FirstLanguage = profileData.FirstLanguage ?? user.FirstLanguage;

        await _context.SaveChangesAsync();
        return Ok(user);
    }
    
    [HttpDelete("{phone}/delete")]
    public async Task<IActionResult> SoftDeleteUser(string phone)
    {
        var user = await _dbSet.FirstOrDefaultAsync(u => u.Phone == phone);
        if (user == null)
        {
            return NotFound();
        }
        
        user.IsActive = false;
        await _context.SaveChangesAsync();

        return NoContent();
    }

}