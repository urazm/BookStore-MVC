using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using SemesterWork.BookStore.Helpers;

namespace SemesterWork.BookStore.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        /*[StringLength(100, MinimumLength = 5)]
        [Required(ErrorMessage ="Введите описание книги")]*/
       // [MyCustomValidation("azure")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Введите автора книги")]
        public string Author { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        public string Category { get; set; }
        //[Required(ErrorMessage = "Выберите язык книги")]
        public int LanguageId { get; set; }
        public string Language { get; set; }
        [Required(ErrorMessage = "Введите кол-во страниц книги")]
        public int? TotalPages { get; set; }

        [Display(Name = "Выбери изображение для книги")]
        [Required]
        public IFormFile CoverPhoto { get; set; }
        public string CoverImageUrl { get; set; }

    }
}
