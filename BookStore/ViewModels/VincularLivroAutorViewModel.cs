using System.ComponentModel.DataAnnotations;

namespace BookStore.ViewModels
{
    public class VincularLivroAutorViewModel
    {
        [Required(ErrorMessage ="*")]
        public int AutorId { get; set; }
        [Required(ErrorMessage ="*")]
        public int LivroId { get; set; }
    }
}