using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CummingsApplication.Models;
using CummingsApplication.Data;
using CummingsApplication.Models.Viewmodels;

namespace CummingsApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Form
        [HttpGet]
        public IActionResult Index()
        {
            var model = new FormViewModel();
            model.ProvidingAgency.Date = DateTime.Now;

            return View(model);
        }

        //POST: Form/Submit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(FormViewModel model)
        {

            if (ModelState.IsValid)
            {
                // Establish and save our BailBondInfo to generate an Id.
                _context.BailBondInfos.Add(model.BailBondInfo);
                await _context.SaveChangesAsync();

                // Give our other tables their BailBondId.
                model.Defendant.BailBondId = model.BailBondInfo.Id;
                model.Indemnitor.BailBondId = model.BailBondInfo.Id;
                model.Jail.BailBondId = model.BailBondInfo.Id;
                model.ProvidingAgency.BailBondId = model.BailBondInfo.Id;
                model.RequestingAgency.BailBondId = model.BailBondInfo.Id;
                model.BondTransfer.BailBondId = model.BailBondInfo.Id;
                model.AdditionalInfo.BailBondId = model.BailBondInfo.Id;


                // Add our data to the database, save it, and add the Id to to our BailBondInfo.
                _context.Defendants.Add(model.Defendant);
                await _context.SaveChangesAsync();
                model.BailBondInfo.DefendantId = model.Defendant.Id;

                _context.Indemnitors.Add(model.Indemnitor);
                await _context.SaveChangesAsync();
                model.BailBondInfo.IndemnitorId = model.Indemnitor.Id;


                _context.BondTransfers.Add(model.BondTransfer);
                await _context.SaveChangesAsync();
                model.BailBondInfo.BondTransferId = model.BondTransfer.Id;

                _context.AdditionalInfos.Add(model.AdditionalInfo);
                await _context.SaveChangesAsync();
                model.BailBondInfo.AdditionalInfoId = model.AdditionalInfo.Id;

                _context.RequestingAgencies.Add(model.RequestingAgency);
                await _context.SaveChangesAsync();
                model.BailBondInfo.RequestingAgencyId = model.RequestingAgency.Id;

                _context.ProvidingAgencies.Add(model.ProvidingAgency);
                await _context.SaveChangesAsync();
                model.BailBondInfo.ProvidingAgencyId = model.ProvidingAgency.Id;

                _context.Jails.Add(model.Jail);
                await _context.SaveChangesAsync();
                model.BailBondInfo.JailId = model.Jail.Id;

                await _context.SaveChangesAsync();

                return View();
            }
            else
            {
                Console.WriteLine("Error submitting form.");
                return View();
            }
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
