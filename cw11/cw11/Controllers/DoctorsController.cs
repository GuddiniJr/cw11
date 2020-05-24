using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;
using cw11.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace czw11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {

        private readonly IDbService _context;
        public DoctorsController(IDbService context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_context.GetDoctors());
        }
        [HttpPost]
        public IActionResult AddDoctor(Doctor doctor)
        {

            _context.AddDoctor(doctor);
            return Ok(_context.GetDoctors());

        }
        [HttpPost("{id}")]
        public IActionResult RemoveDoctor(int id)
        {

            _context.RemoveDoctor(id);
            return Ok(_context.GetDoctors());

        }

        [HttpPost]
        public IActionResult UpdateDoctor(Doctor doctor)
        {

            _context.UpdateDoctor(doctor);
            return Ok(_context.GetDoctors());

        }

    }
}