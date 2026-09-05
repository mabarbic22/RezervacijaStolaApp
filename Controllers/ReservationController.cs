
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using RezervacijaStolaApp.Models.Data;
using System.Linq;

public class ReservationController : Controller
{
    private readonly DeskReservationDataContext _context;

    public ReservationController(DeskReservationDataContext context)
    {
        _context = context;
    }

    // GET: RESERVATIONS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Reservations.OrderByDescending(r => r.ReservationDate).Include(r=>r.User).Include(r=>r.Desk).ToListAsync());
    }

    // GET: RESERVATIONS/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var reservation = await _context.Reservations.Include(r=>r.User).Include(r=>r.Desk)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (reservation == null)
        {
            return NotFound();
        }
        
        var roomFloor = await _context.RoomFloor.FirstOrDefaultAsync(r => r.Id == reservation.Desk.RoomFloorId);

        if(roomFloor == null)
        {
            return NotFound();
        }

        //u tablici reservations nemamo informaciju o katu na kojem se soba nalazi pa onda dodajemo ovim korakom podatke gdje je soba. 
        //ovo bi trebalo doraaditi na način da se u tablici odmah definira veza pa se ovaj korak preskoči
        reservation.Desk.RoomFloor = roomFloor;


        return View(reservation);
    }

    // GET: RESERVATIONS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: RESERVATIONS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Id,ReservationDate,UserId,User,DeskId,Desk")] Reservation reservation)
    {
        if (ModelState.IsValid)
        {
            _context.Add(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(reservation);
    }

    // GET: RESERVATIONS/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var reservation = await _context.Reservations.FindAsync(id);
        if (reservation == null)
        {
            return NotFound();
        }

        ViewBag.Users = new SelectList(
            _context.Users.Select(u => new { Id = u.Id, FullName = u.Name + " " + u.Surname }).ToList(),
            "Id",
            "FullName"
        );

        ViewBag.Desks = new SelectList(
           _context.Desks.Select(d => new { Id = d.Id, DeskNumber = d.DeskNumber + " - " + d.RoomFloor.FloorDescription}).ToList(),
           "Id",
           "DeskNumber"
       );


        return View(reservation);
    }

    // POST: RESERVATIONS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? id, [Bind("Id,ReservationDate,UserId,User,DeskId,Desk")] Reservation reservation)
    {
        if (id != reservation.Id)
        {
            return NotFound();
        }

        // Ručno uklanjamo navigacijske objekte iz validacije forme
        ModelState.Remove("Desk");
        ModelState.Remove("User");

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(reservation);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException sqliteEx)
            {
                if (sqliteEx.InnerException != null)
                {
                    if (sqliteEx.InnerException.Message.Contains("UNIQUE constraint failed"))
                    {
                        // Spremamo poruku u TempData kako bi prikazali na ekranu a ne da nas preusmjeri na novu stranicu
                        TempData["AlertMessage"] = "Stol je zauzet za navedeni daatum!";
                        //return NotFound("Odabrana soba je zauzeta za traženi datum.");
                    }
                }
            }

            return RedirectToAction(nameof(Index));
        }
        return View(reservation);
    }

    // GET: RESERVATIONS/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var reservation = await _context.Reservations
            .FirstOrDefaultAsync(m => m.Id == id);
        if (reservation == null)
        {
            return NotFound();
        }

        //ViewBag.Users = new SelectList(
        //    _context.Users.Select(u => new { Id = u.Id, FullName = u.Name + " " + u.Surname }).ToList(),
        //    "Id",
        //    "FullName"
        //);

        var userList = _context.Users.Where(u => u.Id == reservation.UserId).ToList();
        var selectedUser = userList.Select(u => new {
            Id= u.Id,
            FullName = u.Name + " " + u.Surname
        }).ToList();
        ViewBag.User = new SelectList(selectedUser, "Id", "FullName");


        var deskList = _context.Desks.Where(d => d.Id == reservation.DeskId).ToList();
        var selectedDesk = deskList.Select(d => new{
            Id = d.Id,
            DeskNumber = d.DeskNumber
        }).ToList();
        ViewBag.Desks = new SelectList(selectedDesk,"Id","DeskNumber");

        return View(reservation);
    }

    // POST: RESERVATIONS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? id)
    {
        var reservation = await _context.Reservations.FindAsync(id);
        if (reservation != null)
        {
            _context.Reservations.Remove(reservation);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ReservationExists(int? id)
    {
        return _context.Reservations.Any(e => e.Id == id);
    }
}
