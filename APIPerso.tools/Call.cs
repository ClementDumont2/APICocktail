using APIPerso.tools;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace APIPerso.Tools
{
    public class Call
    {
        /// <summary>
        /// Classe permettant de faire un call API

        //public string GetDataFromApi(string url)

        //{
        //    string result = "";
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri(url);
        //    //Appel de l'API et récupération de la réponse
        //    result = client.GetStringAsync(url).Result;
        //    return result;
        //}

        /// <summary>
        /// /// get a cocktail
        /// /// </summary>
        ///<param name="url"> chuck norris api endpoint</param>
        ////// <returns>a joke</returns>
        //public Cocktail GetCocktail(string url)
        //{
        //    Drinks drinks = new Drinks();
        //    Cocktail result = new Cocktail();


        //    var jsonFlux = GetDataFromApi(url);
        //    // JsonUtility 
        //    var json = JsonSerializer.Deserialize<Drinks>(jsonFlux);

        //    result.Id = json.drinks[0].Id;
        //    result.Name = json.drinks[0].Name;
        //    result.Instructions = json.drinks[0].Instructions;

        //    return result;
        //}

        // Méthode GetDatas générique
        public T GetDatas<T>(string url)
        {
            try
            {
                string result = "";
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(url);
                //Appel de l'API et récupération de la réponse
                result = client.GetStringAsync(url).Result;
                //Désérialisation en fonction du type T
                var json = JsonSerializer.Deserialize<T>(result);

                return json;
            }
            catch (HttpRequestException e)
            {

                throw new HttpRequestException("Erreur https", e);
            }
        }

        public Drinks GetDrinks(string url)
        {
            // Retourne la liste des boissons
            return GetDatas<Drinks>(url);
        }

        public Cocktail GetCocktail(string url) {

            try
            {
                // On utilise le json du drinks
                Drinks drinks = GetDrinks(url);
                Dto dto = new Dto();
                Cocktail cocktail = new Cocktail();

                //dto.Id = drinks.Cocktails[0].Id;
                //dto.Name = drinks.Cocktails[0].Name;
                //dto.Instructions = drinks.Cocktails[0].Instructions;

                dto.Id = drinks.drinks[0].Id;
                dto.Name = drinks.drinks[0].Name;
                dto.Instructions = drinks.drinks[0].Instructions;

                cocktail.Id = dto.Id;
                cocktail.Name = dto.Name;
                cocktail.Instructions = dto.Instructions;

                return cocktail;
            }
            catch (System.NullReferenceException e)
            {

                throw new System.NullReferenceException("L'Id n'est pas présent dans l'API", e);
            }
            
        }

    }
}