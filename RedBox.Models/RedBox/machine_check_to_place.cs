namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.machine_check_to_place")]
    public partial class machine_check_to_place
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public int redbox_id { get; set; }

        [Required]
        [StringLength(15)]
        public string code { get; set; }

        public int? state { get; set; }

        [StringLength(255)]
        public string location { get; set; }

        [StringLength(2048)]
        public string check_array { get; set; }

        public int? net_type { get; set; }

        public int? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
