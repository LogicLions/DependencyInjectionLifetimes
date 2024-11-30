using DependencyInjectionLifetimesUsingMVC.Models;
using DependencyInjectionLifetimesUsingMVC.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace DependencyInjectionLifetimesUsingMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransient transient1;
        private readonly ITransient transient2;

        private readonly IScoped scoped1;
        private readonly IScoped scoped2;

        private readonly ISingleton singleton1;
        private readonly ISingleton singleton2;

        public HomeController(ITransient transient1, 
            ITransient transient2, 
            IScoped scoped1, 
            IScoped scoped2, 
            ISingleton singleton1,
            ISingleton singleton2)
        {
            this.transient1 = transient1;
            this.transient2 = transient2;
            this.scoped1 = scoped1;
            this.scoped2 = scoped2;
            this.singleton1 = singleton1;
            this.singleton2 = singleton2;
        }

        public IActionResult Index()
        {
            StringBuilder messages = new StringBuilder();

            messages.Append($"Transient 1 : {transient1.GetGuid()}\n");
            messages.Append($"Transient 2 : {transient2.GetGuid()}\n\n\n");

            messages.Append($"Scoped 1 : {scoped1.GetGuid()}\n");
            messages.Append($"Scoped 2 : {scoped2.GetGuid()}\n\n\n");

            messages.Append($"Singleton 1 : {singleton1.GetGuid()}\n");
            messages.Append($"Singleton 2 : {singleton2.GetGuid()}\n\n\n");


            // refresh the Index page to check the difference
            // for every refresh ...
            // Transient : 2 objects will generate new guids everytime seperately. means 1st object is not shared with 2nd request. it creates new object.
            // Scoped : 2 objects will generate same guids. guid changes only when page refreshed. but same for both objects. means 1st object is shared for 2nd request.
            // Singleton : 2 objects will generate same guids. same guids even if page refreshed. means one single object is shared for entire application lifetime.

            return Ok(messages.ToString());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
