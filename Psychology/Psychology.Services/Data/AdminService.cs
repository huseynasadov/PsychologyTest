using CryptoHelper;
using Psychology.Core;
using Psychology.Core.Models;
using Psychology.Core.Services.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using Psychology.Core.Enums;

namespace Psychology.Services.Data
{
    public class AdminService : IAdminService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AdminService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CheckEmail(string email)
        {
            Admin Admin = await _unitOfWork.Admin.SingleOrDefaultAsync(w => w.Email.ToLower() == email.ToLower() && w.Status);

            return Admin != null ? true : false;
        }

        public async Task<Admin> CheckLogin(string email, string password)
        {
            Admin Admin = await _unitOfWork.Admin.SingleOrDefaultAsync(w => w.Email.ToLower() == email.ToLower() && w.Status);

            if (Admin != null && Crypto.VerifyHashedPassword(Admin.Password, password))
            {
                return Admin;
            }

            return null;
        }

        public async Task<Admin> CheckToken(string token)
        {
            return await _unitOfWork.Admin.FindByToken(token);
        }

        public async Task<Admin> GetAdminByToken(string invitedToken)
        {
            return await _unitOfWork.Admin.SingleOrDefaultAsync(w => w.InvitedToken == invitedToken && w.Status);
        }

        public async Task UpdateToken(long id, string token, TokenEnum tokenEnum)
        {
            Admin Admin = await _unitOfWork.Admin.SingleOrDefaultAsync(a => a.Id == id && a.Status);

            if (tokenEnum == TokenEnum.Token)
                Admin.Token = token;
            else
                Admin.InvitedToken = token;

            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Admin>> GetAllAdmin()
        {
            return await _unitOfWork.Admin.GetAllWithAdminAsync();
        }

        public async Task<IEnumerable<Admin>> GetAllAdmin(int skip, int page, string order, string search)
        {
            var admins = await _unitOfWork.Admin.GetAllFilterAsync(filter => filter.Status && filter.Fullname.Contains(search), o => o.OrderBy(string.IsNullOrEmpty(order) ? "Id desc" : order), null, skip, page);
            return admins;
        }

        public async Task<int> GetAllAdminCount()
        {
            return await _unitOfWork.Admin.GetAllWithAdminCountAsync();
        }

        public async Task<Admin> GetAdminById(long id)
        {
            return await _unitOfWork.Admin.GetAllWithAdminById(id);
        }

        public async Task<Admin> GetAdminByEmail(string email)
        {
            return await _unitOfWork.Admin.GetAllWithAdminByEmail(email);
        }

        public async Task<Admin> CreateAdmin(Admin newAdmin)
        {
            if (!string.IsNullOrEmpty(newAdmin.Password))
                newAdmin.Password = Crypto.HashPassword(newAdmin.Password);

            await _unitOfWork.Admin.AddAsync(newAdmin);

            await _unitOfWork.CommitAsync();

            return newAdmin;
        }

        public async Task UpdateAdmin(Admin adminToBeUpdated, Admin admin)
        {
            if (!string.IsNullOrEmpty(admin.Password))
                adminToBeUpdated.Password = Crypto.HashPassword(admin.Password);
            if (admin.Fullname != null)
                adminToBeUpdated.Fullname = admin.Fullname;
            if (admin.AdminStatus != 0)
                adminToBeUpdated.AdminStatus = admin.AdminStatus;
            if (!string.IsNullOrEmpty(admin.Email))
                adminToBeUpdated.Email = admin.Email;

            adminToBeUpdated.ModifiedDate = DateTime.Now;
            adminToBeUpdated.ModifiedBy = admin.ModifiedBy;

            if (admin.Token == null)
                admin.Token = Guid.NewGuid().ToString();

            adminToBeUpdated.Token = admin.Token;

            adminToBeUpdated.InvitedToken = admin.InvitedToken;

            if (admin.ProfilePhoto != null)
                adminToBeUpdated.ProfilePhoto = admin.ProfilePhoto;

            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateStatus(long adminId, byte AdminStatus, string ModifiedBy)
        {
            var adminToBeUpdated = await _unitOfWork.Admin.GetAllWithAdminById(adminId);
            adminToBeUpdated.AdminStatus = AdminStatus;
            adminToBeUpdated.ModifiedDate = DateTime.Now;
            adminToBeUpdated.ModifiedBy = ModifiedBy;
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAdmin(Admin Admin)
        {
            Admin.Status = false;
            await _unitOfWork.CommitAsync();
        }
    }
}
