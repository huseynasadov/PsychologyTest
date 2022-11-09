using Psychology.Core;
using Psychology.Core.Repositories;
using Psychology.Data.Repositories;
using System.Threading.Tasks;

namespace Psychology.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PsychologyDbContext _context;

        private AdminRepository _adminRepository;
        private QuestionRepository _questionRepository;
        public UnitOfWork(PsychologyDbContext context)
        {
            this._context = context;
        }

        public IAdminRepository Admin => _adminRepository ??= new AdminRepository(_context);
        public IQuestionRepository Question => _questionRepository ??= new QuestionRepository(_context);

        public async Task<int> CommitAsync() => await _context.SaveChangesAsync();

        public void Dispose() => _context.Dispose();
    }
}
