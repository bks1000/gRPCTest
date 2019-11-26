using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcServiceApp.Dto
{
    public class YS_T_XMKPROJUNIT
    {
        [Key]
        public string ItemID { get; set; }
        public string ProCode { get; set; }
        public int Agency { get; set; }
        public string AgencyType { get; set; }
        public int BdgYear { get; set; }
        public string AdmdivCode { get; set; }
    }
}
