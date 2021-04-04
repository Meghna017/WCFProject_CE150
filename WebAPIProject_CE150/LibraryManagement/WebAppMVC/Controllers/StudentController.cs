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
    public class StudentController : Controller
    {
        Uri baseAddress = new Uri("https://localhost:44314/api");
        HttpClient client;
        private object item;

        public StudentController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;
        }

        public ActionResult Index()
        {
            List<StudentViewModels> modelList = new List<StudentViewModels>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/student").Result;
            if(response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                modelList = JsonConvert.DeserializeObject<List<StudentViewModels>>(data);
            }
            return View(modelList);
        }

        public ActionResult Create()
        {
           return View();
           
        }
        [HttpPost]
        public ActionResult Create(StudentViewModels model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/Json");

            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/student", content).Result;
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
        public ActionResult Book(StudentViewModels model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/Json");

            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/student", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();

        }


        public ActionResult Edit(int id)
        {
            StudentViewModels model = new StudentViewModels();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/student/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                model = JsonConvert.DeserializeObject<StudentViewModels>(data);
            }
            return View(model);

        }
        [HttpPost]
        public ActionResult Edit(StudentViewModels model)
        {
            string data = JsonConvert.SerializeObject(model);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

            HttpResponseMessage response = client.PutAsync(client.BaseAddress + "/student/" + model.StudentId, content).Result;
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View("Create", model);

        }

        public ActionResult Delete(int id)
            {
             HttpResponseMessage response = client.DeleteAsync(client.BaseAddress + "/student/"+id).Result;
             if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");


        }
    }
}