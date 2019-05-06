using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Sample01.Models;

namespace Sample01.Controllers
{
    public class ContentController : Controller
    {
        public readonly Content content;
        public ContentController(IOptions<Content> options)
        {
            content = options.Value;
        }
        public IActionResult Index()
        {
            //var Contents = new List<Content>();

            //for (int i = 0; i < 11; i++)
            //{
            //    Contents.Add(new Content { Id = i, SampleContent = i + "content", Status = 1, Title = i + "title", CreateDateTime = DateTime.UtcNow, UpdateDateTime = DateTime.Now.AddDays(-1) });
            //}
            return View(new ContentViewModel { contents = new List<Content> { content } });
        }
    }
}