using fPOP_REST.Model;
using fPOP_REST.Utilities;
using Microsoft.AspNetCore.Mvc;

namespace fPOP_REST.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class MoviePack(ITmdbCacher tmdbcacher) : ControllerBase
    {
        
        [HttpGet("getmovies")]
        public async Task<ActionResult<TmdbRes>> GetMovies([FromBody] MovieRequierementsDto sentData)
        {

            var requierements = new MovieRequierementsDto();
            
            requierements.Gender = sentData.Gender ?? requierements.Gender;
            requierements.Religion = sentData.Religion ?? requierements.Religion;
            requierements.CountryOfBirth = sentData.CountryOfBirth ?? requierements.CountryOfBirth;
            requierements.CountryOfResidence = sentData.CountryOfResidence ?? requierements.CountryOfResidence;
            requierements.PoliticalOrientation = sentData.PoliticalOrientation ?? requierements.PoliticalOrientation;
            requierements.SexualOrientation = sentData.SexualOrientation ?? requierements.SexualOrientation;
            requierements.SecondLanguage = sentData.SecondLanguage ?? requierements.SecondLanguage;
            requierements.ChosenDefaultPreferences = sentData.ChosenDefaultPreferences ?? requierements.ChosenDefaultPreferences;
            requierements.UserDefinedPreferences = sentData.UserDefinedPreferences ?? requierements.UserDefinedPreferences;
            requierements.FavoriteDirectors = sentData.FavoriteDirectors ?? requierements.FavoriteDirectors;
            requierements.FavoriteActors = sentData.FavoriteActors ?? requierements.FavoriteActors;
            requierements.Birthday = sentData.Birthday ?? requierements.Birthday;
            requierements.FirstLanguage = sentData.FirstLanguage ?? requierements.FirstLanguage;
            
            var movies = tmdbcacher.TrendingMovies;
            if (movies != null && tmdbcacher.LastRefreshed.AddMinutes(30) >= DateTime.Now) return Ok(movies);
            await tmdbcacher.RefreshAsync();
            movies = tmdbcacher.TrendingMovies;
            return Ok(movies);
        }

        [HttpGet("getmoviesdirect")]
        public async Task<ActionResult<TmdbRes>> GetMoviesDirect()
        {
            // var movies = await TmdbCaller.GetTrendingMovies();
            var movies = tmdbcacher.TrendingMovies;
            return Ok(movies);
        }
    }