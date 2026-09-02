using System.ComponentModel.DataAnnotations;

namespace RezervacijaStolaApp.Models.Data
{
    public class Desk
    {
        public int Id { get; set; }
        
        [Display(Name = "Oznaka stola")]
        public int DeskNumber { get; set; }
       
        [Display(Name="Kat sobe")]
        public int RoomFloorId { get; set; }
        public RoomFloor RoomFloor { get; set; }
        public int WoorkToolsId {get; set; }
        public WorkTools WorkTools { get; set; }
        public List<Reservation> ListOfReservations { get; set; }
    }
}
