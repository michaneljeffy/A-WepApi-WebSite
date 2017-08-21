namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.game_customer_service")]
    public partial class game_customer_service
    {
        public int id { get; set; }

        public int uid { get; set; }

        [Required]
        [StringLength(50)]
        public string machine_code { get; set; }

        [Required]
        [StringLength(50)]
        public string mobile { get; set; }

        [Required]
        [StringLength(50)]
        public string problem { get; set; }

        [Required]
        [StringLength(255)]
        public string problem_desc { get; set; }

        [Required]
        [StringLength(16777215)]
        public string image_voucher { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }
    }
}
