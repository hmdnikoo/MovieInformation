using System;
using System.Threading;
using System.Threading.Tasks;

namespace MovieInformation.Persistence.EF
{
    public class UnitOfWork
    {
        private readonly MovieInformationDbContext _context;

        public UnitOfWork(MovieInformationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CommitAsync(CancellationToken cancellationToken = default)
        {
            try
            {
                return await _context.SaveChangesAsync(cancellationToken).ConfigureAwait(false) > 0;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public bool Commit(CancellationToken cancellationToken = default)
        {
            try
            {
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
