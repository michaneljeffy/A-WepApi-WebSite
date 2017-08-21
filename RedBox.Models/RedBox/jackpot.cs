namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.jackpot")]
    public partial class jackpot
    {
        public int id { get; set; }

        [StringLength(255)]
        public string name { get; set; }

        [StringLength(2048)]
        public string description { get; set; }

        public int? trophy_count { get; set; }

        public int? hint_rate { get; set; }

        public bool? is_orient_sex { get; set; }

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
