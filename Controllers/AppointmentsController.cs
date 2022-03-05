using AppointmentMaker.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentMaker.Controllers
{
    public class AppointmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowAppointmentDetails(AppointmentModel model) 
        {
            return View("ShowAppointmentDetails", model);
        }
    }
}
