﻿using Cms.Data.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cms.Services.Abstract
{
    public interface IPatientService : IDataRepository<PatientEntity>
    {
        new IQueryable<PatientEntity> GetAll();

        new Task<PatientEntity?> GetByIdAsync(int id);

        new Task<PatientEntity> AddAsync(PatientEntity entity);

        new Task<PatientEntity?> UpdateAsync(int id, PatientEntity entity);

        new Task<bool> DeleteAsync(int id);
    }
}
