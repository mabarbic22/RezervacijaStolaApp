using Microsoft.EntityFrameworkCore;


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
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().Property(u => u.Name).IsRequired().HasMaxLength(20);
            modelBuilder.Entity<User>().Property(u => u.Surname).IsRequired().HasMaxLength(30);
            modelBuilder.Entity<User>().Property(u => u.MailAdress).IsRequired().HasMaxLength(100);


            modelBuilder.Entity<Desk>().Property(d => d.DeskNumber).IsRequired();
            modelBuilder.Entity<Desk>().Property(d => d.RoomFloorId).IsRequired();

            modelBuilder.Entity<Reservation>().Property(r => r.ReservationDate).IsRequired();
            modelBuilder.Entity<Reservation>().Property(r => r.UserId).IsRequired();
            modelBuilder.Entity<Reservation>().Property(r => r.DeskId).IsRequired();
            // Provjera dvostruke rezervacije istog stola sa istim datumom
            modelBuilder.Entity<Reservation>()
                .HasIndex(r => new { r.DeskId, r.ReservationDate })
                .IsUnique();


            modelBuilder.Entity<User>().HasData(
               new User { Id = 1, Name = "Marko", Surname = "Barbić", MailAdress = "mabarbic22@gmail.com", CellPhoneNumber = "0993855267" },
               new User { Id = 2, Name = "Nikolina", Surname = "Barbić", MailAdress = "nibarbic22@gmail.com", CellPhoneNumber = "0993456755" },
               new User { Id = 3, Name = "Tomislav", Surname = "Marković", MailAdress = "tomi12@gmail.com", CellPhoneNumber = "0912675098" },
               new User { Id = 4, Name = "Josip", Surname = "Ninić", MailAdress = "josip.ninic@vsite.hr", CellPhoneNumber = "0923456123" }
           );


            modelBuilder.Entity<Desk>().HasData(
                new Desk { Id = 1, DeskNumber = 124, RoomFloorId = 1 },
                new Desk { Id = 2, DeskNumber = 224, RoomFloorId = 2 },
                new Desk { Id = 3, DeskNumber = 098, RoomFloorId = 2 },
                new Desk { Id = 4, DeskNumber = 13, RoomFloorId = 3 },
                new Desk { Id = 5, DeskNumber = 295, RoomFloorId = 4 }
                );


            modelBuilder.Entity<WorkTools>().HasData(
                new WorkTools { Id = 1, Desktop = true, DockingStation = false, Keyboard = false, Mouse = true, DeskId = 1 },
                new WorkTools { Id = 2, Desktop = false, DockingStation = false, Keyboard = false, Mouse = false, DeskId = 2 },
                new WorkTools { Id = 3, Desktop = true, DockingStation = true, Keyboard = false, Mouse = true, DeskId = 3 },
                new WorkTools { Id = 4, Desktop = true, DockingStation = false, Keyboard = true, Mouse = true, DeskId = 4 }
                );


            modelBuilder.Entity<RoomFloor>().HasData(
                new RoomFloor { Id = 1, Floor = "-1", FloorDescription = "Suteren", FloorShort = "S" },
                new RoomFloor { Id = 2, Floor = "0", FloorDescription = "Prizemlje", FloorShort = "P" },
                new RoomFloor { Id = 3, Floor = "1", FloorDescription = "Prvi kat", FloorShort = "K1" },
                new RoomFloor { Id = 4, Floor = "2", FloorDescription = "Drugi kat", FloorShort = "K2" }
                );


            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, DeskId = 1, UserId = 1, ReservationDate = new DateTime(2026, 08, 05) },
                new Reservation { Id = 2, DeskId = 2, UserId = 2, ReservationDate = new DateTime(2026, 08, 06) },
                new Reservation { Id = 3, DeskId = 3, UserId = 3, ReservationDate = new DateTime(2026, 08, 12) },
                new Reservation { Id = 4, DeskId = 4, UserId = 4, ReservationDate = new DateTime(2026, 08, 21) },
                new Reservation { Id = 5, DeskId = 2, UserId = 4, ReservationDate = new DateTime(2026, 09, 01) },
                new Reservation { Id = 6, DeskId = 3, UserId = 3, ReservationDate = new DateTime(2026, 09, 02) },
                new Reservation { Id = 7, DeskId = 1, UserId = 2, ReservationDate = new DateTime(2026, 09, 03) },
                new Reservation { Id = 8, DeskId = 4, UserId = 1, ReservationDate = new DateTime(2026, 09, 04) },
                new Reservation { Id = 9, DeskId = 4, UserId = 1, ReservationDate = new DateTime(2026, 09, 05) },
                new Reservation { Id = 10, DeskId = 3, UserId = 2, ReservationDate = new DateTime(2026, 09, 06) },
                new Reservation { Id = 11, DeskId = 2, UserId = 3, ReservationDate = new DateTime(2026, 08, 07) },
                new Reservation { Id = 12, DeskId = 5, UserId = 4, ReservationDate = new DateTime(2026, 08, 08) },
                new Reservation { Id = 13, DeskId = 5, UserId = 1, ReservationDate = new DateTime(2026, 08, 09) }

                );
        }
    }
}
