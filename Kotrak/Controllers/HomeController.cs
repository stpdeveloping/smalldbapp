using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Kotrak.Mapping;
using Kotrak.Models;
using Microsoft.AspNetCore.Mvc;
using Repositories.Extensions;
using Repositories.Interfaces;

namespace Kotrak.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromServices] IBuyerService service) => 
            View(new Dto { Buyers = service.GetBuyers() });
        
        public IActionResult NewBuyer() => View("AddNewBuyer");
        
        public IActionResult GetBuyer(int id, [FromServices] IBuyerService service)
        {
            Dto foundBuyer = Wrapper.GetMapper.Map<Dto>(service.GetBuyer(id));
            var listOfAllBuyers = service.GetBuyers();
            var fixedListOfBuyers = listOfAllBuyers
                .Except(foundBuyer.ElementAsList());
            foundBuyer.Buyers = fixedListOfBuyers.ToList();
            foundBuyer.buyerInDropdown = $"{foundBuyer.Name} {foundBuyer.Surname}";
            return View("Index", foundBuyer);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddNewBuyer(Dto dto, [FromServices] IBuyerService service)
        {
            await service.AddBuyer(dto);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangeBuyer(Dto dto, [FromServices] IBuyerService service)
        {
            await service.ChangeBuyer(dto);
            return RedirectToAction("GetBuyer", new { id = dto.Id });
        }
    }
}
