using MvcToDoListApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MvcToDoListApp.Services
{
    public static class ToDoTaskCRUD
    {
        public static void CreateTask(ToDoTask toDoTask)
        {
            using (AppDbContext db = new AppDbContext())
            {
                db.Add(toDoTask);
                db.SaveChanges();
            }
        }
        public static void DeleteTaskById(int taskId)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var task = db.ToDoTasks.Find(taskId);
                if (task != null)
                {
                    db.Remove(task);
                    db.SaveChanges();
                }
            }
        }

        public static void DeleteAllTasksForUser(string username)
        {
            using (AppDbContext db = new AppDbContext())
            {
                User? user = db.Users.Find(username);
                if (user != null)
                {
                    var tasks=db.ToDoTasks.Where(task=>task.Username == username);
                    db.ToDoTasks.RemoveRange(tasks);
                    db.SaveChanges();
                }
            }
        }

        public static void UpdateTask(ToDoTask updatedTask)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var existingTask = db.ToDoTasks.Find(updatedTask.Id);
                if (existingTask != null)
                {
                    existingTask.Title = updatedTask.Title;
                    existingTask.Description = updatedTask.Description;
                    existingTask.IsCompleted = updatedTask.IsCompleted;
                    existingTask.Username = updatedTask.Username;
                    db.SaveChanges();
                }
            }
        }

        public static void UpdateTaskTitleAndDescreption(ToDoTask updatedTask)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var existingTask = db.ToDoTasks.Find(updatedTask.Id);
                if (existingTask != null)
                {
                    existingTask.Title = updatedTask.Title;
                    existingTask.Description = updatedTask.Description;
                    db.SaveChanges();
                }
            }
        }

        public static void UpdateTaskStatus(ToDoTask updatedTask)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var existingTask = db.ToDoTasks.Find(updatedTask.Id);
                if (existingTask != null)
                {
                    existingTask.IsCompleted = updatedTask.IsCompleted;
                    db.SaveChanges();
                }
            }
        }

        public static ToDoTask? ReadTaskById(int taskId)
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.ToDoTasks.Find(taskId);
            }
        }

        public static List<ToDoTask> ReadTasksByUser(string username)
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.ToDoTasks.Where(task => task.Username == username).ToList();
            }
        }

        public static List<ToDoTask> ReadAllTasks()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.ToDoTasks.ToList();
            }
        }


    }
}
