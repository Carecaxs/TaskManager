using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TaskManager.Data;
using TaskManager.Models;
using TaskManager.Services;

namespace TaskManager.Controllers
{
    public class AccessController : Controller
    {

        private readonly IUserService _userService;

        public AccessController(IUserService userService)
        {
            _userService = userService;

        }
        public IActionResult Menu()
        {
            return View();
        }

        public IActionResult Registro()
        {
            return View();
        }

        public IActionResult Tasks(int userId)
        {
            // get user by id
            var user = _userService.GetUserByIdAsync(userId).Result;

            // send the user to the view
            return View(user);
        }



        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(USERS user)
        {
            if (ModelState.IsValid)
            {
                await _userService.AddUserAsync(user);

                return RedirectToAction("Tasks", new { userId = user.Id });
            }

            //return the fields errors of the user
            return View(user);
        }


    }
}
