using System;

namespace Parcial02.Entities
{
    public class Reservation
    {
        public int id { get; set; } // IDENTITY
        public virtual User user { get; set; }
        public virtual Speciality speciality { get; set; }
        public DateTime dateAndTime { get; set; }

        public Reservation()
        {
            // To avoid issues.
        }
        
        public Reservation(User user, Speciality speciality, DateTime dateAndTime)
        {
            this.user = user;
            this.speciality = speciality;
            this.dateAndTime = dateAndTime;
        }
    }
}