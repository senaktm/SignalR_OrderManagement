namespace SignalR_WebUI.Dtos.ReservationDtos
{
    public class CreateReservationDto
    {
        public string ReservationName { get; set; }
        public string ReservationPhone { get; set; }
        public string ReservationEmail { get; set; }
        public int ReservationPersonCount { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}
