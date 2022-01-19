using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_Mvc.Models;

namespace DevCard_Mvc.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var Article = new List<Article>
            {
                new Article(1,"رستوران","پخت انواع غذاهای ایرانی","blog-post-thumb-card-1.jpg"),
                new Article(2,"zapya","نرم افزاری برای انتقال داده ها","blog-post-thumb-card-2.jpg"),
                new Article(3,"فیلیمو","برنامه ای برای انواع فیلم ها","blog-post-thumb-card-3.jpg"),
            };
            return View("_article",Article);
        }
    }
}
