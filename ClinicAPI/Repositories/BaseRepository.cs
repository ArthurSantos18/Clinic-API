using ClinicAPI.Data;
using ClinicAPI.Repository.Interface;

namespace ClinicAPI.Repository
{
    public class BaseRepository : IBaseRepository
    {
        private readonly ClinicContext _clinicContext;

        public BaseRepository(ClinicContext clinicContext)
        {
            _clinicContext = clinicContext;
        }

        public void Add<T>(T entity) where T : class
        {
            _clinicContext.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SaveChangeAsync()
        {
            return await _clinicContext.SaveChangesAsync() > 0;
        }

        public void Update<T>(T entity) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
