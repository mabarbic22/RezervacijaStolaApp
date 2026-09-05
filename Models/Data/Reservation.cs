using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RezervacijaStolaApp.Models.Data
{
    public class Reservation
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "Datum rezervacije")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy.}", ApplyFormatInEditMode = true)]
        public DateTime ReservationDate { get; set; }

        [ScaffoldColumn(false)]
        public int UserId { get; set; }

        [Display(Name = "Ime i prezime")]
        public User User { get; set; }

        [ScaffoldColumn(false)]
        public int DeskId { get; set; }

        [Display(Name = "Broj stola")]
        public Desk Desk { get; set; }

        ////ovaaj atribut ne želimo u bazi u tablici reservaations, služi za prikaz na sučelju
        //[NotMapped]
        //public string RoomFloorText { get; set; }

    }
}
