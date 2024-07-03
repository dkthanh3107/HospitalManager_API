namespace HospitalManagement_API.Models.Domain
{//Vat tu cua benh vien
    public class Supply
    {
        public int Id { get; set; }
        public string SupplyName { get; set; }
        public string SupplyType { get; set; }
        public int Quantity { get; set; }
        // Don gia
        public decimal UnitPrice { get; set; }
        //Ngay het han cua vat tu
        public DateTime ExpirationDate { get; set; }
    }
}
