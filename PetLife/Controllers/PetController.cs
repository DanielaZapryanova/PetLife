using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetLife.Contracts;

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
            AddPetViewModel addPetViewModel = new AddPetViewModel();
            IList<OwnerViewModel> possibleOwners = new List<OwnerViewModel>();
            possibleOwners = await ownerService.GetAllOwners();
            addPetViewModel.PossibleOwners = possibleOwners;
            addPetViewModel.DateOfBirth = DateTime.Today;
            return View(addPetViewModel);
        }

    }
}
