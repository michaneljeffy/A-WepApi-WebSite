namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.area")]
    public partial class area
    {
        [Column(TypeName = "uint")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        [Column(TypeName = "uint")]
        public long pid { get; set; }

        [Required]
        [StringLength(120)]
        public string name { get; set; }

        public sbyte is_use { get; set; }

        public int level { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime updated_at { get; set; }
    }
}
