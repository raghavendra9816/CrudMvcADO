using CrudMvcADO.Models;
using CrudMvcADO.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMvcADO.Controllers
{
    public class UserController : Controller
    {
        UserDAL userDAL=new UserDAL();  
        // GET: User
        public ActionResult List()
        {
            var data = userDAL.GetUSers();
            return View(data);
        }
        public ActionResult Create()
        {
          
            return View();
        }


        [HttpPost]
        public ActionResult Create(UserModel user)
        {
            if (userDAL.InsertUser(user))
            {
                TempData["InsertMsg"] = "<script>alert('user saved successful...')</script>";
                return RedirectToAction("List");
            }
            else
            {
                TempData["InsertErrorMsg"] = "<script>alert('Not saved')</script>";
            }

            return View();
        }


        public ActionResult Details(int id)
        {
            var data = userDAL.GetUSers().Find(a => a.Id == id);
            return View(data);
        }




        public ActionResult Edit(int id)
        {
            var data = userDAL.GetUSers().Find(a=>a.Id==id);
            return View(data);
        }

    [HttpPost]
        public ActionResult Edit(UserModel user)
        {
            if (userDAL.UpdateUser(user))
            {
                TempData["UpdateMsg"] = "<script>alert('user Updated  successful...')</script>";
                return RedirectToAction("List");
            }
            else
            {
                TempData["updateErrorMsg"] = "<script>alert(' user Not updated ')</script>";
            }

            return View(user);
        }

       
        public ActionResult Delete(int  id)
        {
            int r=userDAL.DeleteUser(id);
            if (r > 0)
            {
                TempData["DeleteMsg"] = "<script> alert('user deleted  successful...')</script>";
                return RedirectToAction("List");
            }
            else
            {
                TempData["DeleteErrorMsg"] = "<script> alert(' user Not deleted ')</script>";
               
            }
            return View();

        }
    }
}