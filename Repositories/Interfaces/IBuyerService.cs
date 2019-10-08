using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IBuyerService
    {
        Task<Buyer> AddBuyer(Buyer buyer);
        Task<Buyer> ChangeBuyer(Buyer buyer);
        List<Buyer> GetBuyers();
        Buyer GetBuyer(int id);
    }
}
