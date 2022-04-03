using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace COMcheck
{
    public enum LampType
    {
        //Linear Flourescents
        [XmlEnum("22&quot; T5 14W")]
        LF_22IN_T5_14W,
        [XmlEnum("22&quot; T5 HO 24W")]
        LF_22IN_T5_HO_24W,
        [XmlEnum("24&quot; T8 17W")]
        LF_24IN_T8_17W,
        [XmlEnum("24&quot; T8U 32W")]
        LF_24IN_T8U_32W,
        [XmlEnum("24&quot; T12 40W")]
        LF_24IN_T12_40W,
        [XmlEnum("24&quot; T12U ES 34W")]
        LF_24IN_T12U_ES_34W,
        [XmlEnum("34&quot; T5 HO 39W")]
        LF_34IN_T5_HO_39W,
        [XmlEnum("35&quot; T5 21W")]
        LF_35IN_T5_21W,
        [XmlEnum("36&quot; T8 25W")]
        LF_36IN_T8_25W,
        [XmlEnum("36&quot; T12 30W")]
        LF_36IN_T12_30W,
        [XmlEnum("36&quot; T12 ES 25W")]
        LF_36IN_T12_ES_25W,
        [XmlEnum("46&quot; T5 28W")]
        LF_46IN_T5_28W,
        [XmlEnum("46&quot; T5 54W")]
        LF_46IN_T5_54W,
        [XmlEnum("46&quot; T5 HO 54W")]
        LF_46IN_T5_HO_54W,
        [XmlEnum("48&quot; T8 25W (Super T8)")]
        LF_48IN_T8_25W_SUPER,
        [XmlEnum("48&quot; T8 28W (Super T8)")]
        LF_48IN_T8_28W_SUPER,
        [XmlEnum("48&quot; T8 30W (Super T8)")]
        LF_48IN_T8_30W_SUPER,
        [XmlEnum("48&quot; T8 32W (Super T8)")]
        LF_48IN_T8_32W_SUPER,
        [XmlEnum("48&quot; T8 32W")]
        LF_48IN_T8_32W,
        [XmlEnum("48&quot; T8 HO 44W")]
        LF_48IN_T8_HO_44W,
        [XmlEnum("48&quot; T12 40W")]
        LF_48IN_T12_40W,
        [XmlEnum("48&quot; T12 ES 34W")]
        LF_48IN_T12_ES_34W,
        [XmlEnum("48&quot; T12 Slim ES 32W")]
        LF_48IN_T12_SLIM_ES_32W,
        [XmlEnum("57&quot; T5 35W")]
        LF_57IN_T5_35W,
        [XmlEnum("60&quot; T8 40W")]
        LF_60IN_T8_40W,
        [XmlEnum("60&quot; T8 HO 55W")]
        LF_60IN_T8_HO_55W,
        [XmlEnum("72&quot; T8 HO 65W")]
        LF_72IN_T8_HO_65W,
        [XmlEnum("96&quot; T8 75W")]
        LF_96IN_T8_75W,
        [XmlEnum("96&quot; T8 ES 60W")]
        LF_96IN_T8_ES_60W,
        [XmlEnum("96&quot; T8 HO 86W")]
        LF_96IN_T8_HO_86W,
        [XmlEnum("96&quot; T12 Slim 75W")]
        LF_96IN_T12_SLIM_75W,
        [XmlEnum("96&quot; T12 Slim ES 60W")]
        LF_96IN_T12_SLIM_ES_60W,
        [XmlEnum("96&quot; T12 HO 110W")]
        LF_96IN_T12_HO_110W,
        [XmlEnum("96&quot; T12 HO ES 95W")]
        LF_96IN_T12_HO_ES_95W,

        //Compact Fluorescent
        [XmlEnum("Twin Tube 5W")]
        CF_TWIN_TUBE_5W,
        [XmlEnum("Twin Tube 7W")]
        CF_TWIN_TUBE_7W,
        [XmlEnum("Twin Tube 8/9W")]
        CF_TWIN_TUBE_9W,
        [XmlEnum("Twin Tube 13W")]
        CF_TWIN_TUBE_13W,
        [XmlEnum("Twin Tube 18W")]
        CF_TWIN_TUBE_18W,
        [XmlEnum("Twin Tube 24/26/27W")]
        CF_TWIN_TUBE_26W,
        [XmlEnum("Twin Tube 36/39W")]
        CF_TWIN_TUBE_36W,
        [XmlEnum("Twin Tube 40W")]
        CF_TWIN_TUBE_40W,
        [XmlEnum("Twin Tube 50W")]
        CF_TWIN_TUBE_50W,
        [XmlEnum("Twin Tube 55W")]
        CF_TWIN_TUBE_55W,
        [XmlEnum("Triple 4-pin 13W")]
        CF_TRIPLE_4PIN_13W,
        [XmlEnum("Triple 4-pin 18W")]
        CF_TRIPLE_4PIN_18W,
        [XmlEnum("Triple 4-pin 21W")]
        CF_TRIPLE_4PIN_21W,
        [XmlEnum("Triple 4-pin 26W")]
        CF_TRIPLE_4PIN_26W,
        [XmlEnum("Triple 4-pin 32W")]
        CF_TRIPLE_4PIN_32W,
        [XmlEnum("Triple 4-pin 42W")]
        CF_TRIPLE_4PIN_42W,
        [XmlEnum("Triple 4-pin 57W")]
        CF_TRIPLE_4PIN_57W,
        [XmlEnum("Triple 4-pin 70W")]
        CF_TRIPLE_4PIN_70W,
        [XmlEnum("Quad 2-pin 9W")]
        CF_QUAD_2PIN_9W,
        [XmlEnum("Quad 2-pin 13W")]
        CF_QUAD_2PIN_13W,
        [XmlEnum("Quad 2-pin 16W")]
        CF_QUAD_2PIN_16W,
        [XmlEnum("Quad 2-pin 18W")]
        CF_QUAD_2PIN_18W,
        [XmlEnum("Quad 2-pin 22W")]
        CF_QUAD_2PIN_22W,
        [XmlEnum("Quad 2-pin 26W")]
        CF_QUAD_2PIN_26W,
        [XmlEnum("Quad 2-pin 28W")]
        CF_QUAD_2PIN_28W,
        [XmlEnum("Quad 4-pin 10W")]
        CF_QUAD_4PIN_10W,
        [XmlEnum("Quad 4-pin 13W")]
        CF_QUAD_4PIN_13W,
        [XmlEnum("Quad 4-pin 18W")]
        CF_QUAD_4PIN_18W,
        [XmlEnum("Quad 4-pin 42W")]
        CF_QUAD_4PIN_42W,
        [XmlEnum("Quad 4-pin 57W")]
        CF_QUAD_4PIN_57W,
        [XmlEnum("Quad 4-pin 70W")]
        CF_QUAD_4PIN_70W,
        [XmlEnum("BIAX 18W")]
        CF_BIAX_18W,
        [XmlEnum("BIAX 24W")]
        CF_BIAX_24W,
        [XmlEnum("BIAX 26W")]
        CF_BIAX_26W,
        [XmlEnum("BIAX 32W")]
        CF_BIAX_32W,
        [XmlEnum("BIAX 34W")]
        CF_BIAX_34W,
        [XmlEnum("BIAX 36W")]
        CF_BIAX_36W,
        [XmlEnum("BIAX 39W")]
        CF_BIAX_39W,
        [XmlEnum("BIAX 40W")]
        CF_BIAX_40W,
        [XmlEnum("BIAX 42W")]
        CF_BIAX_42W,
        [XmlEnum("BIAX 50W")]
        CF_BIAX_50W,
        [XmlEnum("BIAX 55W")]
        CF_BIAX_55W,
        [XmlEnum("BIAX 57W")]
        CF_BIAX_57W,
        [XmlEnum("BIAX 80W")]
        CF_BIAX_80W,
        [XmlEnum("Spiral 13W")]
        CF_SPIRAL_13W,
        [XmlEnum("Spiral 15W")]
        CF_SPIRAL_15W,
        [XmlEnum("Spiral 20W")]
        CF_SPIRAL_20W,
        [XmlEnum("Spiral 23W")]
        CF_SPIRAL_23W,
        [XmlEnum("Spiral 26W")]
        CF_SPIRAL_26W,
        [XmlEnum("Spiral 27W")]
        CF_SPIRAL_27W,
        [XmlEnum("Spiral 29W")]
        CF_SPIRAL_29W,
        [XmlEnum("Spiral 30W")]
        CF_SPIRAL_30W,
        [XmlEnum("Spiral 42W")]
        CF_SPIRAL_42W,
        [XmlEnum("Reflector 15W")]
        CF_REFLECTOR_15W,
        [XmlEnum("Reflector 23W")]
        CF_REFLECTOR_23W,
        [XmlEnum("Reflector 26W")]
        CF_REFLECTOR_26W,
        [XmlEnum("Circline 20W")]
        CF_CIRCLINE_20W,
        [XmlEnum("Circline 22W")]
        CF_CIRCLINE_23W,
        [XmlEnum("Circline 32W")]
        CF_CIRCLINE_32W,
        [XmlEnum("Circline 40W")]
        CF_CIRCLINE_40W,

        //HID
        [XmlEnum("High-Pressure Sodium 35W")]
        HID_HP_SODIUM_35W,
        [XmlEnum("High-Pressure Sodium 50W")]
        HID_HP_SODIUM_50W,
        [XmlEnum("High-Pressure Sodium 70W")]
        HID_HP_SODIUM_70W,
        [XmlEnum("High-Pressure Sodium 100W")]
        HID_HP_SODIUM_100W,
        [XmlEnum("High-Pressure Sodium 150W")]
        HID_HP_SODIUM_150W,
        [XmlEnum("High-Pressure Sodium 175W")]
        HID_HP_SODIUM_175W,
        [XmlEnum("High-Pressure Sodium 200W")]
        HID_HP_SODIUM_200W,
        [XmlEnum("High-Pressure Sodium 250W")]
        HID_HP_SODIUM_250W,
        [XmlEnum("High-Pressure Sodium 320W")]
        HID_HP_SODIUM_320W,
        [XmlEnum("High-Pressure Sodium 350W")]
        HID_HP_SODIUM_350W,
        [XmlEnum("High-Pressure Sodium 360W")]
        HID_HP_SODIUM_360W,
        [XmlEnum("High-Pressure Sodium 400W")]
        HID_HP_SODIUM_400W,
        [XmlEnum("High-Pressure Sodium 750W")]
        HID_HP_SODIUM_750W,
        [XmlEnum("High-Pressure Sodium 1000W")]
        HID_HP_SODIUM_1000W,
        [XmlEnum("Low-Pressure Sodium 18W")]
        HID_lP_SODIUM_18W,
        [XmlEnum("Low-Pressure Sodium 35W")]
        HID_lP_SODIUM_35W,
        [XmlEnum("Low-Pressure Sodium 55W")]
        HID_lP_SODIUM_55W,
        [XmlEnum("Low-Pressure Sodium 90W")]
        HID_lP_SODIUM_90W,
        [XmlEnum("Low-Pressure Sodium 135W")]
        HID_lP_SODIUM_135W,
        [XmlEnum("Metal Halide 32W")]
        HID_METAL_HALIDE_32W,
        [XmlEnum("Metal Halide 50W")]
        HID_METAL_HALIDE_50W,
        [XmlEnum("Metal Halide 70W")]
        HID_METAL_HALIDE_70W,
        [XmlEnum("Metal Halide 75W")]
        HID_METAL_HALIDE_75W,
        [XmlEnum("Metal Halide 100W")]
        HID_METAL_HALIDE_100W,
        [XmlEnum("Metal Halide 150W")]
        HID_METAL_HALIDE_150W,
        [XmlEnum("Metal Halide 175W")]
        HID_METAL_HALIDE_175W,
        [XmlEnum("Metal Halide 250W")]
        HID_METAL_HALIDE_250W,
        [XmlEnum("Metal Halide 320W")]
        HID_METAL_HALIDE_320W,
        [XmlEnum("Metal Halide 350W")]
        HID_METAL_HALIDE_350W,
        [XmlEnum("Metal Halide 360W")]
        HID_METAL_HALIDE_360W,
        [XmlEnum("Metal Halide 400W")]
        HID_METAL_HALIDE_400W,
        [XmlEnum("Metal Halide 750W")]
        HID_METAL_HALIDE_750W,
        [XmlEnum("Metal Halide 1000W")]
        HID_METAL_HALIDE_1000W,
        [XmlEnum("Metal Halide 1500W")]
        HID_METAL_HALIDE_1500W,
        [XmlEnum("Ceramic Metal Halide 20W")]
        HID_CERAMIC_METAL_HALIDE_20W,
        [XmlEnum("Ceramic Metal Halide 39W")]
        HID_CERAMIC_METAL_HALIDE_39W,
        [XmlEnum("Ceramic Metal Halide 50W")]
        HID_CERAMIC_METAL_HALIDE_50W,
        [XmlEnum("Ceramic Metal Halide 70W")]
        HID_CERAMIC_METAL_HALIDE_70W,
        [XmlEnum("Ceramic Metal Halide 100W")]
        HID_CERAMIC_METAL_HALIDE_100W,
        [XmlEnum("Ceramic Metal Halide 150W")]
        HID_CERAMIC_METAL_HALIDE_150W,
        [XmlEnum("Ceramic Metal Halide 250W")]
        HID_CERAMIC_METAL_HALIDE_250W,
        [XmlEnum("Ceramic Metal Halide 320W")]
        HID_CERAMIC_METAL_HALIDE_320W,
        [XmlEnum("Ceramic Metal Halide 350W")]
        HID_CERAMIC_METAL_HALIDE_350W,
        [XmlEnum("Ceramic Metal Halide 400W")]
        HID_CERAMIC_METAL_HALIDE_400W,

        //Incandescent
        [XmlEnum("Incandescent 20W")]
        INCANDESCENT_20W,
        [XmlEnum("Incandescent 25W")]
        INCANDESCENT_25W,
        [XmlEnum("Incandescent 30W")]
        INCANDESCENT_30W,
        [XmlEnum("Incandescent 35W")]
        INCANDESCENT_35W,
        [XmlEnum("Incandescent 40W")]
        INCANDESCENT_40W,
        [XmlEnum("Incandescent 45W")]
        INCANDESCENT_45W,
        [XmlEnum("Incandescent 50W")]
        INCANDESCENT_50W,
        [XmlEnum("Incandescent 60W")]
        INCANDESCENT_60W,
        [XmlEnum("Incandescent 65W")]
        INCANDESCENT_65W,
        [XmlEnum("Incandescent 75W")]
        INCANDESCENT_75W,
        [XmlEnum("Incandescent 100W")]
        INCANDESCENT_100W,
        [XmlEnum("Incandescent 150W")]
        INCANDESCENT_150W,
        [XmlEnum("Incandescent 250W")]
        INCANDESCENT_250W,
        [XmlEnum("Incandescent 300W")]
        INCANDESCENT_300W,
        [XmlEnum("Incandescent 350W")]
        INCANDESCENT_350W,
        [XmlEnum("Incandescent 400W")]
        INCANDESCENT_400W,
        [XmlEnum("Incandescent 500W")]
        INCANDESCENT_500W,
        [XmlEnum("Incandescent 750W")]
        INCANDESCENT_750W,
        [XmlEnum("Incandescent 1000W")]
        INCANDESCENT_1000W,

        //Halogen
        [XmlEnum("Halogen 55W")]
        HALOGEN_55W,
        [XmlEnum("Halogen 70W")]
        HALOGEN_70W,
        [XmlEnum("Halogen 80W")]
        HALOGEN_80W,
        [XmlEnum("Halogen 90W")]
        HALOGEN_90W,
        [XmlEnum("Halogen 120W")]
        HALOGEN_120W,
        [XmlEnum("Halogen MR-11 20W")]
        HALOGEN_MR11_20W,
        [XmlEnum("Halogen MR-11 35W")]
        HALOGEN_MR11_35W,
        [XmlEnum("Halogen MR-16 20W")]
        HALOGEN_MR16_20W,
        [XmlEnum("Halogen MR-16 21W")]
        HALOGEN_MR16_21W,
        [XmlEnum("Halogen MR-16 35W")]
        HALOGEN_MR16_35W,
        [XmlEnum("Halogen MR-16 50W")]
        HALOGEN_MR16_50W,
        [XmlEnum("Halogen MR-16 71W")]
        HALOGEN_MR16_71W,
        [XmlEnum("12V Halogen 20W")]
        HALOGEN_12V_20W,
        [XmlEnum("12V Halogen 25W")]
        HALOGEN_12V_25W,
        [XmlEnum("12V Halogen 35W")]
        HALOGEN_12V_35W,
        [XmlEnum("12V Halogen 37W")]
        HALOGEN_12V_37W,
        [XmlEnum("12V Halogen 42W")]
        HALOGEN_12V_42W,
        [XmlEnum("12V Halogen 50W")]
        HALOGEN_12V_50W,
        [XmlEnum("12V Halogen 65W")]
        HALOGEN_12V_65W,
        [XmlEnum("12V Halogen 71W")]
        HALOGEN_12V_71W,
        [XmlEnum("12V Halogen 75W")]
        HALOGEN_12V_75W,
        [XmlEnum("12V Halogen 100W")]
        HALOGEN_12V_100W,

        //LED
        [XmlEnum("LED MR 2W")]
        LED_MR_2W,
        [XmlEnum("LED MR 3.2W")]
        LED_MR_3_2W,
        [XmlEnum("LED MR 3.9W")]
        LED_MR_3_9W,
        [XmlEnum("LED MR 4W")]
        LED_MR_4W,
        [XmlEnum("LED MR 6W")]
        LED_MR_6W,
        [XmlEnum("LED MR 7W")]
        LED_MR_7W,
        [XmlEnum("LED MR 8W")]
        LED_MR_8W,
        [XmlEnum("LED MR 10W")]
        LED_MR_10W,
        [XmlEnum("LED PAR 7W")]
        LED_PAR_7W,
        [XmlEnum("LED PAR 8W")]
        LED_PAR_8W,
        [XmlEnum("LED PAR 10W")]
        LED_PAR_10W,
        [XmlEnum("LED PAR 11W")]
        LED_PAR_11W,
        [XmlEnum("LED PAR 12W")]
        LED_PAR_12W,
        [XmlEnum("LED PAR 13W")]
        LED_PAR_13W,
        [XmlEnum("LED PAR 15W")]
        LED_PAR_15W,
        [XmlEnum("LED PAR 16W")]
        LED_PAR_16W,
        [XmlEnum("LED PAR 17W")]
        LED_PAR_17W,
        [XmlEnum("LED PAR 18W")]
        LED_PAR_18W,
        [XmlEnum("LED PAR 20W")]
        LED_PAR_20W,
        [XmlEnum("LED A Lamp 2.5W")]
        LED_A_LAMP_2_5W,
        [XmlEnum("LED A Lamp 3.2W")]
        LED_A_LAMP_3_2W,
        [XmlEnum("LED A Lamp 6W")]
        LED_A_LAMP_6W,
        [XmlEnum("LED A Lamp 6.5W")]
        LED_A_LAMP_6_5W,
        [XmlEnum("LED A Lamp 7W")]
        LED_A_LAMP_7W,
        [XmlEnum("LED A Lamp 8W")]
        LED_A_LAMP_8W,
        [XmlEnum("LED A Lamp 9W")]
        LED_A_LAMP_9W,
        [XmlEnum("LED A Lamp 11W")]
        LED_A_LAMP_11W,
        [XmlEnum("LED A Lamp 12W")]
        LED_A_LAMP_12W,
        [XmlEnum("LED A Lamp 13W")]
        LED_A_LAMP_13W,
        [XmlEnum("LED A Lamp 25W")]
        LED_A_LAMP_25W,
        [XmlEnum("LED Linear 8W")]
        LED_LINEAR_W,
        [XmlEnum("LED Linear 10W")]
        LED_LINEAR_10W,
        [XmlEnum("LED Linear 11W")]
        LED_LINEAR_11W,
        [XmlEnum("LED Linear 15W")]
        LED_LINEAR_15W,
        [XmlEnum("LED Linear 17W")]
        LED_LINEAR_17W,
        [XmlEnum("LED Linear 20W")]
        LED_LINEAR_20W,
        [XmlEnum("LED Linear 22W")]
        LED_LINEAR_22W,
        [XmlEnum("LED Linear 33W")]
        LED_LINEAR_33W,
        [XmlEnum("LED Panel 19W")]
        LED_PANEL_19W,
        [XmlEnum("LED Panel 33W")]
        LED_PANEL_33W,
        [XmlEnum("LED Panel 36W")]
        LED_PANEL_36W,
        [XmlEnum("LED Panel 38W")]
        LED_PANEL_38W,
        [XmlEnum("LED Panel 40W")]
        LED_PANEL_40W,
        [XmlEnum("LED Panel 41W")]
        LED_PANEL_41W,
        [XmlEnum("LED Panel 44W")]
        LED_PANEL_44W,
        [XmlEnum("LED Panel 54W")]
        LED_PANEL_54W,
        [XmlEnum("LED Panel 55W")]
        LED_PANEL_55W,
        [XmlEnum("LED Panel 60W")]
        LED_PANEL_60W,
        [XmlEnum("LED Panel 70W")]
        LED_PANEL_70W,
        [XmlEnum("LED Panel 80W")]
        LED_PANEL_80W,
        [XmlEnum("LED Panel 110W")]
        LED_PANEL_110W,
        [XmlEnum("LED Undercabinet Unit 4W")]
        LED_UNDERCABINET_UNIT_4W,
        [XmlEnum("LED Undercabinet Unit 5.7W")]
        LED_UNDERCABINET_UNIT_5_7W,
        [XmlEnum("LED Undercabinet Unit 8W")]
        LED_UNDERCABINET_UNIT_8W,
        [XmlEnum("LED Undercabinet Unit 9W")]
        LED_UNDERCABINET_UNIT_9W,
        [XmlEnum("LED Undercabinet Unit 11.4W")]
        LED_UNDERCABINET_UNIT_11_4W,
        [XmlEnum("LED Undercabinet Unit 12W")]
        LED_UNDERCABINET_UNIT_12W,
        [XmlEnum("LED Undercabinet Unit 14.4W")]
        LED_UNDERCABINET_UNIT_14_4W,
        [XmlEnum("LED Undercabinet Unit 15W")]
        LED_UNDERCABINET_UNIT_15W,
        [XmlEnum("LED Undercabinet Unit 17.1W")]
        LED_UNDERCABINET_UNIT_17_1W,
        [XmlEnum("LED Undercabinet Unit 24W")]
        LED_UNDERCABINET_UNIT_24W,
        [XmlEnum("LED Roadway-Parking Unit 42W")]
        LED_ROADWAY_PARKING_UNIT_42W,
        [XmlEnum("LED Roadway-Parking Unit 54W")]
        LED_ROADWAY_PARKING_UNIT_54W,
        [XmlEnum("LED Roadway-Parking Unit 67W")]
        LED_ROADWAY_PARKING_UNIT_67W,
        [XmlEnum("LED Roadway-Parking Unit 82W")]
        LED_ROADWAY_PARKING_UNIT_82W,
        [XmlEnum("LED Roadway-Parking Unit 88W")]
        LED_ROADWAY_PARKING_UNIT_88W,
        [XmlEnum("LED Roadway-Parking Unit 94W")]
        LED_ROADWAY_PARKING_UNIT_94W,
        [XmlEnum("LED Roadway-Parking Unit 106W")]
        LED_ROADWAY_PARKING_UNIT_106W,
        [XmlEnum("LED Roadway-Parking Unit 110W")]
        LED_ROADWAY_PARKING_UNIT_110W,
        [XmlEnum("LED Roadway-Parking Unit 118W")]
        LED_ROADWAY_PARKING_UNIT_118W,
        [XmlEnum("LED Roadway-Parking Unit 130W")]
        LED_ROADWAY_PARKING_UNIT_130W,
        [XmlEnum("LED Roadway-Parking Unit 220W")]
        LED_ROADWAY_PARKING_UNIT_220W,
        [XmlEnum("LED Roadway-Parking Unit 223W")]
        LED_ROADWAY_PARKING_UNIT_223W,
        [XmlEnum("LED Other Fixture Unit 6.5W")]
        LED_OTHER_FIXTURE_UNIT_6_5W,
        [XmlEnum("LED Other Fixture Unit 13W")]
        LED_OTHER_FIXTURE_UNIT_13W,
        [XmlEnum("LED Other Fixture Unit 16W")]
        LED_OTHER_FIXTURE_UNIT_16W,
        [XmlEnum("LED Other Fixture Unit 25W")]
        LED_OTHER_FIXTURE_UNIT_25W,
        [XmlEnum("LED Other Fixture Unit 28W")]
        LED_OTHER_FIXTURE_UNIT_28W,
        [XmlEnum("LED Other Fixture Unit 36W")]
        LED_OTHER_FIXTURE_UNIT_36W,
        [XmlEnum("LED Other Fixture Unit 40W")]
        LED_OTHER_FIXTURE_UNIT_40W,
        [XmlEnum("LED Other Fixture Unit 46W")]
        LED_OTHER_FIXTURE_UNIT_46W,
        [XmlEnum("LED Other Fixture Unit 50W")]
        LED_OTHER_FIXTURE_UNIT_50W,
        [XmlEnum("LED Other Fixture Unit 60W")]
        LED_OTHER_FIXTURE_UNIT_60W,
        [XmlEnum("LED Other Fixture Unit 80W")]
        LED_OTHER_FIXTURE_UNIT_80W,
        [XmlEnum("LED Other Fixture Unit 90W")]
        LED_OTHER_FIXTURE_UNIT_90W,
        [XmlEnum("LED Other Fixture Unit 95W")]
        LED_OTHER_FIXTURE_UNIT_95W,
        [XmlEnum("LED Other Fixture Unit 103W")]
        LED_OTHER_FIXTURE_UNIT_103W,
        [XmlEnum("LED Other Fixture Unit 125W")]
        LED_OTHER_FIXTURE_UNIT_125W,

        //Induction
        [XmlEnum("Induction Lamp 23W")]
        INDUCTION_LAMP_23W,
        [XmlEnum("Induction Lamp 40W")]
        INDUCTION_LAMP_40W,
        [XmlEnum("Induction Lamp 50W")]
        INDUCTION_LAMP_50W,
        [XmlEnum("Induction Circular 40W")]
        INDUCTION_CIRCULAR_40W,
        [XmlEnum("Induction Circular 80W")]
        INDUCTION_CIRCULAR_80W,
        [XmlEnum("Induction Circular 100W")]
        INDUCTION_CIRCULAR_100W,
        [XmlEnum("Induction Circular 120W")]
        INDUCTION_CIRCULAR_120W,
        [XmlEnum("Induction Circular 150W")]
        INDUCTION_CIRCULAR_150W,
        [XmlEnum("Induction Circular 200W")]
        INDUCTION_CIRCULAR_200W,
        [XmlEnum("Induction Circular 300W")]
        INDUCTION_CIRCULAR_300W,
        [XmlEnum("Induction Rectangular 40W")]
        INDUCTION_RECTANGULAR_40W,
        [XmlEnum("Induction Rectangular 80W")]
        INDUCTION_RECTANGULAR_80W,
        [XmlEnum("Induction Rectangular 120W")]
        INDUCTION_RECTANGULAR_120W,
        [XmlEnum("Induction Rectangular 150W")]
        INDUCTION_RECTANGULAR_150W,
        [XmlEnum("Induction Rectangular 200W")]
        INDUCTION_RECTANGULAR_200W,
        [XmlEnum("Induction Rectangular 300W")]
        INDUCTION_RECTANGULAR_300W,

        Other
    }
}
