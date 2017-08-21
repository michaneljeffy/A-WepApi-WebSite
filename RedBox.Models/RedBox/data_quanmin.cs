namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.data_quanmin")]
    public partial class data_quanmin
    {
        public int id { get; set; }

        [Required]
        [StringLength(255)]
        public string machine_code { get; set; }

        [StringLength(255)]
        public string img_url { get; set; }

        public int? timestamp { get; set; }

        public int? is_succ { get; set; }

        public int? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }
    }
}
