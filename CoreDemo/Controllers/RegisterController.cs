using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Writer p)
        {
            WriterValidator wv = new WriterValidator();//WriterValidator sınıfından bir nesne türettik.
            ValidationResult results = wv.Validate(p);//writervalidator içerisindeki değerleri validate ederiz,yani kontrol.(p=parametreden gelen değerler)
            //eğer sonuçlar geçerliyse
            if (results.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = "deneme";
                wm.WriterAdd(p);
                return RedirectToAction("Index", "Blog");//blog sayfasının içerisindeki index sayfasına git demektir.
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);

                }
            }
            return View();

            
        }
    }
}
