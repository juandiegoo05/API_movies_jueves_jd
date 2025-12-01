using System.ComponentModel.DataAnnotations;

namespace API_movies_jueves_jd.DAL.Models
{
    public class Category : AuditBase
    {
        [Required]
        public string Name { get; set; }

    }
}
