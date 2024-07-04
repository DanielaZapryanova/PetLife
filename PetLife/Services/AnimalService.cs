using Microsoft.EntityFrameworkCore;
using PetLife.Contracts;
using PetLife.Infrastructure.Data;
using PetLife.Infrastructure.Data.Models;
using PetLife.Models;

namespace PetLife.Services
{
    public class AnimalService:IPetService
    {
        private PetLifeDbContext dbContext;
        public AnimalService (PetLifeDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<bool> AddPet(AddAnimalViewModels addPetViewModel)
        {
            Animal pet = new Animal();
            pet.Alergies = addPetViewModel.Alergies;
            pet.Name = addPetViewModel.Name;
            pet.DateOfBirth = addPetViewModel.DateOfBirth;
            pet.Castration = addPetViewModel.Castration;
            pet.DoctorId=addPetViewModel.DoctorId;
            pet.Image = addPetViewModel.Image;
            pet.TypeId = addPetViewModel.TypeId;
            pet.Gender = addPetViewModel.Gender;
            pet.OwnerId = addPetViewModel.OwnerId;

            try
            {
                await dbContext.AddAsync(pet);
                await dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
