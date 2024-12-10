using APIPerso.tools;
using APIPerso.Tools;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APICocktail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CocktailController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        public IActionResult GetCocktail()
        {
            // On instancie un objet de la classe Call
            Call call = new Call();

            // On récupère le cocktail grâce à la méthode GetCocktail de la classe Call
            Cocktail cocktailRecupere = call.GetCocktail("https://www.thecocktaildb.com/api/json/v1/1/random.php");

            // On retourne le cocktail
            return Ok(cocktailRecupere);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Call call = new Call();
            string url = "https://www.thecocktaildb.com/api/json/v1/1/lookup.php?i=" + id.ToString();
            Cocktail cocktailRecupere = call.GetCocktail(url);

            // On retourne le cocktail
            return Ok(cocktailRecupere);
        }
    }
}
