using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace COMcheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Control ctrl = new Control()
            {
                code = Code.CEZ_90_1_2016,
                complianceMode = ComplianceMode.UA,
                version = Version.V2416
            };

            Location loc = new Location()
            {
                state = "Nebraska",
                city = "Omaha"
            };

            Project proj = new Project()
            {
                projectTitle = CData("Hello World")
                
            };

            EfficiencyPackage[] effPackages = new EfficiencyPackage[]
            {
                new EfficiencyPackage()
            };

            Envelope env = new Envelope();

            Fixture f1 = new Fixture()
            {
                listPosition = 0,
                lightingType = LightingType.LED,
                lampType = LampType.LED_PANEL_36W,
                numberOfLamps = 1,
                quantity = 2
            };

            

            WholeBuildingUse wbu = new WholeBuildingUse()
            {
                wholeBuildingType = WholeBuildingTypes.Automotive,
                ceilingHeight = 10,
                listPosition = 0,
                constructionType = ConstructionType.NON_RESIDENTIAL,
                floorArea = 50000,

            };

            InteriorLightingSpace ils = new InteriorLightingSpace()
            {
                description = CData($"{wbu.wholeBuildingType.description} ({wbu.floorArea} sq. ft.)"),
                fixtures = new Fixture[] { f1 }
            };

            wbu.interiorLightingSpace = ils;

            Lighting light = new Lighting()
            {
                wholeBldgUses = new WholeBuildingUse[]{ wbu },
                
            };

            HVAC h = new HVAC();

            Requirements r = new Requirements();

            Building bldg = new Building()
            {
                projectType = ProjectType.NEW_CONSTRUCTION,
                bldgUseType = BuildingUseType.WHOLE_BUILDING,
                feetBldgHeight = 10.0,
                isNonresidentialConditioning = true,
                isResidentialConditioning = false,
                isSemiheatedConditioning = false,
                conditioning = Conditioning.HEATING_AND_COOLING,
                control = ctrl,
                efficiencyPackages = effPackages,
                location = loc,
                project = proj,
                envelope = env,
                lighting = light,
                hvac = h,
                requirements = r
            };

            XmlSerializer serializer = new XmlSerializer(typeof(Building));
            TextWriter writer = new StreamWriter("test.cxl");
            serializer.Serialize(writer, bldg);
            writer.Close();
        }

        static XmlCDataSection CData(string s)
        {
            return new XmlDocument().CreateCDataSection(s);
        }
    }
}
