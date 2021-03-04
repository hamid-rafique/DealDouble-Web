using DealDouble.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDouble.Data
{
    class DealDoubleContext : DbContext
    {
        public DealDoubleContext() : base("name= DealDoubleConnectionString")
        {
        }
        public DbSet <Auction> Auctions { get; set; }
    }
}
