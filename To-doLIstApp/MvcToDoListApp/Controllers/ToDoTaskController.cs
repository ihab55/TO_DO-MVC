using Microsoft.AspNetCore.Mvc;
using MvcToDoListApp.Models;

namespace MvcToDoListApp.Services
{
    public class ToDoTaskController : Controller
    {
        
        public IActionResult Index()
        {
            string? username = HttpContext.Session.GetString("Username");
            if(username!=null)
            {
                var TasksList = ToDoTaskLogic.GetAllUserTasks(username);
                return View(TasksList);
            }
            return RedirectToAction("Index","Home");
        }

        public IActionResult AddNewTask()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNewTask(ToDoTask toDoTask)
        {
            string? username = HttpContext.Session.GetString("Username");
            if (username != null)
            {
                toDoTask.Username = username;
                ToDoTaskLogic.AddNewTask(toDoTask);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Home");
        }

        [HttpPost]
        public IActionResult UpdateStatus(List<ToDoTask> tasks)
        {
            ToDoTaskLogic.UpdateTasksStatus(tasks);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAllTasks()
        {
            string? username = HttpContext.Session.GetString("Username");
            if (username != null)
            {
                ToDoTaskLogic.DeleteAllTaksForUser(username);
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTask(int taskId)
        {
            ToDoTaskLogic.DeleteTaskById(taskId);
            return RedirectToAction("Index");
        }

        public IActionResult EditTask(int taskId)
        {
            ToDoTask? task=ToDoTaskLogic.GetTaskById(taskId);
            if (task != null)
            {
                return View(task);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditTask(ToDoTask task)
        {
            ToDoTaskLogic.UpdateTaskTitleAndDescreption(task);
            return RedirectToAction("Index");
        }
    }
}
