namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.audit")]
    public partial class audit
    {
        public int id { get; set; }

        public int auditable_id { get; set; }

        [Required]
        [StringLength(255)]
        public string auditable_type { get; set; }

        public int channel_id { get; set; }

        [Required]
        [StringLength(255)]
        public string channel_nickname { get; set; }

        [StringLength(16777215)]
        public string audit_data { get; set; }

        public int? audit_result { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Required]
        [StringLength(50)]
        public string official_account_code { get; set; }
    }
}
