namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.redbox_machine_meta")]
    public partial class redbox_machine_meta
    {
        public int id { get; set; }

        [StringLength(255)]
        public string machine_code { get; set; }

        [StringLength(255)]
        public string onlinable_type { get; set; }

        public int? current_count { get; set; }

        public int? accumulative_count { get; set; }

        [StringLength(16777215)]
        public string current_onlined { get; set; }

        [StringLength(1024)]
        public string locked_orders { get; set; }

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
