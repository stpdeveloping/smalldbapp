using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories.Extensions
{
    public static class BuyerExtension
    {
        public static List<Buyer> ElementAsList(this Buyer buyer) => 
            new List<Buyer> { buyer };
    }
}
