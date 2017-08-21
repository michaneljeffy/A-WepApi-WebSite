namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.redbox_tags")]
    public partial class redbox_tags
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string machine_code { get; set; }

        public sbyte tag { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        public int created_at { get; set; }
    }
}
