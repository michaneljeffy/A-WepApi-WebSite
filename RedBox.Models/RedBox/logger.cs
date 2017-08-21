namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.logger")]
    public partial class logger
    {
        public int id { get; set; }

        public int? logable_id { get; set; }

        [StringLength(255)]
        public string logable_type { get; set; }

        [StringLength(255)]
        public string event_key { get; set; }

        [StringLength(16777215)]
        public string log_data { get; set; }

        [StringLength(255)]
        public string log_message { get; set; }

        [StringLength(16777215)]
        public string extra_data { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }
    }
}
