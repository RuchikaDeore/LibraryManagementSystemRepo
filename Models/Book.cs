using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Genre { get; set; }

        public DateTime? PublishedDate { get; set; }

        public int AuthorId { get; set; }

        public string Author { get; set; }
    }
}
