using Microsoft.AspNetCore.Mvc;
using Core.Database;
using Core.Repository;
using Core.Dtos;
using BusinessLogic.Mappers;

namespace Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class IdeasController
    {
        private readonly IIdeaRepository _ideaRepository;
        public IdeasController(IIdeaRepository ideaRepository)
        {
            _ideaRepository = ideaRepository;
        }
        
        [HttpGet]
        public async Task<List<IdeaViewModel>> GetAll()
        {
            var results =  await _ideaRepository.GetAll();
            var mappedResults = results.MapTo();
            return mappedResults;
        }

        [HttpGet("{id}")]
        public async Task<IdeaViewModel> GetById(int id)
        {
            var result =  await _ideaRepository.GetById(id);
            var mapResult = result.MapTo(); 
            return mapResult;
        }

        [HttpPost]
        public async Task<IdeaViewModel> Create(IdeaViewModel idea)
        {
            var mappedIdea = idea.MapToIdea();
            var result =  await _ideaRepository.Create(mappedIdea);
            return result.MapTo();
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _ideaRepository.Delete(id);
        }

        [HttpPut("{id}")]
        public async Task Update(int id, IdeaViewModel idea)
        {
            if (id != idea.Id) return;
            var mappedIdea = idea.MapToIdea();
            await _ideaRepository.Update(mappedIdea);

        }

    }
}