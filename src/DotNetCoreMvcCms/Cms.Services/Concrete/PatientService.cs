using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cms.Data.DbContext;
using Cms.Data.Models.Entities;
using Cms.Services.Abstract;

namespace Cms.Services.Concrete
{
    public class PatientService : IPatientService
    {
        private readonly IDataRepository<PatientEntity> _patientrepository;
        private readonly AppDbContext _appDbContext;

        public PatientService(IDataRepository<PatientEntity> patientrepository, AppDbContext appDbContext)
        {
            this._patientrepository = patientrepository;
            this._appDbContext = appDbContext;
        }

        public IQueryable<PatientEntity> GetAll()
        {
            return _patientrepository.GetAll();
        }

        public async Task<PatientEntity?> GetByIdAsync(int id)
        {
            return await _patientrepository.GetByIdAsync(id);
        }

        public async Task<PatientEntity> AddAsync(PatientEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            return await _patientrepository.AddAsync(entity);
        }

        public async Task<PatientEntity?> UpdateAsync(int id, PatientEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity));
            }

            return await _patientrepository.UpdateAsync(id, entity);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _patientrepository.DeleteAsync(id);
        }
    }
}
