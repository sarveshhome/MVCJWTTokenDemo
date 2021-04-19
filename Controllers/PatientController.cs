using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCJWTTokenDemo.DAL;
using MVCJWTTokenDemo.Model;

namespace MVCJWTTokenDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientController : ControllerBase
    {
        private PatientDbContext _db = null;

        public PatientController(PatientDbContext db,ILogger logger)
        {
            _db = db;
            db.Database.EnsureCreated();
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
        [HttpPost("/api/patient")]
        public IActionResult AddPatient(Patient patientObj)
        {

            _db.Patients.Add(patientObj); //in memory
            _db.SaveChanges(); //physical commit 
            return Content("result");
        }
    }
}