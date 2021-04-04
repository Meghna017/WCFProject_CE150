using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Newtonsoft;
using WebAppMVC.Models;
using Newtonsoft.Json;
using System.Text;

namespace WebAppMVC.Controllers
{
    public class BookController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44314/api");
        HttpClient client;
        private object item;

        public BookController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }
      
        public ActionResult Index()
        {
            List<BookViewModel> modelList = new List<BookViewModel>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/book").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                modelList = JsonConvert.DeserializeObject<List<BookViewModel>>(data);
            }
            return View(modelList);
        }

        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(BookViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/Json");

            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/book", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }

        public ActionResult Book()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Book(BookViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/Json");

            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/book", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }


        public ActionResult Edit(int BookId)
        {
            BookViewModel model = new BookViewModel();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/book/+BookId").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<BookViewModel>(data);
            }
            return View("Create", model);

        }
        [HttpPost]
        public ActionResult Edit(BookViewModel model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PutAsync(client.BaseAddress + "/book/" + model.GetBookId(), content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Create", model);

        }

        public ActionResult Delete(int BookId)
        {
            HttpResponseMessage response = client.DeleteAsync(client.BaseAddress + "/book/+BookId").Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");


        }
    }
}