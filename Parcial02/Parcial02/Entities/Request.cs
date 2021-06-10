namespace Parcial02.Entities
{
    public class Request
    {
        public int id { get; set; }
        public User user { get; set; }
        public  Faculty faculty { get; set; }
        public bool vigent { get; set; }

        public Request()
        {
            // To avoid issues.
        }

        public Request(User user, Faculty faculty, bool vigent)
        {
            this.user = user;
            this.faculty = faculty;
            this.vigent = vigent;
        }
    }
}