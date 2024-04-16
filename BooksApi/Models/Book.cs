using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BooksApi.Models
{
    public class Book
    {
        internal object?[]? id;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string? Title { get; set; }
        [Required(ErrorMessage = "Author is required")]
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public string? Language { get; set; }
        public string? Publisher { get; set; }
        [Required(ErrorMessage = "Release date is required")]
        public DateTime? ReleaseDate { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Number of pages must be bigger than 0")]
        public int? NumberOfPages {  get; set; }
        [Required(ErrorMessage = "Price is required")]
        [Range(5, double.MaxValue, ErrorMessage = "Price must be bigger than or equal 5")]
        public decimal? Price { get; set; }


    }
}
