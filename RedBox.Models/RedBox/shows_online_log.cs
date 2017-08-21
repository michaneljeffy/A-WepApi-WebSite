namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.shows_online_log")]
    public partial class shows_online_log
    {
        public int id { get; set; }

        public int shows_id { get; set; }

        public int redbox_id { get; set; }

        public int created_at { get; set; }

        [StringLength(255)]
        public string shows_type { get; set; }

        public bool? is_online { get; set; }
    }
}
