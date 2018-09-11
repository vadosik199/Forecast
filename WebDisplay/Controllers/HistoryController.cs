using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using BasicForecaster.Models;
using PagedList;

namespace WebDisplay.Controllers
{
    public class HistoryController : Controller
    {
        // GET: History
        public ActionResult Index() {
            return RedirectToRoute(new { controller = "History", action = "List" });
        }

        public ActionResult List(int? page, bool? editable) {
            List<Sales_History> items = null; 
            int pageNumber = (page ?? 1);
            int pageSize = 50;

            using (var db = new dbContext()) {
                items = db.Sales_Histories.OrderByDescending(u => u.Id).ToList();
            }
            ViewBag.IsEditable = (editable ?? false);

            return View(items.ToPagedList(pageNumber, pageSize));
        }

        public class HistoryEdit
        {
            public string Id { get; set; }
            public string Field { get; set; }
            public string Value { get; set; }
        }

        [HttpPost]
        public JsonResult Edit(HistoryEdit data)
        {
            int id;
            var ok = int.TryParse(data.Id, out id);
            if (!ok || id == 0)
            {
                return Json("Bad ID");
            }
            using (var db = new dbContext()) {
                var item = db.Sales_Histories.First(x => x.Id == id);
                if (item == null) return Json("Not found");
                try
                {
                    Type type = item.GetType();

                    PropertyInfo prop = type.GetProperty(data.Field);


                    var targetType = (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition().Equals(typeof(Nullable<>))) ? Nullable.GetUnderlyingType(prop.PropertyType) : prop.PropertyType;

                    object newValue;
                    newValue = Convert.ChangeType(data.Value, targetType);

                    prop.SetValue(item, newValue, null);
                }
                catch (Exception e)
                {
                    return Json("Unexpected error on updating value "+e.Message);
                }
                db.SaveChanges();
            }
            return Json("ok");

        }
    }
}