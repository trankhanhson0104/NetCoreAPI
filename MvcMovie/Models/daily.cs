using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models;

public class Daily : HeThongPhanPhoi
{
    public string? Madaily { get; set;}
    public string? Tendaily { get; set;}
    public string? Diachi { get; set;}
    public string? Nguoidaidien { get; set;}
    public string? Dienthoai { get; set;}
    public string? MaHTTP { get; set;}
}