namespace Live._2023_09_25;

public class MovieCreator
{
    public List<Genre> AllGenres { get; set; }
    public List<Director> Directors { get; set; }

    public MovieCreator()
    {
        //Genre sciFi = new Genre();
        //sciFi.Name = "Sci-Fi";
        //sciFi.Description = "Best genre of all time!";
        //Genre horror = new Genre();
        //horror.Name = "Horror";
        //horror.Description = "Worst genre of all time!";
        //Genre comedy = new Genre();
        //comedy.Name = "Comedy";
        //comedy.Description = "Funniest genre of all time!";
        // 
        //AllGenres = new List<Genre>()
        //{
        //    // Object Initializer v
        //    //new Genre() { Name = "Comedy", Description = "Funniest genre of all time!" }
        //};

        AllGenres = new List<Genre>()
        {
            new Genre("Sci-Fi","Best genre of all time!" ),
            new Genre("Horror","Worst genre of all time!" ),
            new Genre("Comedy","Funniest genre of all time!" )
            // Object Initializer v
            //new Genre() { Name = "Comedy", Description = "Funniest genre of all time!" }
        };

        //AllGenres.Add(sciFi);
        //AllGenres.Add(horror);
        //AllGenres.Add(comedy);§

        Directors = new List<Director>()
        {
            new Director() { Name = "George Lucas" },
            new Director() { Name = "James Cameron" },
            new Director() { Name = "Steven Spielberg" }
        };

        //Director georgeLucas = new Director();
        //georgeLucas.Name = "George Lucas";
    }

    public Movie BuildMovie(string name, string description, int[] genreIndices, int directorIndex)
    {
        Movie movie = new Movie();
        movie.Name = name;
        movie.Description = description;
        movie.Director = Directors[directorIndex];
        foreach (var genreIndex in genreIndices)
        {
            movie.Genre.Add(AllGenres[genreIndex]);
        }

        return movie;
    }
}
