using Microsoft.EntityFrameworkCore;
using Psychology.Core.Enums;
using Psychology.Core.Models;
using Psychology.Core.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Psychology.Data.Repositories
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        public AdminRepository(PsychologyDbContext context) : base(context) { }

        private PsychologyDbContext _context
        {
            get { return Context as PsychologyDbContext; }
        }

        public async Task<Admin> FindByToken(string token)
        {
            return await _context.Admins
                                 .FirstOrDefaultAsync(w => w.Token == token && w.Status && w.AdminStatus == (byte)AdminStatusEnum.Active);
        }

        public async Task<IEnumerable<Admin>> GetAllWithAdminAsync()
        {
            return await _context.Admins.Where(filter => filter.Status)
                                 .ToListAsync();
        }

        public async Task<int> GetAllWithAdminCountAsync()
        {
            return await _context.Admins.Where(filter => filter.Status).CountAsync();
        }

        public async Task<Admin> GetAllWithAdminById(long id)
        {
            return await _context.Admins
                                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Admin> GetAllWithAdminByEmail(string email)
        {
            return await _context.Admins
                                .FirstOrDefaultAsync(p => p.Email.ToLower() == email.ToLower() && p.Status && p.AdminStatus != (byte)AdminStatusEnum.Deactive);
        }
    }
}
