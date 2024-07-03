using System.ComponentModel.DataAnnotations;

namespace HospitalManagement_API.Models.Domain
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        //Chuyen mon cua bac si
        public string Specialty { get; set; }
        //Trinh do chuyen mon cua bac si
        public string Qualifications { get; set; }
        //So nam kinh nghiem cua bac si
        public int YearsOfExperience { get; set; }
        //Sdt lien he cua bac si
        public string ContactNumber { get; set; }
        public string EmailAdress { get; set; }
    }
}
