using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MD2._0ffline.Data
{
    public class SOD_InboundDirectiveHeader : BaseEntity
    {
        public DateTimeOffset ACTIVEFROMDATETIME { get; set; }
        public int ACTIVEFROMDATETIMETZID { get; set; }
        public string INCOMINGLOCATION { get; set; }
        public string INVENTLOCATIONID { get; set; }
        public string INVENTSITEID { get; set; }
        public string VERSIONID { get; set; }
        public string VERSIONNOTES { get; set; }
        public int VERSIONSTATUS { get; set; }
        public DateTimeOffset MODIFIEDDATETIME { get; set; }
        public string MODIFIEDBY { get; set; }
        public DateTimeOffset CREATEDDATETIME { get; set; }
        public string CREATEDBY { get; set; }
        public string DATAAREAID { get; set; }
        public int RECVERSION { get; set; }
        public int PARTITION { get; set; }
        public int RECID { get; set; }
        public string VERSIONNOTE1 { get; set; }
        public string VERSIONNOTE2 { get; set; }
        public string VERSIONNOTE3 { get; set; }
        public string VERSIONNOTE4 { get; set; }
    }
}
