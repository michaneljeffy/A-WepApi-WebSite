namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.redbox_monitor_net")]
    public partial class redbox_monitor_net
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(20)]
        public string code { get; set; }

        public int redbox_id { get; set; }

        [Required]
        [StringLength(16777215)]
        public string content { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updated_at { get; set; }
    }
}
