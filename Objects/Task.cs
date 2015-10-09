using System;
using System.Collections.Generic;

namespace ToDoList
{
  public class Task{
    private string _description;
    private bool _completed;
    private int _id;

    private static List<Task> instances = new List<Task> {};

    public Task(string taskDescription)
    {
      _description = taskDescription;
      _completed = false;
      instances.Add(this);
      _id = instances.Count;
    }


    public string GetDescription()
    {
      return _description;
    }
    public bool IsCompleted(){
      return _completed;
    }
    public int GetId(){
      return _id;
    }

    public static List<Task> All() {
      return instances;
    }
    public static Task Find(int id){
      return instances[id-1];
    }
    public static void DeleteAll()
    {
      instances.Clear();
    }
  }
}
