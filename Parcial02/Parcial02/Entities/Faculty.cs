namespace Parcial02.Entities
{
    public class Faculty
    {
        public int id { get; set; } // IDENTITY
        public string faculty { get; set; }

        public Faculty()
        {
            // To avoid issues.
        }

        public Faculty(string faculty)
        {
            this.faculty = faculty;
        }
    }
}