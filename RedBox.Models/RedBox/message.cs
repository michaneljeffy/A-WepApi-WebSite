namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.message")]
    public partial class message
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string mobile { get; set; }

        [Required]
        [StringLength(30)]
        public string machine_code { get; set; }

        [Required]
        [StringLength(255)]
        public string content { get; set; }

        public int status { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime updated_at { get; set; }
    }
}
