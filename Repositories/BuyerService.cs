using Repositories.Data;
using Repositories.Interfaces;
using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class BuyerService : IBuyerService
    {
        public readonly EfCoreContext _context;
        public BuyerService(EfCoreContext context) => _context = context;
        
        public async Task<Buyer> AddBuyer(Buyer buyer)
        {
            _context.Buyers.Add(buyer);
            await _context.SaveChangesAsync();
            return buyer;
        }

        public async Task<Buyer> ChangeBuyer(Buyer buyer)
        {
            _context.Buyers.Update(buyer);
            await _context.SaveChangesAsync();
            return buyer;
        }

        public List<Buyer> GetBuyers()
        {
            var list = new List<Buyer>();
            foreach (var buyer in _context.Buyers)
                list.Add(buyer);
            return list;
        }
        public Buyer GetBuyer(int id) => _context.Buyers.Find(id);
        
            
        
    }
}
