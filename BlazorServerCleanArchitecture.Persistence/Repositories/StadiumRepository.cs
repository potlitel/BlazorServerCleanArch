using BlazorServerCleanArchitecture.Application.Interfaces.Repositories;
using BlazorServerCleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerCleanArchitecture.Persistence.Repositories
{
    public class StadiumRepository : IStadiumRepository
    {
        private readonly IGenericRepository<Stadium> _repository;

        public StadiumRepository(IGenericRepository<Stadium> repository)
        {
            _repository = repository;
        }

        public async Task<List<Stadium>> GetStadiumByCityAsync(string cityName)
        {
            return await _repository.Entities.Where(x => x.City == cityName).ToListAsync();
        }
    }
}