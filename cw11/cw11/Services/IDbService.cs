﻿using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public interface IDbService
    {
        public IEnumerable<Doctor> GetDoctors();
        public void AddDoctor(Doctor doctor);
        public void UpdateDoctor(Doctor doctor);
        public void RemoveDoctor(int id);
    }
}
