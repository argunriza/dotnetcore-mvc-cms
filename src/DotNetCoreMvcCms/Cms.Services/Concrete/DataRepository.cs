﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cms.Data.DbContext;
using Cms.Services.Abstract;

namespace Cms.Services.Concrete
{
	public class DataRepository<TEntity> : IDataRepository<TEntity> where TEntity : class, new()
	{
		private readonly AppDbContext _dbContext;

		public DataRepository(AppDbContext dbContext)
		{
			this._dbContext = dbContext;
		}

		public async Task<TEntity?> GetByIdAsync(int id)
		{
			return await this._dbContext.Set<TEntity>().FindAsync(id);
		}

		public IQueryable<TEntity> GetAll()
		{
			return _dbContext.Set<TEntity>();
		}

		public async Task<TEntity> AddAsync(TEntity entity)
		{
			if (entity == null)
			{
				throw new ArgumentNullException(nameof(entity));
			}

			await this._dbContext.Set<TEntity>().AddAsync(entity);
			await this._dbContext.SaveChangesAsync();

			return entity;
		}

		public async Task<bool> DeleteAsync(int id)
		{
			var entity = await GetByIdAsync(id);

			if (entity == null)
			{
				return false; // Silinecek nesne bulunamazsa false döndürüyoruz.
			}

			_dbContext.Set<TEntity>().Remove(entity);
			await _dbContext.SaveChangesAsync();

			return true;
		}

		public async Task<TEntity?> UpdateAsync(int id, TEntity entity)
		{
			if (entity == null)
			{
				throw new ArgumentNullException(nameof(entity));
			}

			var existingEntity = await GetByIdAsync(id);

			if (existingEntity == null)
			{
				return null; // Güncellenecek nesne bulunamazsa null döndürüyoruz.
			}

			_dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);
			await _dbContext.SaveChangesAsync();

			return entity;
		}
	}
}
