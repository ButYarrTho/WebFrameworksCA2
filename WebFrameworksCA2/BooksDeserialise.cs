namespace WebFrameworksCA2
{
    public class BookResponse
    {
        public BookDetails ISBN { get; set; }
    }

    public class BookDetails
    {
        public string Title { get; set; }
        public Author[] Authors { get; set; }
        public string PublishDate { get; set; }
        public Cover Cover { get; set; }
        public int NumberOfPages { get; set; }
    }

    public class Author
    {
        public string Name { get; set; }
    }

    public class Cover
    {
        public string Medium { get; set; }
    }
}