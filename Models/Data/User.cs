using System.ComponentModel.DataAnnotations;

namespace RezervacijaStolaApp.Models.Data
{
    public class User
    {
        public int Id { get; set; }

        [Display(Name="Ime")]
        public string Name { get; set; }

        [Display(Name = "Prezime")]
        public string Surname { get; set; }

        [Display(Name = "eMail")]
        public string MailAdress { get; set; }

        [Display(Name = "Mobitel")]
        public string CellPhoneNumber { get; set; }

        //popis svih rezervacija za pojedinog korisnika. Mogućnost praćenja povijesti i planiranja
        public List<Reservation> UserReservations { get; set; }
    }
}
