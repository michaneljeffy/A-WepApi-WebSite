namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.xmas_prize")]
    public partial class xmas_prize
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        public short type { get; set; }

        [Required]
        [StringLength(255)]
        public string mall_id { get; set; }

        public sbyte is_valued { get; set; }

        [Column(TypeName = "uint")]
        public long count { get; set; }

        [Column("for")]
        public sbyte _for { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }
    }
}
