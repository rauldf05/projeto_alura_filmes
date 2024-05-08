using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateCinemaDto
{
    [Required(ErrorMessage = "O campo de nome é obritatório.")]
    public string Nome { get; set; }
    public int Enderecoid { get; set; }
}
