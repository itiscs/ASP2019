using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiClient.Models;
using WebApiClient.Services;

namespace WebApiClient.Controllers
{
    public class UsersController : Controller
    {
        UserService serv = new UserService();

        public IActionResult Index()
        {
            var users = serv.GetUsers().Result;
            return View(users);
        }
        public IActionResult Details(int id)
        {
            var user = serv.GetUsersByID(id).Result;
            return View(user);
        }

        [HttpGet]
        public ViewResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([Bind("Name", "Age")] User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var res = await serv.AddUser(user);
            return RedirectToAction("Index", "Users");
        }

        public IActionResult Delete(int id)
        {
            var user = serv.GetUsersByID(id).Result;
            return View(user);
        }

        // POST: Phones/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var res = await serv.DeleteUser(id);
            return RedirectToAction("Index", "Users");
        }

    }
}