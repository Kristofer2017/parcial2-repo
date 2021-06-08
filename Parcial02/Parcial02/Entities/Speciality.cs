namespace Parcial02.Entities
{
    public class Speciality
    {
        public int id { get; set; } // IDENTITY
        public string generalMedicine { get; set; }
        public string odontology { get; set; }
        public string psychology { get; set; }
        public string ophthalmology { get; set; }

        public Speciality()
        {
            // To avoid issues.
        }

        public Speciality(string generalMedicine, string odontology, string psychology, string ophthalmology)
        {
            this.generalMedicine = generalMedicine;
            this.odontology = odontology;
            this.psychology = psychology;
            this.ophthalmology = ophthalmology;
        }
    }
}