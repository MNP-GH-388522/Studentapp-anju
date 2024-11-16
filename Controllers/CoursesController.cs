using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student_app.Data;
using Student_app;

using System.Collections.Generic;
using System.Threading.Tasks;

public class CoursesController : Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesControllers : Controller
    {
        private readonly AppDbContext _context;

        public CoursesControllers(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            return await _context.Courses.ToListAsync();
        }

        [HttpPost]
        public ActionResult<Course> PostCourse(Course course)
        {
            _context.C

                }
    }