namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.channel_business_info")]
    public partial class channel_business_info
    {
        public int id { get; set; }

        [StringLength(255)]
        public string company_name { get; set; }

        [StringLength(255)]
        public string company_address { get; set; }

        [StringLength(255)]
        public string legal_person { get; set; }

        [StringLength(255)]
        public string deposit_bank { get; set; }

        [StringLength(255)]
        public string bank_account { get; set; }

        [StringLength(255)]
        public string phone_number { get; set; }

        [StringLength(255)]
        public string business_license_url { get; set; }

        public int? channel_id { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        public int? info_type { get; set; }
    }
}
