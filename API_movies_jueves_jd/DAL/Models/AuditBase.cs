using System.ComponentModel.DataAnnotations;

namespace API_movies_jueves_jd.DAL.Models
{
    public class AuditBase
    {
        [Key]
        public virtual int Id { get; set; }

        public virtual DateTime CreateDate { get; set; }

        public virtual DateTime? ModifiedDate { get; set; }

    }
}
