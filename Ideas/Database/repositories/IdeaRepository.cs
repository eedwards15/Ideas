using System.Collections.Generic;
using System.Threading.Tasks;
using Database.tables;
using Microsoft.EntityFrameworkCore;


namespace Database.repositories
{

    public interface IIdeaRepository
    {
        Task<List<Idea>> GetAll();
        Task<Idea> GetById(int id);
        Task<Idea> Create(Idea idea);
        Task Delete(int id);
        Task Update(Idea idea);
    }



    public class IdeaRepository : IIdeaRepository
    {
        private readonly IdeaDatabaseContext _context;

        public IdeaRepository(IdeaDatabaseContext context)
        {
            _context = context;
        }


        public async Task<List<Idea>> GetAll()
        {
            return await _context.Ideas.ToListAsync();
        }

        //replace with first or default 

        public async Task<Idea> GetById(int id)
        {
            return await _context.Ideas.FirstOrDefaultAsync(x => x.Id == id);
        }

        
        public async Task<Idea> Create(Idea idea)
        {
            _context.Ideas.Add(idea);
            await _context.SaveChangesAsync();
            return idea;
        }


        //delete 
        public async Task Delete(int id)
        {
            var ideaToDelete = await _context.Ideas.FirstOrDefaultAsync(x => x.Id == id);
            //null check
            if (ideaToDelete == null)
            {
                return;
            }
            _context.Ideas.Remove(ideaToDelete);
            await _context.SaveChangesAsync();
        }


        //update
        public async Task Update(Idea idea)
        {
            _context.Ideas.Update(idea);
            await _context.SaveChangesAsync();
        }

    }
}