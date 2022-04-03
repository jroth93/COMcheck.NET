using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace COMcheck
{
    [XmlType(AnonymousType = true, Namespace = "http://energycode.pnl.gov/ns/ComCheckBuildingSchema")]
    [XmlRoot("building", Namespace = "http://energycode.pnl.gov/ns/ComCheckBuildingSchema", IsNullable = false)]
    public class Building
    {
        [XmlElement(Order = 0)]
        public ProjectType projectType { get; set; } = ProjectType.NEW_CONSTRUCTION;
        [XmlElement(Order = 1)]
        public BuildingUseType buildingUseType { get; set; } = BuildingUseType.WHOLE_BUILDING;
        [XmlElement(Order = 2)]
        public double feetBldgHeight { get; set; } = 10.0;
        [XmlElement(Order = 3)]
        public bool isNonresidentialConditioning { get; set; } = true;
        [XmlElement(Order = 4)]
        public bool isResidentialConditioning { get; set; } = false;
        [XmlElement(Order = 5)]
        public bool isSemiheatedConditioning { get; set; } = false;
        [XmlElement(Order = 6)]
        public Conditioning conditioning { get; set; } = Conditioning.HEATING_AND_COOLING;
        [XmlElement(Order = 7)]
        public Control control;
        [XmlArray(ElementName = "efficiencyPackages", Order = 8)]
        [XmlArrayItem("efficiencyPackage")]
        public EfficiencyPackage[] efficiencyPackages;
        [XmlElement(Order = 9)]
        public Location location;
        [XmlElement(Order = 10)]
        public Project project;
        [XmlElement(Order = 11)]
        public Envelope envelope;
        [XmlElement(Order = 12)]
        public Lighting lighting;
        [XmlElement(Order = 13)]
        public HVAC hvac;
        [XmlElement(Order = 14)]
        public Requirements requirements;
    }

    public enum ProjectType
    {
        NEW_CONSTRUCTION,
        ADDITION,
        ALTERATION
    }

    public enum BuildingUseType
    {
        WHOLE_BUILDING,
        ACTIVITY
    }

    public enum Conditioning
    {
        HEATING_AND_COOLING
    }

    public class Control
    {
        public Code code { get; set; } = Code.CEZ_IECC2018;
        public ComplianceMode complianceMode { get; set; } = ComplianceMode.UA;
        public Version version { get; set; } = Version.V2416;
        
    }

    public enum Code
    {
        CEZ_90_1_2007,
        CEZ_90_1_2010,
        CEZ_90_1_2013,
        CEZ_90_1_2016,
        CEZ_IECC2009,
        CEZ_IECC2012,
        CEZ_IECC2015,
        CEZ_IECC2018
    }

    public enum ComplianceMode
    {
        UA
    }

    public enum Version
    {
        [XmlEnum("24.1.6")]
        V2416
    }

    public class EfficiencyPackage
    {
        public double credit { get; set; } = 1.00;
        public EfficiencyPackageType type { get; set; } = EfficiencyPackageType.EFF_PACKAGE_ENHANCED_LIGHTING_CONTROLS;
    }

    public enum EfficiencyPackageType
    {
        EFF_PACKAGE_HVAC_PERFORMANCE,
        EFF_PACKAGE_LIGHTING_REDUCED_LPD,
        EFF_PACKAGE_ONSITE_RENEWABLES,
        EFF_PACKAGE_SWH_PERFORMANCE,
        EFF_PACKAGE_ENHANCED_LIGHTING_CONTROLS,
        EFF_PACKAGE_DEDICATED_OUTDOOR_AIR_SYSTEM,
        EFF_PACKAGE_ENHANCED_ENVELOPE_PERFORMANCE,
        EFF_PACKAGE_REDUCED_AIR_INFILTRATION
    }
    public class Location
    {
        public string state { get; set; }
        public string city { get; set; }
    }

    public class Project
    {
        public XmlCDataSection projectPermitNumber { get; set; }
        public XmlCDataSection projectPermitDate { get; set; }
        public XmlCDataSection projectTitle { get; set; }
        public XmlCDataSection projectAddress { get; set; }
        public XmlCDataSection projectAddress2 { get; set; }
        public XmlCDataSection projectCity { get; set; }
        public XmlCDataSection projectState { get; set; }
        public XmlCDataSection projectZipCode { get; set; }
        public XmlCDataSection ownerFirstName { get; set; }
        public XmlCDataSection ownerLastName { get; set; }
        public XmlCDataSection ownerCompany { get; set; }
        public XmlCDataSection ownerAddress { get; set; }
        public XmlCDataSection ownerAddress2 { get; set; }
        public XmlCDataSection ownerCity { get; set; }
        public XmlCDataSection ownerState { get; set; }
        public XmlCDataSection ownerZipCode { get; set; }
        public XmlCDataSection ownerPhone { get; set; }
        public XmlCDataSection ownerEmail { get; set; }
        public XmlCDataSection developerFirstName { get; set; }
        public XmlCDataSection developerLastName { get; set; }
        public XmlCDataSection developerCompany { get; set; }
        public XmlCDataSection developerAddress { get; set; }
        public XmlCDataSection developerAddress2 { get; set; }
        public XmlCDataSection developerCity { get; set; }
        public XmlCDataSection developerState { get; set; }
        public XmlCDataSection developerZipCode { get; set; }
        public XmlCDataSection developerPhone { get; set; }
        public XmlCDataSection developerEmail { get; set; }
        public bool projectComplete { get; set; } = false;
        public XmlCDataSection notes { get; set; }
    }
}
