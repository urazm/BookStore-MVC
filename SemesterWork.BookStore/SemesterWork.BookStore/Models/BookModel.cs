using System.ComponentModel.DataAnnotations;

namespace SemesterWork.BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage ="Введите описание книги")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Введите автора книги")]
        public string Author { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        [Required(ErrorMessage = "Введите кол-во страниц книги")]
        [Display(Name = "Total pages of book")]
        public int? TotalPages { get; set; }
    }
}
