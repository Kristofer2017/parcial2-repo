using System.ComponentModel.DataAnnotations;

namespace Parcial02.Entities
{
    public class User
    {
        [Key]
        public int CardID { get; set; }
        public string FullName { get; set; }
        public string Password { get; set; }
        public virtual SecurityQuestion question { get; set; }
        public string Answer { get; set; }

        public User()
        {
            // To avoid issues.
        }

        public User(int cardId, string fullName, string password, SecurityQuestion question, string answer)
        {
            CardID = cardId;
            FullName = fullName;
            Password = password;
            this.question = question;
            Answer = answer;
        }
    }
}