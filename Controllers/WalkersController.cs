using DogGo.Repositories;
using DogGoMVC2.Models;
using DogGoMVC2.Models.ViewModels;
using DogGoMVC2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;


using static DogGoMVC2.Models.ViewModels.WalkersProfileViewModel;

namespace DogGoMVC2.Controllers
{
    public class WalkersController : Controller
    {
        private readonly IWalkerRepository _walkerRepo;
        private readonly IWalkRepository _walkRepo;
        private readonly IOwnerRepository _ownerRepo;

        // ASP.NET will give us an instance of our Walker Repository. This is called "Dependency Injection"
        public WalkersController(IWalkerRepository walkerRepository, IWalkRepository walkRepository, IOwnerRepository ownerRepository)
        { 
            _walkerRepo = walkerRepository;
            _walkRepo = walkRepository;
            _ownerRepo = ownerRepository;


        }

        // GET: HomeController1
        public ActionResult Index()
        {
            //getOwnersById  

            int currentUser = GetCurrentUserId();
            Owner owner = _ownerRepo.GetOwnerById(currentUser);
            List<Walker> walkers = _walkerRepo.GetAllWalkers();

            //Filtering all walkers to only with the same neighborId as the owner.neightborid
            List<Walker> neighborhoodWalker = walkers.Where(w => w.NeighborhoodId == owner.NeighborhoodId).ToList();

            return View(neighborhoodWalker);
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {

            WalkersProfileViewModel vm = new WalkersProfileViewModel()
            {
                Walker = _walkerRepo.GetWalkerById(id),
                Walks = _walkRepo.GetWalksByWalkerId(id)
            };

            return View(vm);
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        private int GetCurrentUserId()
        {
            string id = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return int.Parse(id);
        }

    }
}
