using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;


namespace Database.repositories
{

    public class IdeaRepository : Core.Repository.IIdeaRepository
    {
        private readonly IdeaDatabaseContext _context;

        public IdeaRepository(IdeaDatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Core.Database.Idea>> GetAll()
        {
            return await _context.Ideas.ToListAsync();
        }

        public async Task<Core.Database.Idea> GetById(int id)
        {
            return await _context.Ideas.FirstOrDefaultAsync(x => x.Id == id);
        }
  
        public async Task<Core.Database.Idea> Create(Core.Database.Idea idea)
        {
            _context.Ideas.Add(idea);
            await _context.SaveChangesAsync();
            return idea;
        }

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

        public async Task Update(Core.Database.Idea idea)
        {
            _context.Ideas.Update(idea);
            await _context.SaveChangesAsync();
        }

    }
}