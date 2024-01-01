namespace SignalR.EntityLayer.Entities
{
    public class Booking
    {
        //rezervasyon sistemi
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public int PersonCount { get; set; } //Kişi sayısı
        public DateTime Date { get; set; }



    }
}
