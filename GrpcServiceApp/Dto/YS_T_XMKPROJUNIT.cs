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
        public string ITEMID { get; set; }
        public string PROCODE { get; set; }
        public int AGENCY { get; set; }
        public string AGENCYTYPE { get; set; }
        public int BDGYEAR { get; set; }
        public string ADMDIVCODE { get; set; }
    }
}
