using Newtonsoft.Json;
using RestSharp;

namespace WebFrameworksCA2;

public class MusicService
{
    public static Artists? GetTopArtists()
    {
        var client = new RestClient("http://ws.audioscrobbler.com/2.0/");
        var request = new RestRequest();

        string user = "test";
        string method = "user.getTopArtists";
        string myKey = "581cca30b41a4cc0d5b3eb59d502b651";

        request.AddParameter("method", method); 
        request.AddParameter("user", user); 
        request.AddParameter("api_key", myKey);
        request.AddParameter("limit", 100);
        request.AddParameter("format", "json");
            
        var response = client.Get(request);
        if (!string.IsNullOrEmpty(response.Content))
        {
            string receivedJson = response.Content;
            Artists? topArtists = JsonConvert.DeserializeObject<Artists>(response.Content);
            return topArtists;
        }

        return null;
    }
    
    public static Movies? GetPopularMovies()
    {
        var client = new RestClient("https://api.themoviedb.org/3/movie/popular");
        var request = new RestRequest();

        string apiKey = "ab4cf041cdde4402f97e6360a20cbfbc";

        request.AddParameter("api_key", apiKey);
        request.AddParameter("language", "en-US");
        request.AddParameter("page", 1);

        var response = client.Get(request);
        if (!string.IsNullOrEmpty(response.Content))
        {
            string receivedJson = response.Content;
            Movies? topMovies = JsonConvert.DeserializeObject<Movies>(response.Content);
            return topMovies;
        }

        return null;
    }

    public static BookDetails? GetBookDetails(string isbn)
    {
        var client = new RestClient("https://openlibrary.org/api/books");
        var request = new RestRequest();

        request.AddParameter("bibkeys", $"ISBN:{isbn}");
        request.AddParameter("format", "json");
        request.AddParameter("jscmd", "data");

        var response = client.Get(request);
        if (!string.IsNullOrEmpty(response.Content))
        {
            // Deserialize the response to a dictionary and return the first matching book details
            var json = JsonConvert.DeserializeObject<Dictionary<string, BookDetails>>(response.Content);
            return json?.Values.FirstOrDefault();
        }

        return null;
    }
}
