using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Employe : Person
{
    public string? employeID { get; set;}
    public int Age { get; set; }
}