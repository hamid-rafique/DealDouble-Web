using DealDouble.Data;
using DealDouble.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDouble.Services
{
    public class AuctionsService
    {
        public void SaveAuction(Auction auction)
        {
            DealDoubleContext context = new DealDoubleContext();
            context.Auctions.Add(auction);
            context.SaveChanges();
        }

        public Auction GetAuctionByID(int ID)
        {
            DealDoubleContext context = new DealDoubleContext();
            return context.Auctions.Find(ID);
        }
        public void UpdateAuction(Auction auction)
        {
            DealDoubleContext context = new DealDoubleContext();
            context.Entry(auction).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }
        public List<Auction> GetAllAuctions()
        {
            DealDoubleContext context = new DealDoubleContext();
            return context.Auctions.ToList();
        }
        public void DeleteAuction(Auction auction)
        {
            DealDoubleContext context = new DealDoubleContext();
            context.Entry(auction).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }
    }
}
