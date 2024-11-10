using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using DoAnLTW.Models;

namespace DoAnLTW.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        // hello

        QL_TX data = new QL_TX();
        public ActionResult LoaiSP()
        {
            var l = data.Loais.ToList(); 
            return View(l);
        }

    }
}
