namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.user_notification")]
    public partial class user_notification
    {
        public int id { get; set; }

        public int? user_id { get; set; }

        public int? state { get; set; }

        public int? notify_type { get; set; }

        public int? out_id { get; set; }

        [StringLength(255)]
        public string title { get; set; }

        [StringLength(255)]
        public string sub_title { get; set; }

        [StringLength(1024)]
        public string message { get; set; }

        public int? created_at { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime? updated_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime? deleted_at { get; set; }
    }
}
