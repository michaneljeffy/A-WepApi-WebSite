namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.redbox_flowmeter")]
    public partial class redbox_flowmeter
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        [Required]
        [StringLength(20)]
        public string machine_code { get; set; }

        [Column(TypeName = "uint")]
        public long? redbox_id { get; set; }

        public long rx { get; set; }

        public long tx { get; set; }

        public long mobile_rx { get; set; }

        public long mobile_tx { get; set; }

        public int created_at { get; set; }
    }
}
