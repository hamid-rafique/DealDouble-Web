using DealDouble.Entities;
using DealDouble.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDouble.Web.Controllers
{
    public class AuctionsController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            AuctionsService auctionsService = new AuctionsService();
            var auctions = auctionsService.GetAllAuctions();
            return View(auctions);
        }
      [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Auction auction)
        {
            AuctionsService auctionsService = new AuctionsService();
            auctionsService.SaveAuction(auction);
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int ID)
        {
            AuctionsService auctionsService = new AuctionsService();
            var auction = auctionsService.GetAuctionByID(ID);
            return View(auction);
        }
        [HttpPost]
        public ActionResult Edit(Auction auction)
        {
            AuctionsService auctionsService = new AuctionsService();
            auctionsService.UpdateAuction(auction);
            return RedirectToRoute(new { controller = "Auctions", action = "Index" });
        }
        [HttpPost]
        public ActionResult Delete(Auction auction, int option)
        {
            if (option == 1)
            {
                AuctionsService auctionsService = new AuctionsService();
                auctionsService.DeleteAuction(auction);
                return RedirectToAction("Index");
            }
            else
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Delete(int ID)
        {
            AuctionsService auctionsService = new AuctionsService();
            var auction = auctionsService.GetAuctionByID(ID);
            return View(auction);

        }
    }
}