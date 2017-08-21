namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.official_online_log")]
    public partial class official_online_log
    {
        public int id { get; set; }

        public int official_id { get; set; }

        [Column(TypeName = "uint")]
        public long redbox_id { get; set; }

        public bool? is_online { get; set; }

        [Column(TypeName = "uint")]
        public long created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
