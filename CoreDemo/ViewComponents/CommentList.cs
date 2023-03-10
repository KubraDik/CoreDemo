using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents
{
    public class CommentList:ViewComponent
    {
        public IViewComponentResult Invoke()//çağrı anlamına gelir
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    UserName="Kübra"
                },
                new UserComment
                {
                    ID=2,
                    UserName="Görkem"
                },
                new UserComment
                {
                    ID=3,
                    UserName="Gizem"
                }

            };


            return View(commentvalues);
        }
    }
}
