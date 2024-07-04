using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PetLife.Contracts;
using PetLife.Models;

namespace PetLife.Controllers
{
    public class PetController : Controller
    {
        IPetService petService;
        IOwnerService ownerService;

        public PetController(IPetService petService, IOwnerService ownerService)
        {
            this.petService = petService;
            this.ownerService = ownerService;
        }

        [Authorize(Roles = "Admin,Vet")]
        public async Task<IActionResult> AddPet()
        {
            AddAnimalViewModels addPetViewModel = new AddAnimalViewModels();
            IList<OwnerViewModel> possibleOwners = new List<OwnerViewModel>();
            addPetViewModel.DateOfBirth = DateTime.Today;
            return View(addPetViewModel);
        }
        [HttpPost]
        [Authorize(Roles = "Admin,Vet")]
        public async Task<IActionResult> AddPet([FromForm(Name = "file")] IFormFile? file, AddAnimalViewModels addPetViewModel)
        {
            if (addPetViewModel.DateOfBirth.CompareTo(DateTime.Now) > 0)
            {
                ModelState.AddModelError(nameof(addPetViewModel.DateOfBirth), "Не може да добавите животно, което още не се е родило.");
            }
            if (!ModelState.IsValid)
            {
                return View(addPetViewModel);
            }

            bool addedPetSuccessfully = await petService.AddPet(addPetViewModel);

            //if (addedPetSuccessfully)
            //{
            //    return RedirectToAction(nameof(All));
            //}

            return View("Error");
        }
    }
}
