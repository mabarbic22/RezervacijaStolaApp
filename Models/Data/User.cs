namespace RezervacijaStolaApp.Models.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MailAdress { get; set; }
        public string CellPhoneNumber { get; set; }

        //popis svih rezervacija za pojedinog korisnika. Mogućnost praćenja povijesti i planiranja
        public List<Reservation> UserReservations { get; set; }
    }
}
