namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.advertise_adv")]
    public partial class advertise_adv
    {
        public int id { get; set; }

        public int aid { get; set; }

        [Required]
        [StringLength(255)]
        public string img_url { get; set; }

        public int total_count { get; set; }

        public int left_count { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public sbyte scale { get; set; }
    }
}
