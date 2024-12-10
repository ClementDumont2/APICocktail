using APIPerso.Tools;
using Moq;
using static System.Net.WebRequestMethods;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace APIPerso.tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNonNul()
        {
            Call call = new Call();

            //Cocktail result =
            Cocktail cocktailRecupere = call.GetCocktail("https://www.thecocktaildb.com/api/json/v1/1/random.php");

            Assert.IsNotNull(cocktailRecupere);
            Assert.IsNotNull(cocktailRecupere.Name);
            Assert.IsNotNull(cocktailRecupere.Id);
            Assert.IsNotNull(cocktailRecupere.Instructions);
        }


        [TestMethod]
        public void TestHttpError()
        {

        }



    }
}