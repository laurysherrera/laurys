using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string productos { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime fecha { get; set; }
        public string cantidad { get; set; } = string.Empty;
        public decimal Precio{ get; set; }
    }
}