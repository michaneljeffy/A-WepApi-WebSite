namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.redbox_liveness")]
    public partial class redbox_liveness
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "date")]
        public DateTime m_date { get; set; }

        public int liveness { get; set; }

        public int all_count { get; set; }

        public int new_redbox { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
