using System.ComponentModel.DataAnnotations;

namespace RezervacijaStolaApp.Models.Data
{
    public class Reservation
    {
        public int Id { get; set; }

        [Display(Name = "Datum rezervacije")]
        public DateTime ReservationDate { get; set; }
        public int UserId { get; set; }

        [Display(Name = "Ime i prezime")]
        public User User { get; set; }

        public int DeskId { get; set; }

        [Display(Name = "Broj stola")]
        public Desk Desk { get; set; }
    }
}
