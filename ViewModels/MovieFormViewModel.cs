using CRUD_Operations.Models;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Operations.ViewModels
{
    public class MovieFormViewModel

    {
        public int Id { get; set; } 
        [Required, StringLength(250)]

        public string Title { get; set; }

        public int Year { get; set; }
        [Range(1,10)]
        public double Rate { get; set; }
        [Required, StringLength(2500)]
        public string StoreLine { get; set; }
        public byte[] poster { get; set; }
        [Display(Name ="Genre")]
        public byte GenreId { get; set; }

        public IEnumerable<Genre> Genres { get; set; }   

    }
}
