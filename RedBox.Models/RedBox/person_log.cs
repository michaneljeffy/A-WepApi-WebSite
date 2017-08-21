namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.person_log")]
    public partial class person_log
    {
        public int id { get; set; }

        [StringLength(255)]
        public string user_identify { get; set; }

        [StringLength(255)]
        public string username { get; set; }

        [StringLength(255)]
        public string account_code { get; set; }

        [StringLength(255)]
        public string person_identify { get; set; }

        public int? action { get; set; }

        public int? channel { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }
    }
}
