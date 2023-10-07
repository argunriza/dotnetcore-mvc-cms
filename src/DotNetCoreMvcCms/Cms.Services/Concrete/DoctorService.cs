using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cms.Data.DbContext;
using Cms.Data.Models.Entities;
using Cms.Services.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Cms.Services.Concrete
{
	public class DoctorService : IDoctorService
	{
		private readonly IDataRepository<DoctorEntity> _dataRepository;
		private readonly AppDbContext _dbContext;

		public DoctorService(AppDbContext dbContext, IDataRepository<DoctorEntity> ıDataRepository)
		{
			this._dataRepository = ıDataRepository;
			this._dbContext = dbContext;
		}

		public IQueryable<DoctorEntity> GetAll()
		{
			return _dbContext.Doctors
			                 .Include(d => d.Category);
		}

		public async Task<DoctorEntity> AddAsync(DoctorEntity entity)
		{
			if (entity == null)
			{
				throw new ArgumentNullException(nameof(entity));
			}

			return await _dataRepository.AddAsync(entity);
		}

		public async Task<DoctorEntity?> GetByIdAsync(int id)
		{
			return await _dataRepository.GetByIdAsync(id);
		}

		public async Task<DoctorEntity?> UpdateAsync(int id, DoctorEntity entity)
		{
			if (entity == null)
			{
				throw new ArgumentNullException(nameof(entity));
			}

			return await _dataRepository.UpdateAsync(id, entity);
		}

		public async Task<bool> DeleteAsync(int id)
		{
			return await _dataRepository.DeleteAsync(id);
		}
	}
}
