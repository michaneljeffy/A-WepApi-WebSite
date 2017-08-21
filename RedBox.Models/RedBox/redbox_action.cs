namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.redbox_action")]
    public partial class redbox_action
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        public int redbox_id { get; set; }

        [Required]
        [StringLength(20)]
        public string action { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string param { get; set; }

        public sbyte status { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? finished_at { get; set; }
    }
}
