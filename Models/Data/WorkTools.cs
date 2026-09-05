using System.ComponentModel.DataAnnotations;

namespace RezervacijaStolaApp.Models.Data
{
    public class WorkTools
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        public bool Desktop { get; set; }
        public bool Mouse { get; set; }
        public bool Keyboard { get; set; }
        public bool DockingStation { get; set; }
        public int? DeskId { get; set; }
    }
}
