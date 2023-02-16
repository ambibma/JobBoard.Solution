using System.Collections.Generic;
using System;

namespace Jobs.Models
{
  public class Opening
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public string Wage {get;set;}
    public Contact Information {get; set;}
    private static List<Opening> _instances = new List<Opening>{};

    public Opening (string title, string description, string salary, Contact inputContact){
      Title = title;
      Description = description;
      Information = inputContact;
      Wage = salary;
      _instances.Add(this);
    }

    public static List<Opening> GetAll(){
      return _instances;
    }

    public static void ClearAll(){
      _instances.Clear();

    }
  }
    
  
  }
    // Job # {Title:"", Desc: '', {Contact# : Name: '' Email: ''}}
  //method GetAll()

  //method ConstJob()

  //m
