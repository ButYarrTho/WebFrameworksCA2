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
        string apiKey = "f7555ab661a6ee7dca7c3c247e68f045";

        request.AddParameter("method", method);
        request.AddParameter("user", user);
        request.AddParameter("api_key", apiKey);
        request.AddParameter("limit", 10);
        request.AddParameter("format", "json");

        try
        {
            var response = client.Get(request);

            if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
            {
                return JsonConvert.DeserializeObject<Artists>(response.Content);
            }
            else
            {
                Console.WriteLine($"API error: {response.StatusCode} - {response.StatusDescription}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error making API call: {ex.Message}");
        }

        return null;
    }

    public static Artists? SearchArtists(string query)
    {
        var client = new RestClient("http://ws.audioscrobbler.com/2.0/");
        var request = new RestRequest();

        string apiKey = "f7555ab661a6ee7dca7c3c247e68f045";

        request.AddParameter("method", "artist.search");
        request.AddParameter("artist", query);
        request.AddParameter("api_key", apiKey);
        request.AddParameter("limit", 10);
        request.AddParameter("format", "json");

        try
        {
            var response = client.Get(request);

            if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
            {
                return JsonConvert.DeserializeObject<Artists>(response.Content);
            }
            else
            {
                Console.WriteLine($"API error: {response.StatusCode} - {response.StatusDescription}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error making API call: {ex.Message}");
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
            return JsonConvert.DeserializeObject<Movies>(response.Content);
        }

        return null;
    }

    public static Movies? SearchMovies(string query)
    {
        var client = new RestClient("https://api.themoviedb.org/3/search/movie");
        var request = new RestRequest();

        string apiKey = "ab4cf041cdde4402f97e6360a20cbfbc";

        request.AddParameter("api_key", apiKey);
        request.AddParameter("query", query);
        request.AddParameter("language", "en-US");
        request.AddParameter("page", 1);

        try
        {
            var response = client.Get(request);

            if (response.IsSuccessful && !string.IsNullOrEmpty(response.Content))
            {
                return JsonConvert.DeserializeObject<Movies>(response.Content);
            }
            else
            {
                Console.WriteLine($"API error: {response.StatusCode} - {response.StatusDescription}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error making API call: {ex.Message}");
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
