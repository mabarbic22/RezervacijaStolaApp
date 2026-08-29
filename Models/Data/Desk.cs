namespace RezervacijaStolaApp.Models.Data
{
    public class Desk
    {
        public int Id { get; set; }
        public int DeskNumber { get; set; }
        public int RoomFloorId { get; set; }
        public List<WorkTools> WorkTools { get; set; }
        public List<Reservation> ListOfReservations { get; set; }
    }
}
