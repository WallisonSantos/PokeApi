using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AspNetCore.Service.Model.Base;

namespace AspNetCore.Service.Model
{
    [Table("PRODUCT")]
    public class Product : BaseEntity
    {
        [Column("NAME")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("PRICE")]
        [Required]
        [Range(1,10000)]
        public decimal Price { get; set; }

        [Column("DESCR")]
        [StringLength(500)]
        public string Description { get; set; }

        [Column("DESCR_CATEGORY")]
        [StringLength(50)]
        public string DescrCategory { get; set; }

        [Column("LINK_URL_IMAGE")]
        [StringLength(300)]
        public string LinkUrlImage { get; set; }
    }
}