using Example.API.Data;
using Example.API.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Example.API.Repository
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly ApplicationDbContext _context;

        public ToDoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public  async Task Add(Todo model)
        {
            await _context.Tasks.AddAsync(model);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var todotask=await _context.Tasks.FirstOrDefaultAsync(x => x.Id == id);
            _context.Tasks.Remove(todotask);
            await _context.SaveChangesAsync();
        }

        public async Task<Todo> Get(int id)
        {
            var toDoTask = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == id);
            return toDoTask;
        }

        public async Task<List<Todo>> GetAll()
        {
            var toDoTask=await _context.Tasks.ToListAsync();
            return toDoTask;
        }

        public async Task Update(Todo model)
        {
            var toDoTask = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == model.Id);

            toDoTask.Name = model.Name;
            toDoTask.Description = model.Description;
            toDoTask.EndDate = model.EndDate;
            toDoTask.StartDate=model.StartDate;

            await _context.SaveChangesAsync();
        }
    }
}
