using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kotrak.Models
{
    public class Dto : Buyer
    {
        public List<Buyer> Buyers;
        public string buyerInDropdown { get; set; } = string.Empty;
    }
}
