using PetLife.Infrastructure.Data;
using PetLife.Models;

namespace PetLife.Contracts
{
    public interface IPetService
    {
        Task<bool> AddPet(AddAnimalViewModels addPetViewModel);
    }
}
