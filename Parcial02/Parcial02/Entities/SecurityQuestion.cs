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

        public SecurityQuestion(string question)
        {
            this.question = question;
        }
    }
}