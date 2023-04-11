using System.ComponentModel.DataAnnotations;

namespace Trabajo_Practico_1.Models;

public class Movie{
    public string Code { get; set; }

    [Display(Name="Nombre")]
    [Required]
    public string Name { get; set; }
    [Range(5,600)]
    public int Minutes { get; set; }
    public string Category { get; set; }
    public string Review { get; set; }
}