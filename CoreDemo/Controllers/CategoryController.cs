using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());//(içi Icategorydalı karşılar)


        public IActionResult Index()//mvcde actionresult olarak gelirdi karşımıza(add view)
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
