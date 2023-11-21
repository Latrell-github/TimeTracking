using Microsoft.EntityFrameworkCore;
using TimeTracking.Server.Data;
using TimeTracking.Server.Interface;
using TimeTracking.Shared.Models;

namespace TimeTracking.Server.Services
{
    public class TaskService : ITaskService
    {
        private readonly ApplicationContext _context;
        public TaskService(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<List<TaskState>> GetAllTasks()
        {
            return await _context.Tasks.ToListAsync();
        }

        public async Task<TaskState> AddTask(TaskState task)
        {
            _context.Add(task);
            await _context.SaveChangesAsync();
            return task;
        }

        public async Task<TaskState> GetTaskById(int id)
        {
            var task = await _context.Tasks.FindAsync(id);
            if (task == null)
            {
                throw new ArgumentException($"Task with Id: {id} is not existing");
            }
            return task;
        }
    }
}
