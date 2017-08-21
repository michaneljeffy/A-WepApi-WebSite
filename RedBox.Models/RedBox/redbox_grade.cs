namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.redbox_grade")]
    public partial class redbox_grade
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "date")]
        public DateTime riqi { get; set; }

        public int redbox_id { get; set; }

        [Required]
        [StringLength(20)]
        public string machine_code { get; set; }

        public bool m_pv { get; set; }

        public bool m_online { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
