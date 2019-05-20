namespace KarolineRasmussen.KompetenceTestS1.KompetenceDel
{
    public struct Movie
    {
        public readonly string Title;
        public readonly int ReleaseYear;
        public readonly string Director;
        public readonly string Company;

        public Movie(string title, int releaseYear, string director, string company)
        {
            Title = title;
            ReleaseYear = releaseYear;
            Director = director;
            Company = company;
        }

        public override string ToString()
        {
            return $"{Title}, instrueret af {Director}, udgivet af {Company} i {ReleaseYear}";
        }
    }
}