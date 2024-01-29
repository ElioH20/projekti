using Projekti.Data.Models;
using Projekti.Data.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Projekti.Data.Services
{
    public interface IRezervimeService
    {
        Task<List<Rezervim>> GetAllRezervimeAsync();
        Task<Rezervim> GetRezrvimByIdAsync(int ID);
        Task AddRezervimAsync(RezervimeVM rezervim);
        Task<Rezervim> UpdateRezervimAsync(int ID, RezervimeVM rezervim);
        Task DeleteRezervimByIdAsync(int ID);
    }
}

