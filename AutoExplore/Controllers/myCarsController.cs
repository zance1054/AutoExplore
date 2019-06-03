using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoExplore.Data;
using AutoExplore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Google.Apis.YouTube.v3;
using Google.Apis.Services;

namespace AutoExplore.Controllers
{
    [Authorize]
    [Route("myCars")]
    public class MyCarsController : Controller
    {

        private readonly ApplicationDbContext _db;

        public MyCarsController(ApplicationDbContext db)
        {
            _db = db;
        }

        [Route("delete/{id}")]
        public IActionResult delete(long id)
        {
            Car toDelete = _db.Cars.Find(id);
            _db.Cars.Remove(toDelete);
            _db.SaveChanges();

            return View();
        }
        [Route("deleteAll/userID")]
        public void deleteAll()
        {
            var car = _db.Cars.Where(x => x.user == User.Identity.Name).OrderByDescending(x => x.posted).ToArray();
        }

        [Authorize]
        [Route("")]
        public IActionResult Index()
        {
            var car = _db.Cars.Where(x => x.user == User.Identity.Name).OrderByDescending(x => x.posted).ToArray();
            return View(car);
        }

        [Authorize]
        [HttpGet, Route("Add")]
        public IActionResult Add()
        {
            return View();
        }

        [Authorize]
        [HttpPost, Route("Add")]
        public IActionResult Add(Car car)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            car.posted = DateTime.Now;
            car.user = User.Identity.Name;
            //client to invoke the car query api
           
            WebClient client = new WebClient();

            Task<String> carQueryTask = null;// Task<string> that queries carQuery

            // url for API (no key required)
            string url = "https://www.carqueryapi.com/api/0.3/?callback=?&cmd=getTrims&make="
                + car.make + "&model=" + car.model + "&year=" + car.year;

            //request info from the api
            carQueryTask = client.DownloadStringTaskAsync(url);

            string result = carQueryTask.Result.Remove(0, 2);
            result = result.Remove(result.Length - 2, 2);

            dynamic json = JsonConvert.DeserializeObject(result);

            try
            {
                car.modelID = json.Trims[0].model_id;
                car.Body = json.Trims[0].model_body;
                car.modelTrim = json.Trims[0].model_trim;
                car.Transmission = json.Trims[0].model_transmission_type;
                car.DriveType = json.Trims[0].model_drive;
                car.seats = json.Trims[0].model_seats;
                car.doors = json.Trims[0].model_doors;
                car.weight = json.Trims[0].model_weight_kg;
                getLink(car);

                _db.Cars.Add(car);
                _db.SaveChanges();
            }
            catch
            {
            }

            return View();

        }

        [Authorize]
        [Route("details")]
        public IActionResult details(long id)
        {
            var car = _db.Cars.FirstOrDefault(x => x.Id == id);
            return View(car);
        }

        [STAThread]
        [Route("null")]
        public Car getLink(Car car)
        {
            try
            {
                string url = getVideo(car);
                car.videoURL = url;
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            return car;
        }

        [Route("null")]
        private string getVideo(Car car)
        {
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "AIzaSyAvC23GueJeotBaC0_HLptoT-yR5ZVnOkY",
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = car.make + " " + car.model + " " + car.year;
            searchListRequest.MaxResults = 1;

            // Call the search.list method to retrieve results matching the specified query term.
            var searchListResponse = searchListRequest.Execute();
            string videoURL = "https://www.youtube.com/embed/";
            return  videoURL + searchListResponse.Items[0].Id.VideoId;
        }
    }
}