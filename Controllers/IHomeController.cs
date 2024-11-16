using Microsoft.AspNetCore.Mvc;

namespace Student_app.Controllers
{
    public interface IHomeController
    {
        Task<ActionResult<Enrolment>> EnrollStudent(Enrolment enrolment);
        Task<ActionResult<IEnumerable<Enrolment>>> GetEnrolments();
    }
}