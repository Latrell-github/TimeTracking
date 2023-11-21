using TimeTracking.Shared.Models;

namespace TimeTracking.Server.Interface
{
    public interface ITaskService
    {
        Task<List<TaskState>> GetAllTasks();
        Task<TaskState> AddTask(TaskState task);
        Task<TaskState> GetTaskById(int id);
    }
}
