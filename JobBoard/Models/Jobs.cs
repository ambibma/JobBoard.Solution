namespace Jobs.Models
{
  public class Opening
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public Contact Information {get; set;}

    public Opening (string title, string description, Contact inputContact){
      Title = title;
      Description = description;
      Information = inputContact;
    }
  }
    
  
  }
    // Job # {Title:"", Desc: '', {Contact# : Name: '' Email: ''}}
  //method GetAll()

  //method ConstJob()

  //m
