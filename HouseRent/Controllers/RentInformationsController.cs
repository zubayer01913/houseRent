using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HouseRent.Models;

namespace HouseRent.Controllers
{
    [Authorize]
    public class RentInformationsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        
        public ActionResult Index(DateTime? DateOfMonth)
        {
            RentInformatioViewModel rentViewModel = new RentInformatioViewModel();

            

            if(DateOfMonth != null)
            {
                ViewBag.TotalMonthOfAmmount = db.RenstInformations.Where(x => x.Date.Value.Month == DateOfMonth.Value.Month).Sum(x => x.Amount);
                rentViewModel.RentInformations = db.RenstInformations.Where(x => x.Date.Value.Month == DateOfMonth.Value.Month).ToList();

                return View(rentViewModel);
            }

            ViewBag.TotalMonthOfAmmount = db.RenstInformations.Where(x => x.Date.Value.Month == DateTime.Now.Month).Sum(x => x.Amount);
            rentViewModel.RentInformations = db.RenstInformations.Where(x => x.Date.Value.Month == DateTime.Now.Month).ToList();

            return View(rentViewModel);
        }


        public ActionResult DetailsOfMonth()
        {

            var model = db.RenstInformations.ToList();
            return View("Details", model);
        }

      
        public ActionResult DetailsOfMonthList(DateTime? DateOfMonth)
        {
            RentInformatioViewModel rentViewModel = new RentInformatioViewModel();

          

            if (DateOfMonth != null)
            {
                //ViewBag.DetailsOfMonth = db.RenstInformations.Where(x => x.Date.Value.Month == DateOfMonth.Value.Month).GroupBy(x => x.Date).ToList();
                ViewBag.TotalMonthOfAmmount = db.RenstInformations.Where(x => x.Date.Value.Month == DateOfMonth.Value.Month).Sum(x => x.Amount);
                ViewBag.DetailsOfMonth = db.RenstInformations.Where(x => x.Date.Value.Month == DateOfMonth.Value.Month).ToList();
                return View("Details");
            }

            ViewBag.TotalMonthOfAmmount = db.RenstInformations.Where(x => x.Date.Value.Month == DateTime.Now.Month).Sum(x => x.Amount);
            ViewBag.DetailsOfMonth = db.RenstInformations.Where(x => x.Date.Value.Month == DateTime.Now.Month).ToList();
            return View("Details");
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RentInformation rentInformation)
        {
            if (ModelState.IsValid)
            {
                db.RenstInformations.Add(rentInformation);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rentInformation);
        }

   
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RentInformation rentInformation = db.RenstInformations.Find(id);
            if (rentInformation == null)
            {
                return HttpNotFound();
            }
            return View(rentInformation);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RentInformation rentInformation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rentInformation).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rentInformation);
        }


        public ActionResult Delete(int? id)
        {
            RentInformation rentInformation = db.RenstInformations.Find(id);
            db.RenstInformations.Remove(rentInformation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    

        protected override void Dispose(bool disposing)
         {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
