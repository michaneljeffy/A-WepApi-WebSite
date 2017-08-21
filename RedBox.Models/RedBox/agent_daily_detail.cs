namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.agent_daily_detail")]
    public partial class agent_daily_detail
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime daily_date { get; set; }

        [Required]
        [StringLength(255)]
        public string agent_source { get; set; }

        [Required]
        [StringLength(255)]
        public string machine_code { get; set; }

        [Column(TypeName = "uint")]
        public long? online_time { get; set; }

        [StringLength(255)]
        public string address { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
