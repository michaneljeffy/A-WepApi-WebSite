namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.official_account_person")]
    public partial class official_account_person
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [Required]
        [StringLength(50)]
        public string desc { get; set; }

        [Required]
        [StringLength(255)]
        public string logo { get; set; }

        [Required]
        [StringLength(255)]
        public string qrcode { get; set; }

        public int parent_id { get; set; }

        [Required]
        [StringLength(50)]
        public string code { get; set; }

        [Required]
        [StringLength(50)]
        public string machine { get; set; }

        public int fans_count { get; set; }

        public int focus_count { get; set; }

        public int created_at { get; set; }

        public sbyte is_online { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime deleted_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime updated_at { get; set; }

        public int show_time { get; set; }

        [Required]
        [StringLength(50)]
        public string person_id { get; set; }

        public int? show_location { get; set; }

        public int? city { get; set; }

        public int? today_focus_count { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        public int? day_focus_count_limit { get; set; }
    }
}
