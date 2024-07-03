namespace HospitalManagement_API.Models.Domain
{//Table Thuoc
    public class Medication
    {
        public int Id { get; set; } 
        public string MedicationName { get; set; }
        public string MedicationType { get; set; }
        //lieu luong thuoc
        public string Dosage { get; set; }
        public int Quantity { get; set; }
        //Ngay het han
        public DateTime ExpirationDate { get; set; }
    }
}
