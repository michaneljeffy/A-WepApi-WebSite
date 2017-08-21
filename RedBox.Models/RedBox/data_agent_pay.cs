namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.data_agent_pay")]
    public partial class data_agent_pay
    {
        public int id { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? pay_date { get; set; }

        public int pay_type { get; set; }

        public int user_count { get; set; }

        public int pay_count { get; set; }

        public int printer_count { get; set; }

        [Column(TypeName = "char")]
        [StringLength(20)]
        public string location { get; set; }

        [StringLength(255)]
        public string market { get; set; }

        [Required]
        [StringLength(20)]
        public string agent_source { get; set; }

        [Required]
        [StringLength(50)]
        public string machine_code { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "uint")]
        public long cid { get; set; }

        [Column(TypeName = "uint")]
        public long secondary_cid { get; set; }

        [Column(TypeName = "uint")]
        public long tertiary_cid { get; set; }

        public int? owner_cid { get; set; }
    }
}
