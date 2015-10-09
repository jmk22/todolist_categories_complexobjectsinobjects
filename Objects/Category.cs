using System;
using System.Collections.Generic;

namespace ToDoList
{
  public class Category
  {
    private static List<Category> instances = new List<Category> {};
    private string _name;
    private int _id;
    private List<Task> _tasks;

    public Category(string name)
    {
      _name = name;
      instances.Add(this);
      _id = instances.Count;
      _tasks = new List<Task>{};
    }

    public string GetName()
    {
      return _name;
    }

    public int GetId()
    {
      return _id;
    }

    public List<Task> GetTasks()
    {
      return _tasks;
    }

    public void AddTask(Task task)
    {
      _tasks.Add(task);
    }

    public static List<Category> All()
    {
      return instances;
    }

    public static void Clear()
    {
      instances.Clear();
    }

    public static Category Find(int id)
    {
      return instances[id-1];
    }
  }
}
