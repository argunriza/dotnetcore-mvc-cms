using Cms.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Services.Abstract
{
	public interface IDoctorService : IDataRepository<DoctorEntity>
	{
		new IQueryable<DoctorEntity> GetAll();

		new Task<DoctorEntity?> GetByIdAsync(int id);

		new Task<DoctorEntity> AddAsync(DoctorEntity entity);

		new Task<DoctorEntity?> UpdateAsync(int id, DoctorEntity entity);

		new Task<bool> DeleteAsync(int id);
	}
}
