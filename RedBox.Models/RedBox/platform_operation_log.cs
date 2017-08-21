namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.platform_operation_log")]
    public partial class platform_operation_log
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [StringLength(20)]
        public string platform { get; set; }

        public int? statistic_id { get; set; }

        [StringLength(255)]
        public string account_code { get; set; }

        public int? state { get; set; }

        public int? uid { get; set; }

        [StringLength(255)]
        public string trade_code { get; set; }

        [StringLength(255)]
        public string extra { get; set; }

        [StringLength(255)]
        public string ext1 { get; set; }

        public int created_at { get; set; }
    }
}
