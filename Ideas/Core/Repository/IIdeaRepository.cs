
using Core.Database; 

namespace Core.Repository
{
    public interface IIdeaRepository
    {
        Task<List<Idea>> GetAll();
        Task<Idea> GetById(int id);
        Task<Idea> Create(Idea idea);
        Task Delete(int id);
        Task Update(Idea idea);
    }
}