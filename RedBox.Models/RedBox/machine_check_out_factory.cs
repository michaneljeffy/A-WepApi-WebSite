namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.machine_check_out_factory")]
    public partial class machine_check_out_factory
    {
        public int id { get; set; }

        public int user_id { get; set; }

        public int redbox_id { get; set; }

        [Required]
        [StringLength(15)]
        public string code { get; set; }

        public int? state { get; set; }

        [StringLength(2048)]
        public string check_array { get; set; }

        public int? aged_time { get; set; }

        public int? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
