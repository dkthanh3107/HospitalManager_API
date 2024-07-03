using System.ComponentModel.DataAnnotations;

namespace HospitalManagement_API.Models.Domain
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        //Chuan Doan
        public string Diagnosis { get; set; }
        public DateTime AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
    }
}
