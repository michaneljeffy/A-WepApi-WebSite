namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.address")]
    public partial class address
    {
        public int id { get; set; }

        public int? addressable_id { get; set; }

        [StringLength(255)]
        public string addressable_type { get; set; }

        public int? province { get; set; }

        public int? city { get; set; }

        public int? county { get; set; }

        [StringLength(2048)]
        public string location { get; set; }

        public int? location_type { get; set; }

        public int? printer_channel_id { get; set; }

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
