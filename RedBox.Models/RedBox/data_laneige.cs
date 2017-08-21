namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.data_laneige")]
    public partial class data_laneige
    {
        public int id { get; set; }

        [StringLength(255)]
        public string wechat_openid { get; set; }

        [StringLength(255)]
        public string machine_code { get; set; }

        public int? total_count { get; set; }

        public int? left_count { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
