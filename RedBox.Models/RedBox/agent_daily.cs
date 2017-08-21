namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.agent_daily")]
    public partial class agent_daily
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string agent_source { get; set; }

        public DateTime daily_date { get; set; }

        [Column(TypeName = "uint")]
        public long? online_count { get; set; }

        [Column(TypeName = "uint")]
        public long? online_time { get; set; }

        [StringLength(1073741823)]
        public string info { get; set; }

        public int created_at { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }

        public DateTime? deleted_at { get; set; }
    }
}
