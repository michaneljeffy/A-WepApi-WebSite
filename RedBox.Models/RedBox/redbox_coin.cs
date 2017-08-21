namespace RedBox.Models.RedBox
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fans_online2.redbox_coin")]
    public partial class redbox_coin
    {
        [Column(TypeName = "uint")]
        public long id { get; set; }

        public int redbox_id { get; set; }

        public int unit_price { get; set; }

        public int day_count { get; set; }

        public sbyte is_coinprint { get; set; }

        public int com { get; set; }

        public int port { get; set; }

        public int created_at { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime updated_at { get; set; }
    }
}
