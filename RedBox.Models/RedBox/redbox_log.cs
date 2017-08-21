namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.redbox_log")]
    public partial class redbox_log
    {
        public int id { get; set; }

        [StringLength(255)]
        public string redbox_log_type { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string redbox_log_data { get; set; }

        public int? redbox_id { get; set; }

        [StringLength(255)]
        public string code { get; set; }

        [StringLength(255)]
        public string param1 { get; set; }

        [StringLength(255)]
        public string param2 { get; set; }

        [StringLength(255)]
        public string param3 { get; set; }

        public int? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
