namespace HospitalManagement_API.Models.Domain
{//Table don thuoc
    public class Prescription
    {
        public int Id { get; set; } 
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public Medication Medication { get; set; }
        public int Quantity { get; set; }
        //Huong dan
        public string Intstuctions { get; set; }
        //Don thuoc ngay 
        public DateTime PrescriptionDate { get; set; }
        //Trang thai thanh toan
        public bool RefillStatus { get; set; }
    }
}
