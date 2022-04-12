using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace COMcheck
{
    public class Lighting
    {
        [XmlElement(Order = 0)]
        public int exteriorLightingZone { get; set; } = 0;
        [XmlElement(Order = 1)]
        public ExteriorLightingZoneType exteriorLightingZoneType { get; set; } = ExteriorLightingZoneType.EXT_ZONE_UNSPECIFIED;
        [XmlArray(Order = 2)]
        [XmlArrayItem("wholeBldgUse")]
        public WholeBuildingUse[] wholeBldgUses;
    }

    public enum ExteriorLightingZoneType
    {
        EXT_ZONE_UNSPECIFIED,
        EXT_ZONE_RESIDENTIAL, //LZ2
        EXT_ZONE_RESIDENTIAL_COMMERCIAL_MIXED, //LZ2
        EXT_ZONE_NEIGHBORHOOD_BUS_DISTRICT, //LZ2
        EXT_ZONE_METRO_COMMERCIAL, //LZ4
        EXT_ZONE_LIGHT_INDUSTRIAL, //LZ2
        EXT_ZONE_PARKS, //LZ1
        EXT_ZONE_FOREST, //LZ1
        EXT_ZONE_RURAL, //LZ1
        EXT_ZONE_OTHER //LZ3
    }

    public class WholeBuildingUse : IXmlSerializable
    {
        public WholeBuildingType wholeBuildingType { get; set; }
        public double ceilingHeight { get; set; }
        public int listPosition { get; set; }
        public ConstructionType constructionType { get; set; } = ConstructionType.NON_RESIDENTIAL;
        public int floorArea { get; set; }
        public InteriorLightingSpace interiorLightingSpace { get; set; } = new InteriorLightingSpace();

        public void WriteXml(XmlWriter writer)
        {

            writer.WriteElementString(nameof(wholeBuildingType.wholeBldgType), wholeBuildingType.wholeBldgType);
            writer.WriteElementString(nameof(wholeBuildingType.key), wholeBuildingType.key.ToString());
            writer.WriteElementString(nameof(wholeBuildingType.powerDensity), wholeBuildingType.powerDensity.ToString());
            writer.WriteElementString(nameof(wholeBuildingType.internalLoad), wholeBuildingType.internalLoad.ToString());

            writer.WriteElementString(nameof(ceilingHeight), ceilingHeight.ToString());
            writer.WriteElementString(nameof(listPosition), listPosition.ToString());
            writer.WriteElementString(nameof(constructionType), constructionType.ToString());
            writer.WriteElementString(nameof(floorArea), floorArea.ToString());

            new XmlSerializer(typeof(InteriorLightingSpace)).Serialize(writer, interiorLightingSpace);
        }

        public void ReadXml(XmlReader reader){}
        public XmlSchema GetSchema(){ return null;}
    }

    public static class WholeBuildingTypes
    {
        public readonly static WholeBuildingType Automotive = new WholeBuildingType("Automotive Facility", "WHOLE_BUILDING_AUTOMOTIVE", 133811997, 0.71, 0.75);

    }

    public class WholeBuildingType
    {
        public WholeBuildingType(string d, string wbt, int k, double pd, double il)
        {
            description = d;
            wholeBldgType = wbt;
            key = k;
            powerDensity = pd;
            internalLoad = il;

        }
        public string description { get; }
        public string wholeBldgType { get; }
        public int key { get; }
        public double powerDensity { get; }
        public double internalLoad { get; }
    }

    public enum ConstructionType
    {
        NON_RESIDENTIAL,
        RESIDENTIAL
    }

    [XmlRoot("interiorLightingSpace")]
    public class InteriorLightingSpace
    {
        public XmlCDataSection description { get; set; }
        public AltExemptType altExemptType { get; set; }
        public int preAltNumberFixtures { get; set; } = 0;
        public int numFixturesAlteredOrAdded { get; set; } = 0;
        public double preAltTotalWattage { get; set; }
        public double postAltTotalWattage { get; set; }
        public AllowanceType allowanceType { get; set; } = AllowanceType.ALLOWANCE_NONE;
        public int allowanceFloorArea { get; set; } = 0;
        public int rcrPerimeter { get; set; } = 0;
        public int rcrFloorToWorkplaneHeight { get; set; } = 0;
        public int rcrWorkplaneToLuminaireHeight { get; set; } = 0;
        [XmlArrayItem("fixture")]
        public Fixture[] fixtures;
    }

    public enum AltExemptType
    {
        EXEMPT_NOT_APPLICABLE
    }
    public enum AllowanceType
    {
        ALLOWANCE_NONE
    }

    public class Fixture
    {
        public int listPosition { get; set; }
        public double lampWattage { get; set; }
        public LightingType lightingType { get; set; }
        public XmlCDataSection typeOfFixture { get; set; }
        public XmlCDataSection description { get; set; }
        public XmlCDataSection fixtureType { get; set; }
        public LampType lampType { get; set; }
        public Ballast ballast { get; set; }
        public int numberOfLamps { get; set; }
        public double fixtureWattage { get; set; }

        
        public TrackLightingWattageBasisType trackLightingWattageBasisType { get; set; }
        public double trackTotalLuminaireWattage { get; set; }
        public double trackLength { get; set; }
        public int trackCircuitBreakerAmps { get; set; }
        public int trackCircuitBreakerVolts { get; set; }
        public int? trackCurrentLimiterWattage { get; set; }
        public int? trackTransformerWattage { get; set; }
        public int quantity { get; set; }
         
    }

    public enum LightingType
    {
        LONG_FLUOR,
        COMP_FLUOR,
        HID,
        INCANDESCENT,
        HALOGEN,
        TRACK_LIGHTING,
        LED,
        INDUCTION
    }

    public enum Ballast
    {
        UNSPECIFIED_BALLAST,
        MAGNETIC,
        ELECTRONIC,
        PREMIUM_EFF,
        DIMMING,

    }

    public enum TrackLightingWattageBasisType
    {
        TRACK_BASIS,
        CURRENT_LIMITING_DEVICE_CAPACITY,
        TRANSFORMER_CAPACITY
    }
}
