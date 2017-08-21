namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.printer_warning")]
    public partial class printer_warning
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string machine_code { get; set; }

        [Required]
        [StringLength(20)]
        public string phone { get; set; }

        [Column(TypeName = "uint")]
        public long? start_time { get; set; }

        public int? end_time { get; set; }

        [Column(TypeName = "uint")]
        public long? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
