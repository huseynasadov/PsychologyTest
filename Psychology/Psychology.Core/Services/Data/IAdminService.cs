using Psychology.Core.Enums;
using Psychology.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Psychology.Core.Services.Data
{
    public interface IAdminService
    {
        Task<Admin> CheckLogin(string email, string password);
        Task<Admin> CheckToken(string token);
        Task<bool> CheckEmail(string email);
        Task UpdateToken(long id, string token, TokenEnum tokenEnum);
        Task<Admin> GetAdminByToken(string invitedToken);
        Task<IEnumerable<Admin>> GetAllAdmin();
        Task<IEnumerable<Admin>> GetAllAdmin(int skip,int page,string order,string search);
        Task<int> GetAllAdminCount();
        Task<Admin> GetAdminById(long id);
        Task<Admin> GetAdminByEmail(string email);
        Task<Admin> CreateAdmin(Admin newAdmin);
        Task UpdateAdmin(Admin adminToBeUpdated, Admin admin);
        Task UpdateStatus(long adminId, byte AdminStatus, string ModifiedBy);
        Task DeleteAdmin(Admin admin);
    }
}
