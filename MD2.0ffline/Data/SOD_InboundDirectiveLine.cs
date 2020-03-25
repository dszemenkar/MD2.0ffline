using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MD2._0ffline.Data
{
    public class SOD_InboundDirectiveLine : BaseEntity
    {
        public string CONFIGID { get; set; }
        public int FILLINGDIRECTION { get; set; }
        public decimal INBOUNDQTY { get; set; }
        public string INVENTSTATUSID { get; set; }
        public string ITEMID { get; set; }
        public string NOTES { get; set; }
        public decimal QTY { get; set; }
        public decimal REMAININGQTY { get; set; }
        public int SORTING { get; set; }
        public string VERSIONID { get; set; }
        public int WMSLOCATIONFULL { get; set; }
        public string WMSLOCATIONID { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public int PARTITION { get; set; }
        public int RECID { get; set; }
    }
}
