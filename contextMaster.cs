using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;
namespace oncopoleLib
{
    public class contextMaster
    {

        public bool aPlanIsloaded { get; set; }
        public contextMaster(ScriptContext ctx)
        {
            aPlanIsloaded = true;
            if (ctx.PlanSetup == null)
            {
                aPlanIsloaded = false;
            }
            // thhis is a modification by LS
        }
    }
}
