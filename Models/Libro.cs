using System.ComponentModel.DataAnnotations;

public class Libro
{
    [Key]
    public int LibroId { get; set; }

    [Required(ErrorMessage = "Error, favor intente de nuevo")]
    public string? Titulo { get; set; }
    public double? Precio { get; set; }
}