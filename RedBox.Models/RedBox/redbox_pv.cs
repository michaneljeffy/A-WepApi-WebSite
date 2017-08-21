namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.redbox_pv")]
    public partial class redbox_pv
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(30)]
        public string m_code { get; set; }

        public int m_pv { get; set; }

        public int m_uv { get; set; }

        [Column(TypeName = "date")]
        public DateTime create_at { get; set; }
    }
}
