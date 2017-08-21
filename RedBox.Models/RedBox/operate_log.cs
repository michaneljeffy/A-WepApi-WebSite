namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.operate_log")]
    public partial class operate_log
    {
        public int id { get; set; }

        [StringLength(50)]
        public string client_ip { get; set; }

        [StringLength(255)]
        public string identify { get; set; }

        [StringLength(255)]
        public string code { get; set; }

        [StringLength(255)]
        public string data { get; set; }

        public int? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }
    }
}
