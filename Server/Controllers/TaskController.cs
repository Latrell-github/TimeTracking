using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TimeTracking.Server.Interface;
using TimeTracking.Shared.Models;

namespace TimeTracking.Server.Controllers
{
    [Route("api/task")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService) 
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<List<TaskState>> GetAllTasks()
        {
            await Task.Delay(1000);
            return await _taskService.GetAllTasks();
        }

        [HttpPost]
        public async Task<IActionResult> AddTask(TaskState task)
        {
            await _taskService.AddTask(task);
            return Ok(task);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTaskById(int id)
        {
            var task = await _taskService.GetTaskById(id);
            return Ok(task);
        }
    }
}
