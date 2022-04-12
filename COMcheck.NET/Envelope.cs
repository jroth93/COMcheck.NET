using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMcheck
{
    public class Envelope
    {
        public double postAltWindowWallPct { get; set; }
        public double postAltSkylightRoofPct { get; set; }
        public double altPctGlazingAreaReplaced { get; set; }
        public double altPctSkylightAreaReplaced { get; set; }
        public bool useOrientDetails { get; set; } = true;
        public bool useVltDetails { get; set; } = false;
        public bool useCoolRoofPerformanceDetails { get; set; } = false;
        public AirBarrierComplianceType airBarrierComplianceType { get; set; } = AirBarrierComplianceType.AIR_BARRIER_OPTION_UNKNOWN;
        public bool applyWindowPctAllowanceForDaylighting { get; set; } = false;
        public bool applySkylightPctAllowanceForDaylighting { get; set; } = false;

    }

    public enum AirBarrierComplianceType
    {
        AIR_BARRIER_OPTION_UNKNOWN,
        AIR_BARRIER_OPTION_MATERIAL_PERM,
        AIR_BARRIER_OPTION_ASSEMBLY_PERM,
        AIR_BARRIER_OPTION_LEAKAGE_TEST
    }
}
