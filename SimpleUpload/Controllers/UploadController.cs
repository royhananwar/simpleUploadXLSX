using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleUpload.Models;
using Newtonsoft.Json.Linq;
using System.Data.Entity.Validation;

namespace SimpleUpload.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Store(List<base1> listBase1, List<base2> listBase2, List<base3> listBase3)
        {
            var message = "Success !";

            var _listBase1 = listBase1.ToList();
            var _listBase2 = listBase2.ToList();
            var _listBase3 = listBase3.ToList();

            using (ContextDB db = new ContextDB())
            using (var dbTransaction = db.Database.BeginTransaction())
            {
                foreach (var item in _listBase1)
                {
                    var _base1 = new base1()
                    {
                        factory = item.factory,
                        cal_size = item.cal_size,
                    };
                    db.base1.Add(_base1);
                }

                try
                {
                    db.SaveChanges();
                    dbTransaction.Commit();
                }
                catch (Exception e)
                {
                    dbTransaction.Rollback();
                    message = "Error! " + e.ToString();
                }
            }

            return Json(message);
        }

        //[HttpPost]
        //public ActionResult GetDataJSON()
        //{
        //    return
        //}
    }
}