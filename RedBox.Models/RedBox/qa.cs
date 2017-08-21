namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.qa")]
    public partial class qa
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(255)]
        public string title { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string content { get; set; }

        [Required]
        [StringLength(255)]
        public string tags { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime deleted_at { get; set; }
    }
}
