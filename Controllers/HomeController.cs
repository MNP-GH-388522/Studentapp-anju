using Microsoft.AspNetCore.Mvc;

namespace Student_app.Controllers
{
    public class HomeController(ApplicationDbContext context) : Controller, IHomeController
    {
        private readonly ApplicationDbContext _context = context;

        [HttpPost]
        public async Task<ActionResult<Enrolment>> EnrollStudent(Enrolment enrolment)
        {
            _context.Enrolments.Add(enrolment);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetEnrolment", new { id = enrolment.Id }, enrolment);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Enrolment>>> GetEnrolments()
        {
            return await _context.Enrolments.Include(e => e.Student).Include(e => e.Course).ToListAsync();
        }
    }
}
}
