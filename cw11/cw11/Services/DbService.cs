using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public class DbService : IDbService
    {
        DoctorsDbContext _context;
        public DbService(DoctorsDbContext context)
        {
            _context = context;
        }

        public void AddDoctor(Doctor doctor)
        {
           _context.Doctors.Add(doctor);
        }

        public IEnumerable<Doctor> GetDoctors()
        {
           return _context.Doctors.ToList();
        }

        public void RemoveDoctor(int id)
        {
            _context.Doctors.Remove(_context.Doctors.First(d => d.IdDoctor == id));
        }

        public void  UpdateDoctor(Doctor doctor)
        {   
            var newDoctor = _context.Doctors.First(d => d.IdDoctor == doctor.IdDoctor);
            newDoctor.LastName = doctor.LastName;
            newDoctor.Email = doctor.Email;
            newDoctor.FirstName = doctor.FirstName;
        }

        public void createDatabaseExampleData()

        {
            _context.Doctors.Add(new Doctor

            {
                Email = "aaab@gmail.com",
                FirstName = "Doctor1",
                LastName = "Lop",
            });

            _context.Patients.Add(new Patient

            {
                Birthday = DateTime.Now,
                FirstName = "Patient1",
                LastName = "Pat"

            });

          

          

            _context.Prescriptions.Add(new Prescription

            {

                IdPatient = _context.Patients.Min(e => e.IdPatient),
                IdDoctor = _context.Doctors.Min(e => e.IdDoctor),
                date = DateTime.Now,
                dueDate = DateTime.Now,

            });






            _context.Medicaments.Add(new Medicament

            {
                Name = "Lek",
                Description = "Description",
                Type = "Type"

            });

          

     

          

            _context.Prescriptions_Medicaments.Add(new Prescription_Medicament

            {
               Details = "Uzycz",
               Dose = 1,
               IdMedicament = _context.Medicaments.Min(e => e.IdMedicament),
               IdPrescription = _context.Prescriptions.Min(e => e.IdPrescription),



            });



            _context.Prescriptions_Medicaments.Add(new Prescription_Medicament

            {

                Details = "Uzycz",
                Dose = 2,
                IdMedicament = _context.Medicaments.Min(e => e.IdMedicament),
                IdPrescription = _context.Prescriptions.Min(e => e.IdPrescription),



            });

            _context.SaveChanges();

        }
    }
}
