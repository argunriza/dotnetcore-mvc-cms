using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cms.Data.Models.Entities;

namespace Cms.Services.Abstract
{
    public interface IAdminService : IDataRepository<AdminEntity>
    {
        new IQueryable<AdminEntity> GetAll();

        new Task<AdminEntity?> GetByIdAsync(int id);

        new Task<AdminEntity> AddAsync(AdminEntity entity);

        new Task<AdminEntity?> UpdateAsync(int id, AdminEntity entity);

        new Task<bool> DeleteAsync(int id);

    }
}
