using System.Collections.Generic;
using System.Threading.Tasks;
using Database.tables;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Database.repositories; 


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
        public async Task<List<Idea>> GetAll()
        {
            return await _ideaRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<Idea> GetById(int id)
        {
            return await _ideaRepository.GetById(id);
        }

        [HttpPost]
        public async Task<Idea> Create(Idea idea)
        {
            return await _ideaRepository.Create(idea);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _ideaRepository.Delete(id);
        }

        [HttpPut("{id}")]
        public async Task Update(int id, Idea idea)
        {
            await _ideaRepository.Update(idea);
        }


    }
}