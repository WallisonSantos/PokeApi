using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCore.Service.Model.Base
{
    public class BaseEntity
    {
        [Key]
        [Column("PRODUCT_ID")]
        public long Id { get; set; }
    }
}