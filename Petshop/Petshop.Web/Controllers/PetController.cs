using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Petshop.Domain.Entity;
using PetShop.Service.Interface;

namespace Petshop.Web.Controllers
{
    public class PetController : Controller
    {
        private readonly IPetServices _petService;
        private readonly ILogger<PetController> _logger;

        public PetController(IPetServices petService,
                             ILogger<PetController> logger)
        {
            _petService = petService;
            _logger = logger;
        }

        // GET: Pet
        public ActionResult Index()
        {
            _logger.LogError("opa");
            var model = _petService.GetAll();
            return View(model);
        }

        // GET: Pet/Details/5
        public ActionResult Details(Guid key)
        {
            var model = _petService.Get(key);
            return View(model);
        }

        // GET: Pet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pet/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Pet model)
        {
            try
            {
                _petService.Insert(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pet/Edit/5
        public ActionResult Edit(Guid key)
        {
            var model = _petService.Get(key);
            return View(model);
        }

        // POST: Pet/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Pet model)
        {
            try
            {
                _petService.Update(model);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Pet/Delete/5
        public ActionResult Delete(Guid key)
        {
            var model = _petService.Get(key);
            return View(model);
        }

        // POST: Pet/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Pet model)
        {
            try
            {
                _petService.Delete(model.Key);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}