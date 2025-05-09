using MvcToDoListApp.Models;
using MvcToDoListApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcToDoListApp.Services
{
    static public class ToDoTaskLogic
    {
        static public List<ToDoTask>? GetAllUserTasks(string username)
        {
            return ToDoTaskCRUD.ReadTasksByUser(username);
        }
        static public void AddNewTask(ToDoTask task)
        {
            ToDoTaskCRUD.CreateTask(task);
        }

        static public void UpdateTasksStatus(List<ToDoTask> tasks)
        {
            tasks.ForEach(task=>ToDoTaskCRUD.UpdateTaskStatus(task));
        }
        static public void DeleteAllTaksForUser(string username)
        {
            ToDoTaskCRUD.DeleteAllTasksForUser(username);
        }

        static public void DeleteTaskById(int id)
        {
            ToDoTaskCRUD.DeleteTaskById(id);
        }

        static public ToDoTask? GetTaskById(int id)
        {
            return ToDoTaskCRUD.ReadTaskById(id);
        }

        static public void UpdateTaskTitleAndDescreption(ToDoTask task)
        {
            ToDoTaskCRUD.UpdateTaskTitleAndDescreption(task);
        }
    }
}
