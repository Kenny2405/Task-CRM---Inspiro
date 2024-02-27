namespace Task_CRM.Models
{
    public class Interaction
    {
        public int Id { get; set; }
        public string? Contact { get; set; }
        public string? Client {  get; set; }
        public string? JenisInteraksi { get; set; }
        public DateOnly Tanggal { get; set; }
        public TimeOnly Waktu {  get; set; }
        public string? Detail {  get; set; }
        public string? PIC_Sales { get; set; }
        public string? status { get; set; }
    }
}
