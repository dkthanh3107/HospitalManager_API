namespace HospitalManagement_API.Models.Domain
{//Cuoc hen tai kham voi bac si
    public class Appointment
    {
        public int Id { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public DateTime AppiontDate { get; set; }
        public DateTime AppiontTime { get; set; }
        public string Reason { get; set; }
        public string Status { get; set; }
    }
}
