using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Nop.Web.Framework;
using Nop.Web.Framework.Mvc;
using System.Collections.Generic;

namespace Nop.Plugin.Widgets.NivoSlider.Models
{
    public class ConfigurationModel : BaseNopModel
    {
        public int ActiveStoreScopeConfiguration { get; set; }

        public ConfigurationModel()
        {
            SlideCategories = new List<SelectListItem>();
        }
        public IList<SelectListItem> SlideCategories { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Picture")]
        [UIHint("Picture")]
        public int Picture1Id { get; set; }
        public bool Picture1Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Text")]
        [AllowHtml]
        public string Text1 { get; set; }
        public bool Text1_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Link")]
        [AllowHtml]
        public string Link1 { get; set; }
        public bool Link1_OverrideForStore { get; set; }
        //Added drop down for category
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Select")]
        [AllowHtml]
        public string Select1 { get; set; }
        public bool Select1_OverrideForStore { get; set; }
        //Added for Heading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Heading")]
        [AllowHtml]
        public string Heading1 { get; set; }
        public bool Heading1_OverrideForStore { get; set; }
        //Added for SubHeading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.SubHeading")]
        [AllowHtml]
        public string SubHeading1 { get; set; }
        public bool SubHeading1_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Picture")]
        [UIHint("Picture")]
        public int Picture2Id { get; set; }
        public bool Picture2Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Text")]
        [AllowHtml]
        public string Text2 { get; set; }
        public bool Text2_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Link")]
        [AllowHtml]
        public string Link2 { get; set; }
        public bool Link2_OverrideForStore { get; set; }
        //Added drop down for category
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Select")]
        [AllowHtml]
        public string Select2 { get; set; }
        public bool Select2_OverrideForStore { get; set; }
        //Added for Heading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Heading")]
        [AllowHtml]
        public string Heading2 { get; set; }
        public bool Heading2_OverrideForStore { get; set; }
        //Added for SubHeading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.SubHeading")]
        [AllowHtml]
        public string SubHeading2 { get; set; }
        public bool SubHeading2_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Picture")]
        [UIHint("Picture")]
        public int Picture3Id { get; set; }
        public bool Picture3Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Text")]
        [AllowHtml]
        public string Text3 { get; set; }
        public bool Text3_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Link")]
        [AllowHtml]
        public string Link3 { get; set; }
        public bool Link3_OverrideForStore { get; set; }
        //Added drop down for category
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Select")]
        [AllowHtml]
        public string Select3 { get; set; }
        public bool Select3_OverrideForStore { get; set; }
        //Added for Heading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Heading")]
        [AllowHtml]
        public string Heading3{ get; set; }
        public bool Heading3_OverrideForStore { get; set; }
        //Added for SubHeading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.SubHeading")]
        [AllowHtml]
        public string SubHeading3 { get; set; }
        public bool SubHeading3_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Picture")]
        [UIHint("Picture")]
        public int Picture4Id { get; set; }
        public bool Picture4Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Text")]
        [AllowHtml]
        public string Text4 { get; set; }
        public bool Text4_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Link")]
        [AllowHtml]
        public string Link4 { get; set; }
        public bool Link4_OverrideForStore { get; set; }
        //Added drop down for category
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Select")]
        [AllowHtml]
        public string Select4 { get; set; }
        public bool Select4_OverrideForStore { get; set; }
        //Added for Heading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Heading")]
        [AllowHtml]
        public string Heading4 { get; set; }
        public bool Heading4_OverrideForStore { get; set; }
        //Added for SubHeading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.SubHeading")]
        [AllowHtml]
        public string SubHeading4 { get; set; }
        public bool SubHeading4_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Picture")]
        [UIHint("Picture")]
        public int Picture5Id { get; set; }
        public bool Picture5Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Text")]
        [AllowHtml]
        public string Text5 { get; set; }
        public bool Text5_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Link")]
        [AllowHtml]
        public string Link5 { get; set; }
        public bool Link5_OverrideForStore { get; set; }
        //Added drop down for category
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Select")]
        [AllowHtml]
        public string Select5 { get; set; }
        public bool Select5_OverrideForStore { get; set; }
        //Added for Heading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Heading")]
        [AllowHtml]
        public string Heading5 { get; set; }
        public bool Heading5_OverrideForStore { get; set; }
        //Added for SubHeading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.SubHeading")]
        [AllowHtml]
        public string SubHeading5 { get; set; }
        public bool SubHeading5_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Picture")]
        [UIHint("Picture")]
        public int Picture6Id { get; set; }
        public bool Picture6Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Text")]
        [AllowHtml]
        public string Text6 { get; set; }
        public bool Text6_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Link")]
        [AllowHtml]
        public string Link6 { get; set; }
        public bool Link6_OverrideForStore { get; set; }
        //Added drop down for category
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Select")]
        [AllowHtml]
        public string Select6 { get; set; }
        public bool Select6_OverrideForStore { get; set; }
        //Added for Heading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Heading")]
        [AllowHtml]
        public string Heading6 { get; set; }
        public bool Heading6_OverrideForStore { get; set; }
        //Added for SubHeading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.SubHeading")]
        [AllowHtml]
        public string SubHeading6 { get; set; }
        public bool SubHeading6_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Picture")]
        [UIHint("Picture")]
        public int Picture7Id { get; set; }
        public bool Picture7Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Text")]
        [AllowHtml]
        public string Text7 { get; set; }
        public bool Text7_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Link")]
        [AllowHtml]
        public string Link7 { get; set; }
        public bool Link7_OverrideForStore { get; set; }
        //Added drop down for category
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Select")]
        [AllowHtml]
        public string Select7 { get; set; }
        public bool Select7_OverrideForStore { get; set; }
        //Added for Heading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Heading")]
        [AllowHtml]
        public string Heading7 { get; set; }
        public bool Heading7_OverrideForStore { get; set; }
        //Added for SubHeading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.SubHeading")]
        [AllowHtml]
        public string SubHeading7 { get; set; }
        public bool SubHeading7_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Picture")]
        [UIHint("Picture")]
        public int Picture8Id { get; set; }
        public bool Picture8Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Text")]
        [AllowHtml]
        public string Text8 { get; set; }
        public bool Text8_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Link")]
        [AllowHtml]
        public string Link8 { get; set; }
        public bool Link8_OverrideForStore { get; set; }
        //Added drop down for category
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Select")]
        [AllowHtml]
        public string Select8 { get; set; }
        public bool Select8_OverrideForStore { get; set; }
        //Added for Heading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Heading")]
        [AllowHtml]
        public string Heading8 { get; set; }
        public bool Heading8_OverrideForStore { get; set; }
        //Added for SubHeading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.SubHeading")]
        [AllowHtml]
        public string SubHeading8 { get; set; }
        public bool SubHeading8_OverrideForStore { get; set; }

        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Picture")]
        [UIHint("Picture")]
        public int Picture9Id { get; set; }
        public bool Picture9Id_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Text")]
        [AllowHtml]
        public string Text9 { get; set; }
        public bool Text9_OverrideForStore { get; set; }
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Link")]
        [AllowHtml]
        public string Link9 { get; set; }
        public bool Link9_OverrideForStore { get; set; }
        //Added drop down for category
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Select")]
        [AllowHtml]
        public string Select9 { get; set; }
        public bool Select9_OverrideForStore { get; set; }
        //Added for Heading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.Heading")]
        [AllowHtml]
        public string Heading9 { get; set; }
        public bool Heading9_OverrideForStore { get; set; }
        //Added for SubHeading
        [NopResourceDisplayName("Plugins.Widgets.NivoSlider.SubHeading")]
        [AllowHtml]
        public string SubHeading9 { get; set; }
        public bool SubHeading9_OverrideForStore { get; set; }

    }
}