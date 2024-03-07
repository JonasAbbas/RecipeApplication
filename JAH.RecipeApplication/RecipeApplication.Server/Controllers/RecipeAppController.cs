using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RecipeApplication.Server.Data;
using RecipeApplication.Shared.Models;

namespace RecipeApplication.Server.Controllers
{
    [Route("api/Favorites")]
    [ApiController]
    public class RecipeAppController : ControllerBase
    {
        private readonly DataContext _dbContext;
        public RecipeAppController(DataContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<Favorites>>> GetFavoriteRecipes()
        {
            var list = await GetRecipesAsync();

            return Ok(list);
        }

        [HttpPost]
        public async Task<ActionResult<Favorites>> PostFavoriteRecipes(Favorites favorites)
        {
            var result = _dbContext.Favorites.Add(favorites);
            await _dbContext.SaveChangesAsync();

            favorites.IdDBMeal = result.Entity.IdDBMeal;

            return CreatedAtAction(nameof(GetFavoriteRecipes), favorites);
        }

        [HttpDelete("{id}")]
        public async Task <IActionResult> DeleteFavoriteRecipe(int id)
        {
            var entity = await _dbContext.Favorites.FindAsync(id);

            _dbContext.Favorites.Remove(entity);

            await _dbContext.SaveChangesAsync();

            return Accepted();
        }


        private async Task<List<Favorites>> GetRecipesAsync()
        {
            return await _dbContext.Favorites.ToListAsync();
        }
    }
}