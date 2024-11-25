namespace WebFrameworksCA2;

public class Artists
{
    public Topartists topartists { get; set; }
}

public class Topartists
{
    public Artist[] artist { get; set; }
    public _attr _attr { get; set; }
}

public class Artist
{
    public string streamable { get; set; }
    public Image[] image { get; set; }
    public string mbid { get; set; }
    public string url { get; set; }
    public string playcount { get; set; }
    public _attr1 _attr { get; set; }
    public string name { get; set; }
}

public class Image
{
    public string size { get; set; }
    public string _text { get; set; }
}

public class _attr1
{
    public string rank { get; set; }
}

public class _attr
{
    public string user { get; set; }
    public string totalPages { get; set; }
    public string page { get; set; }
    public string perPage { get; set; }
    public string total { get; set; }
}