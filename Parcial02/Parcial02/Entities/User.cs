using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Parcial02.Entities
{
    public class User
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int cardID { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string residence { get; set; }
        public string password { get; set; }
        public SecurityQuestion securityQuestion { get; set; }
        public string answer { get; set; }

        public User()
        {
            // To avoid issues.
        }

        public User(int yearForID, string name, string lastName, int age, string residence, string password, SecurityQuestion securityQuestion, string answer)
        {
            // Lo siento, realmente intentamos asignar el carnet con el formato solicitado pero luego de haber intentado
            // en multiples ocaciones, nos dimos por vencidos :(
            this.name = name;
            this.lastName = lastName;
            this.age = age;
            this.residence = residence;
            this.password = password;
            this.securityQuestion = securityQuestion;
            this.answer = answer;
        }
    }
}