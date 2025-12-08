using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        // повертає рядок - фреймворк автоматично створить ContentResult
        public string Square(int a, int h)
        {
            double s = a * h / 2.0;
            return $"<h2>Площа трикутника з основою {a} та висотою {h} дорівнює {s:F2}</h2>";
        }

        // повертає HTML
        public IActionResult GetHtml()
        {
            return Content("<h2>Привіт, світ!</h2>", "text/html", Encoding.UTF8);
        }

        public FileResult GetFile()
        {
            string filePath = "~/img/amst.jpg";
            string fileType = "image/jpeg";
            string fileName = "amst.jpg";
            return File(filePath, fileType, fileName);
        }

        /// <summary>
        /// існують альтернативні способи передачі даних у представлення (View):<br/>
        /// 1. ViewBag        — динамічний об'єкт (C# 4+ dynamic), зручний для швидких одноразових значень<br/>
        /// 2. ViewData       — словник string:object, типобезпечність відсутня<br/>
        /// 3. TempData       — дані, що зберігаються між двома запитами (для перенаправлень)<br/><br/>
        /// 
        /// переваги ViewBag:<br/>
        ///   - найкоротший синтаксис<br/>
        ///   - не треба кастувати при записі<br/>
        ///   - ідеально підходить для простих даних, які використовуються лише в одному представленні<br/><br/>
        /// 
        /// недоліки ViewBag / ViewData:<br/>
        ///   - немає перевірки на етапі компіляції - помилка в назві властивості виявиться тільки під час виконання<br/>
        ///   - погано працює з IntelliSense<br/>
        ///   - у великих проєктах ускладнює підтримку коду<br/><br/>
        /// 
        /// рекомендація: для складних моделей використовуйте строго типізовані View Models (@model MyViewModel)<br/>
        /// ViewBag/ViewData — лише для простих допоміжних даних (заголовки, повідомлення, прапорці тощо)<br/>
        /// </summary>
        public IActionResult SomeMethod()
        {
            // 1. ViewBag - динамічна властивість контролера
            ViewBag.Name = "MS SQL Server";                    // у View: @ViewBag.Name
            ViewBag.PageTitle = "Навчання ASP.NET Core";
            ViewBag.CurrentYear = DateTime.Now.Year;
            ViewBag.IsAdmin = User?.Identity?.IsAuthenticated ?? false;

            // 2. ViewData — словник, доступ через string-ключі
            ViewData["Head"] = "Entity Framework Core";
            ViewData["Message"] = "Дані передано через ViewData";
            ViewData["Count"] = 42;

            // 3. TempData - зберігається до першого читання після перенаправлення
            TempData["Info"] = "Це повідомлення видно тільки один раз";

            // повертаємо конкретне представлення
            return View("~/Views/Home/Index.cshtml");
        }

        // приклад отримання значень у C#-коді всередині контролера чи сервісу
        private void ExampleHowToReadValues()
        {
            // отримання з ViewBag (потрібно приведення типу!)
            string name = ViewBag.Name as string ?? "невідомо";

            // отримання з ViewData (також з приведенням)
            string head = ViewData["Head"]?.ToString() ?? string.Empty;
            int count = ViewData["Count"] is int i ? i : 0;

            // отримання з TempData (залишиться до першого читання)
            string info = TempData["Info"]?.ToString() ?? string.Empty;
            TempData.Keep("Info"); // якщо треба зберегти ще на один запит

            /*
                як отримати значення у представленні (.cshtml):

                HTML<h1>@ViewBag.PageTitle</h1>
                <p>База даних: <strong>@ViewBag.Name</strong></p>
                <p>Поточний рік: @ViewBag.CurrentYear</p>

                <h2>@ViewData["Head"]</h2>
                <p>@ViewData["Message"]</p>
                <p>Кількість: @ViewData["Count"]</p>

                <!-- TempData -->
                @if (TempData["Info"] != null)
                {
                    <div class="alert alert-info">@TempData["Info"]</div>
                }
            */
        }

        public IActionResult Index()
        {
            ViewBag.Name = "ASP.NET Core MVC";
            ViewData["Head"] = "ASP.NET Core Razor Pages";
            return View();
        }

        public IActionResult RedirectMethod()
        {
            return Redirect("/Home/Index");
        }
    }
}