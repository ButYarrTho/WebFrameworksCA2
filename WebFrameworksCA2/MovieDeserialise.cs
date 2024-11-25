﻿namespace WebFrameworksCA2
{
    public class Movies
    {
        public int Page { get; set; }
        public Movie[] Results { get; set; }
        public int TotalPages { get; set; }
        public int TotalResults { get; set; }
    }

    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public string PosterPath { get; set; }
        public string ReleaseDate { get; set; }
        public double VoteAverage { get; set; }
        public int VoteCount { get; set; }
    }
}