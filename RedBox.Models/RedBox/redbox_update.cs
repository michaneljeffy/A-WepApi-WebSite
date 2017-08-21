namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.redbox_update")]
    public partial class redbox_update
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        public int redbox_id { get; set; }

        public int update_id { get; set; }

        public sbyte status { get; set; }

        [Required]
        [StringLength(255)]
        public string message { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime updated_at { get; set; }

        [Required]
        [StringLength(20)]
        public string before_version { get; set; }

        [Required]
        [StringLength(20)]
        public string target_version { get; set; }
    }
}
