namespace Parcial02.Entities
{
    public class SecurityQuestion
    {
        public int id { get; set; }
        public string question { get; set; }

        public SecurityQuestion()
        {
            // To avoid issues.
        }

        public SecurityQuestion(int id, string question)
        {
            this.id = id;
            this.question = question;
        }
    }
}