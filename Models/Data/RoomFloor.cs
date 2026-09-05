using System.ComponentModel.DataAnnotations;

namespace RezervacijaStolaApp.Models.Data
{
    public class RoomFloor
    {
        public int Id { get; set; }
        public string Floor { get; set; }

        [Display(Name = "Kat")]
        public string FloorDescription { get; set; }
    }
}
