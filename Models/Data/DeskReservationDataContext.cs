using Microsoft.EntityFrameworkCore;
using System.Xml;


namespace RezervacijaStolaApp.Models.Data
{
    public class DeskReservationDataContext : DbContext
    {
        public DeskReservationDataContext(DbContextOptions<DeskReservationDataContext> data)
            : base(data)
        {
        }

        //ovdje definiramo tablice koje će se kreirati u bazi
        public DbSet<User> Users { get; set; }
        public DbSet<Desk> Desks { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<WorkTools> WorkTools { get; set; }
        public DbSet<RoomFloor> RoomFloor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().Property(u => u.Name).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<User>().Property(u => u.Surname).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<User>().Property(u => u.MailAdress).IsRequired().HasMaxLength(100);


            modelBuilder.Entity<Desk>().Property(d => d.DeskNumber).IsRequired();
            modelBuilder.Entity<Desk>().Property(d => d.RoomFloorId).IsRequired();

            modelBuilder.Entity<Reservation>().Property(r => r.UserId).IsRequired();
            modelBuilder.Entity<Reservation>().Property(r => r.DeskId).IsRequired();
            modelBuilder.Entity<Reservation>().Property(r => r.ReservationDate).HasColumnType("date");
            // Postavljanje kombinacije DeskId i datum rezervacije na UNIQUE kako se ne bi događali zapisi sa istim kombinacijama stola i datuma
            modelBuilder.Entity<Reservation>()
                .HasIndex(r => new { r.DeskId, r.ReservationDate })
                .IsUnique();



            modelBuilder.Entity<User>().HasData(
               new User { Id = 1, Name = "Marko", Surname = "Barbić", MailAdress = "mabarbic22@gmail.com", CellPhoneNumber = "0993855267" },
               new User { Id = 2, Name = "Nikolina", Surname = "Birač", MailAdress = "nibirac@gmail.com", CellPhoneNumber = "0993456755" },
               new User { Id = 3, Name = "Tomislav", Surname = "Marković", MailAdress = "tomi12@gmail.com", CellPhoneNumber = "0912675098" },
               new User { Id = 4, Name = "Josip", Surname = "Ninić", MailAdress = "josip.ninic@vsite.hr", CellPhoneNumber = "0923456123" },
               new User { Id = 5, Name = "Nikola", Surname = "Nikolić", MailAdress = "nikolanik@vsite.hr", CellPhoneNumber = "092344573" },
               new User { Id = 6, Name = "Andrej", Surname = "Stanić", MailAdress = "astanic@gmail.com", CellPhoneNumber = "0923456123" },
               new User { Id = 7, Name = "Monika", Surname = "Josipović", MailAdress = "monijosipov@gmail.com", CellPhoneNumber = "0923456723" },
               new User { Id = 8, Name = "Jure", Surname = "Jurić", MailAdress = "juricjure@gmail.com", CellPhoneNumber = "092788823" },
               new User { Id = 9, Name = "Tihomir", Surname = "Glasnović", MailAdress = "tihica.glasn@gmail.com", CellPhoneNumber = "098157899" }
           );



            modelBuilder.Entity<RoomFloor>().HasData(
                new RoomFloor { Id = 1, Floor = "-1", FloorDescription = "Suteren" },
                new RoomFloor { Id = 2, Floor = "0", FloorDescription = "Prizemlje" },
                new RoomFloor { Id = 3, Floor = "1", FloorDescription = "Prvi kat" },
                new RoomFloor { Id = 4, Floor = "2", FloorDescription = "Drugi kat" }
                );

            modelBuilder.Entity<Desk>().HasData(
                new Desk { Id = 1, DeskNumber = 1, RoomFloorId = 1 },
                new Desk { Id = 2, DeskNumber = 2, RoomFloorId = 1 },
                new Desk { Id = 3, DeskNumber = 3, RoomFloorId = 1 },
                new Desk { Id = 4, DeskNumber = 4, RoomFloorId = 1 },
                new Desk { Id = 5, DeskNumber = 5, RoomFloorId = 1 },
                new Desk { Id = 6, DeskNumber = 6, RoomFloorId = 1 },
                new Desk { Id = 7, DeskNumber = 7, RoomFloorId = 1 },
                new Desk { Id = 8, DeskNumber = 8, RoomFloorId = 1 },
                new Desk { Id = 9, DeskNumber = 9, RoomFloorId = 2 },
                new Desk { Id = 10, DeskNumber = 10, RoomFloorId = 2 },
                new Desk { Id = 11, DeskNumber = 11, RoomFloorId = 2 },
                new Desk { Id = 12, DeskNumber = 12, RoomFloorId = 2 },
                new Desk { Id = 13, DeskNumber = 13, RoomFloorId = 2 },
                new Desk { Id = 14, DeskNumber = 14, RoomFloorId = 2 },
                new Desk { Id = 15, DeskNumber = 15, RoomFloorId = 2 },
                new Desk { Id = 16, DeskNumber = 16, RoomFloorId = 2 },
                new Desk { Id = 17, DeskNumber = 17, RoomFloorId = 2 },
                new Desk { Id = 18, DeskNumber = 18, RoomFloorId = 2 },
                new Desk { Id = 19, DeskNumber = 19, RoomFloorId = 2 },
                new Desk { Id = 20, DeskNumber = 20, RoomFloorId = 2 },
                new Desk { Id = 21, DeskNumber = 21, RoomFloorId = 3 },
                new Desk { Id = 22, DeskNumber = 22, RoomFloorId = 3 },
                new Desk { Id = 23, DeskNumber = 23, RoomFloorId = 3 },
                new Desk { Id = 24, DeskNumber = 24, RoomFloorId = 3 },
                new Desk { Id = 25, DeskNumber = 25, RoomFloorId = 3 },
                new Desk { Id = 26, DeskNumber = 26, RoomFloorId = 3 },
                new Desk { Id = 27, DeskNumber = 27, RoomFloorId = 3 },
                new Desk { Id = 28, DeskNumber = 28, RoomFloorId = 3 },
                new Desk { Id = 29, DeskNumber = 29, RoomFloorId = 3 },
                new Desk { Id = 30, DeskNumber = 30, RoomFloorId = 3 },
                new Desk { Id = 31, DeskNumber = 31, RoomFloorId = 3 },
                new Desk { Id = 32, DeskNumber = 32, RoomFloorId = 3 },
                new Desk { Id = 33, DeskNumber = 33, RoomFloorId = 4 },
                new Desk { Id = 34, DeskNumber = 34, RoomFloorId = 4 },
                new Desk { Id = 35, DeskNumber = 35, RoomFloorId = 4 },
                new Desk { Id = 36, DeskNumber = 36, RoomFloorId = 4 },
                new Desk { Id = 37, DeskNumber = 37, RoomFloorId = 4 },
                new Desk { Id = 38, DeskNumber = 38, RoomFloorId = 4 },
                new Desk { Id = 39, DeskNumber = 39, RoomFloorId = 4 },
                new Desk { Id = 40, DeskNumber = 40, RoomFloorId = 4 }

                );


            modelBuilder.Entity<WorkTools>().HasData(
                new WorkTools { Id = 1, Desktop = true, DockingStation = false, Keyboard = false, Mouse = true, DeskId = 1 },
                new WorkTools { Id = 2, Desktop = false, DockingStation = false, Keyboard = false, Mouse = false, DeskId = 2 },
                new WorkTools { Id = 3, Desktop = true, DockingStation = true, Keyboard = false, Mouse = true, DeskId = 3 },
                new WorkTools { Id = 4, Desktop = true, DockingStation = false, Keyboard = true, Mouse = true, DeskId = 4 },
                new WorkTools { Id = 5, Desktop = true, DockingStation = false, Keyboard = false, Mouse = true, DeskId = 5 },
                new WorkTools { Id = 6, Desktop = false, DockingStation = false, Keyboard = false, Mouse = false, DeskId = 6 },
                new WorkTools { Id = 7, Desktop = true, DockingStation = true, Keyboard = false, Mouse = true, DeskId = 7 },
                new WorkTools { Id = 8, Desktop = true, DockingStation = false, Keyboard = true, Mouse = true, DeskId = 8 },
                new WorkTools { Id = 9, Desktop = true, DockingStation = false, Keyboard = false, Mouse = true, DeskId = 9 },
                new WorkTools { Id = 10, Desktop = false, DockingStation = false, Keyboard = false, Mouse = false, DeskId = 10 },
                new WorkTools { Id = 11, Desktop = true, DockingStation = true, Keyboard = false, Mouse = true, DeskId = 11 },
                new WorkTools { Id = 12, Desktop = true, DockingStation = false, Keyboard = true, Mouse = true, DeskId = 12 },
                new WorkTools { Id = 13, Desktop = true, DockingStation = false, Keyboard = false, Mouse = true, DeskId = 13 },
                new WorkTools { Id = 14, Desktop = false, DockingStation = false, Keyboard = false, Mouse = false, DeskId = 14 },
                new WorkTools { Id = 15, Desktop = true, DockingStation = true, Keyboard = false, Mouse = true, DeskId = 15 },
                new WorkTools { Id = 16, Desktop = true, DockingStation = false, Keyboard = true, Mouse = true, DeskId = 16 },
                new WorkTools { Id = 17, Desktop = true, DockingStation = false, Keyboard = false, Mouse = true, DeskId = 17 },
                new WorkTools { Id = 18, Desktop = false, DockingStation = false, Keyboard = false, Mouse = false, DeskId = 18 },
                new WorkTools { Id = 19, Desktop = true, DockingStation = true, Keyboard = false, Mouse = true, DeskId = 19 },
                new WorkTools { Id = 20, Desktop = true, DockingStation = false, Keyboard = true, Mouse = true, DeskId = 20 },
                new WorkTools { Id = 21, Desktop = true, DockingStation = false, Keyboard = false, Mouse = true, DeskId = 21 },
                new WorkTools { Id = 22, Desktop = false, DockingStation = false, Keyboard = false, Mouse = false, DeskId = 22 },
                new WorkTools { Id = 23, Desktop = true, DockingStation = true, Keyboard = false, Mouse = true, DeskId = 23 },
                new WorkTools { Id = 24, Desktop = true, DockingStation = false, Keyboard = true, Mouse = true, DeskId = 24 },
                new WorkTools { Id = 25, Desktop = true, DockingStation = false, Keyboard = false, Mouse = true, DeskId = 25 },
                new WorkTools { Id = 26, Desktop = false, DockingStation = false, Keyboard = false, Mouse = false, DeskId = 26 },
                new WorkTools { Id = 27, Desktop = true, DockingStation = true, Keyboard = false, Mouse = true, DeskId = 27 },
                new WorkTools { Id = 28, Desktop = true, DockingStation = false, Keyboard = true, Mouse = true, DeskId = 28 },
                new WorkTools { Id = 29, Desktop = true, DockingStation = false, Keyboard = false, Mouse = true, DeskId = 29 },
                new WorkTools { Id = 30, Desktop = false, DockingStation = false, Keyboard = false, Mouse = false, DeskId = 30 },
                new WorkTools { Id = 31, Desktop = true, DockingStation = true, Keyboard = false, Mouse = true, DeskId = 31 },
                new WorkTools { Id = 32, Desktop = true, DockingStation = false, Keyboard = true, Mouse = true, DeskId = 32 },
                new WorkTools { Id = 33, Desktop = true, DockingStation = false, Keyboard = false, Mouse = true, DeskId = 33 },
                new WorkTools { Id = 34, Desktop = false, DockingStation = false, Keyboard = false, Mouse = false, DeskId = 34 },
                new WorkTools { Id = 35, Desktop = true, DockingStation = true, Keyboard = false, Mouse = true, DeskId = 35 },
                new WorkTools { Id = 36, Desktop = true, DockingStation = false, Keyboard = true, Mouse = true, DeskId = 36 },
                new WorkTools { Id = 37, Desktop = true, DockingStation = false, Keyboard = false, Mouse = true, DeskId = 37 },
                new WorkTools { Id = 38, Desktop = false, DockingStation = false, Keyboard = false, Mouse = false, DeskId = 38 },
                new WorkTools { Id = 39, Desktop = true, DockingStation = true, Keyboard = false, Mouse = true, DeskId = 39 },
                new WorkTools { Id = 40, Desktop = true, DockingStation = false, Keyboard = true, Mouse = true, DeskId = 40 }
                );


            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, DeskId = 1, UserId = 1, ReservationDate = new DateTime(2026, 08, 05) },
                new Reservation { Id = 2, DeskId = 2, UserId = 2, ReservationDate = new DateTime(2026, 08, 06) },
                new Reservation { Id = 3, DeskId = 3, UserId = 3, ReservationDate = new DateTime(2026, 08, 12) },
                new Reservation { Id = 4, DeskId = 4, UserId = 4, ReservationDate = new DateTime(2026, 08, 21) },
                new Reservation { Id = 5, DeskId = 23, UserId = 5, ReservationDate = new DateTime(2025, 12, 01) },
                new Reservation { Id = 6, DeskId = 32, UserId = 6, ReservationDate = new DateTime(2026, 09, 02) },
                new Reservation { Id = 7, DeskId = 11, UserId = 7, ReservationDate = new DateTime(2026, 09, 03) },
                new Reservation { Id = 8, DeskId = 12, UserId = 8, ReservationDate = new DateTime(2026, 10, 03) },
                new Reservation { Id = 9, DeskId = 18, UserId = 9, ReservationDate = new DateTime(2026, 09, 08) },
                new Reservation { Id = 10, DeskId = 21, UserId = 7, ReservationDate = new DateTime(2026, 09, 09) },
                new Reservation { Id = 11, DeskId = 22, UserId = 5, ReservationDate = new DateTime(2026, 09, 05) },
                new Reservation { Id = 12, DeskId = 40, UserId = 6, ReservationDate = new DateTime(2026, 11, 04) },
                new Reservation { Id = 13, DeskId = 26, UserId = 9, ReservationDate = new DateTime(2026, 07, 05) },
                new Reservation { Id = 14, DeskId = 35, UserId = 4, ReservationDate = new DateTime(2026, 09, 09) },
                new Reservation { Id = 15, DeskId = 7, UserId = 3, ReservationDate = new DateTime(2026, 01, 02) },
                new Reservation { Id = 16, DeskId = 33, UserId = 2, ReservationDate = new DateTime(2026, 10, 25) },
                new Reservation { Id = 17, DeskId = 12, UserId = 9, ReservationDate = new DateTime(2026, 09, 05) },
                new Reservation { Id = 18, DeskId = 4, UserId = 7, ReservationDate = new DateTime(2026, 08, 05) },
                new Reservation { Id = 19, DeskId = 9, UserId = 1, ReservationDate = new DateTime(2026, 08, 01) },
                new Reservation { Id = 20, DeskId = 24, UserId = 7, ReservationDate = new DateTime(2026, 12, 15) }
                );
        }
    }
}
