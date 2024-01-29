using System.Xml.Linq;
using Projekti.Data;
using Projekti.Data.Models;
using Projekti.Data.ViewModels;

namespace Projekti.Data.Services
{
    public class RezervimeServices
    {
        private AppDbContext _context;
        public RezervimeServices(AppDbContext context)
        {
            _context = context;
        }
        public void AddRezervim(RezervimeVM rez)
        {
            var rezervim = new Rezervim()
            {
                Emri = rez.Emri,
                Desc = rez.Desc,
                Location = rez.Location,
                Koha = rez.Koha,
            };
            _context.Rezervime.Add(rezervim);
            _context.SaveChanges();
        }
        public List<Rezervim> GetAllRezervime()
        {
            var allRezervime = _context.Rezervime.ToList();
            return allRezervime;
        }
        public Rezervim GetRezervimByid(int rezervimID)
        {
            var rezervim = _context.Rezervime.FirstOrDefault(n => n.ID == rezervimID);
            return rezervim;
        }
        public Rezervim UpdateRezervimById(int rezervimID, RezervimeVM rezvm)
        {
            var rezervim = _context.Rezervime.FirstOrDefault(n => n.ID == rezervimID);
            if (rezervim != null)
            {
                rezervim.Emri = rezervim.Emri;
                rezervim.Desc = rezervim.Desc;
                rezervim.Koha = rezervim.Koha;
                rezervim.Location = rezervim.Location;
                _context.SaveChanges();
            }
            return rezervim;

        }
        public void DeleteRezervimById(int rezervimID) 
        {
            var rezervim= _context.Rezervime.FirstOrDefault(n => n.ID == rezervimID);
            if (rezervim != null)
            {
                _context.Rezervime.Remove(rezervim);
                _context.SaveChanges();
            }
        }
    }
}
