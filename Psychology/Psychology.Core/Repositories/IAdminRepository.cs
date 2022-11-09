using Psychology.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Psychology.Core.Repositories
{
    public interface IAdminRepository : IRepository<Admin>
    {
        Task<Admin> FindByToken(string token);
        Task<IEnumerable<Admin>> GetAllWithAdminAsync();
        Task<int> GetAllWithAdminCountAsync();
        Task<Admin> GetAllWithAdminById(long id);
        Task<Admin> GetAllWithAdminByEmail(string email);
    }
}
