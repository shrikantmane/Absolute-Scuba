using System.Linq;
using System.Web.Mvc;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Plugin.Widgets.NivoSlider.Infrastructure.Cache;
using Nop.Plugin.Widgets.NivoSlider.Models;
using Nop.Services.Configuration;
using Nop.Services.Localization;
using Nop.Services.Media;
using Nop.Services.Stores;
using Nop.Web.Framework.Controllers;

namespace Nop.Plugin.Widgets.NivoSlider.Controllers
{
    public class WidgetsNivoSliderController : BasePluginController
    {
        private readonly IWorkContext _workContext;
        private readonly IStoreContext _storeContext;
        private readonly IStoreService _storeService;
        private readonly IPictureService _pictureService;
        private readonly ISettingService _settingService;
        private readonly ICacheManager _cacheManager;
        private readonly ILocalizationService _localizationService;

        public WidgetsNivoSliderController(IWorkContext workContext,
            IStoreContext storeContext,
            IStoreService storeService, 
            IPictureService pictureService,
            ISettingService settingService,
            ICacheManager cacheManager,
            ILocalizationService localizationService)
        {
            this._workContext = workContext;
            this._storeContext = storeContext;
            this._storeService = storeService;
            this._pictureService = pictureService;
            this._settingService = settingService;
            this._cacheManager = cacheManager;
            this._localizationService = localizationService;
        }

        protected string GetPictureUrl(int pictureId)
        {
            string cacheKey = string.Format(ModelCacheEventConsumer.PICTURE_URL_MODEL_KEY, pictureId);
            return _cacheManager.Get(cacheKey, () =>
            {
                var url = _pictureService.GetPictureUrl(pictureId, showDefaultPicture: false);
                //little hack here. nulls aren't cacheable so set it to ""
                if (url == null)
                    url = "";

                return url;
            });
        }

        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure()
        {
            //load settings for a chosen store scope
            var storeScope = this.GetActiveStoreScopeConfiguration(_storeService, _workContext);
            var nivoSliderSettings = _settingService.LoadSetting<NivoSliderSettings>(storeScope);
            var model = new ConfigurationModel();
            model.SlideCategories.Add(new SelectListItem() { Text = "SlideCategory1", Value = "SlideCategory1" });
            model.SlideCategories.Add(new SelectListItem() { Text = "SlideCategory2", Value = "SlideCategory2" });
            model.SlideCategories.Add(new SelectListItem() { Text = "SlideCategory3", Value = "SlideCategory3" });

            model.Picture1Id = nivoSliderSettings.Picture1Id;
            model.Text1 = nivoSliderSettings.Text1;
            model.Link1 = nivoSliderSettings.Link1;
            //Added for drop down
            model.Select1 = nivoSliderSettings.Select1;
            //Added for Heading
            model.Heading1 = nivoSliderSettings.Heading1;
            //Added for Sub Heading
            model.SubHeading1 = nivoSliderSettings.SubHeading1;

            model.Picture2Id = nivoSliderSettings.Picture2Id;
            model.Text2 = nivoSliderSettings.Text2;
            model.Link2 = nivoSliderSettings.Link2;
            model.Select2 = nivoSliderSettings.Select2;
            model.Heading2 = nivoSliderSettings.Heading2;
            model.SubHeading2 = nivoSliderSettings.SubHeading2;

            model.Picture3Id = nivoSliderSettings.Picture3Id;
            model.Text3 = nivoSliderSettings.Text3;
            model.Link3 = nivoSliderSettings.Link3;
            model.Select3 = nivoSliderSettings.Select3;
            model.Heading3 = nivoSliderSettings.Heading3;
            model.SubHeading3 = nivoSliderSettings.SubHeading3;

            model.Picture4Id = nivoSliderSettings.Picture4Id;
            model.Text4 = nivoSliderSettings.Text4;
            model.Link4 = nivoSliderSettings.Link4;
            model.Select4 = nivoSliderSettings.Select4;
            model.Heading4 = nivoSliderSettings.Heading4;
            model.SubHeading4 = nivoSliderSettings.SubHeading4;

            model.Picture5Id = nivoSliderSettings.Picture5Id;
            model.Text5 = nivoSliderSettings.Text5;
            model.Link5 = nivoSliderSettings.Link5;
            model.Select5 = nivoSliderSettings.Select5;
            model.Heading5 = nivoSliderSettings.Heading5;
            model.SubHeading5 = nivoSliderSettings.SubHeading5;

            model.Picture6Id = nivoSliderSettings.Picture6Id;
            model.Text6 = nivoSliderSettings.Text6;
            model.Link6 = nivoSliderSettings.Link6;
            model.Select6 = nivoSliderSettings.Select6;
            model.Heading6 = nivoSliderSettings.Heading6;
            model.SubHeading6 = nivoSliderSettings.SubHeading6;

            model.Picture7Id = nivoSliderSettings.Picture7Id;
            model.Text7 = nivoSliderSettings.Text7;
            model.Link7 = nivoSliderSettings.Link7;
            model.Select7 = nivoSliderSettings.Select7;
            model.Heading7 = nivoSliderSettings.Heading7;
            model.SubHeading7 = nivoSliderSettings.SubHeading7;

            model.Picture8Id = nivoSliderSettings.Picture8Id;
            model.Text8 = nivoSliderSettings.Text8;
            model.Link8 = nivoSliderSettings.Link8;
            model.Select8 = nivoSliderSettings.Select8;
            model.Heading8 = nivoSliderSettings.Heading8;
            model.SubHeading8 = nivoSliderSettings.SubHeading8;

            model.Picture9Id = nivoSliderSettings.Picture9Id;
            model.Text9 = nivoSliderSettings.Text9;
            model.Link9 = nivoSliderSettings.Link9;
            model.Select9 = nivoSliderSettings.Select9;
            model.Heading9 = nivoSliderSettings.Heading9;
            model.SubHeading9 = nivoSliderSettings.SubHeading9;

            model.ActiveStoreScopeConfiguration = storeScope;
            if (storeScope > 0)
            {
                model.Picture1Id_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Picture1Id, storeScope);
                model.Text1_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Text1, storeScope);
                model.Link1_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Link1, storeScope);
                //Added for drop down
                model.Select1_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Select1, storeScope);
                //Added for Heading
                model.Heading1_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Heading1, storeScope);
                //Added for SubHeading
                model.SubHeading1_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.SubHeading1, storeScope);

                model.Picture2Id_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Picture2Id, storeScope);
                model.Text2_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Text2, storeScope);
                model.Link2_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Link2, storeScope);
                model.Select1_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Select1, storeScope);
                model.Heading1_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Heading1, storeScope);
                model.SubHeading1_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.SubHeading1, storeScope);

                model.Picture3Id_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Picture3Id, storeScope);
                model.Text3_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Text3, storeScope);
                model.Link3_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Link3, storeScope);
                model.Select3_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Select3, storeScope);
                model.Heading3_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Heading3, storeScope);
                model.SubHeading3_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.SubHeading3, storeScope);

                model.Picture4Id_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Picture4Id, storeScope);
                model.Text4_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Text4, storeScope);
                model.Link4_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Link4, storeScope);
                model.Select4_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Select4, storeScope);
                model.Heading4_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Heading4, storeScope);
                model.SubHeading4_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.SubHeading4, storeScope);

                model.Picture5Id_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Picture5Id, storeScope);
                model.Text5_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Text5, storeScope);
                model.Link5_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Link5, storeScope);
                model.Select5_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Select5, storeScope);
                model.Heading5_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Heading5, storeScope);
                model.SubHeading5_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.SubHeading5, storeScope);

                model.Picture6Id_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Picture6Id, storeScope);
                model.Text6_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Text6, storeScope);
                model.Link6_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Link6, storeScope);
                model.Select6_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Select6, storeScope);
                model.Heading6_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Heading6, storeScope);
                model.SubHeading6_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.SubHeading6, storeScope);

                model.Picture7Id_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Picture7Id, storeScope);
                model.Text7_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Text7, storeScope);
                model.Link7_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Link7, storeScope);
                model.Select7_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Select7, storeScope);
                model.Heading7_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Heading7, storeScope);
                model.SubHeading7_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.SubHeading7, storeScope);

                model.Picture8Id_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Picture8Id, storeScope);
                model.Text8_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Text8, storeScope);
                model.Link8_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Link8, storeScope);
                model.Select8_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Select8, storeScope);
                model.Heading8_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Heading8, storeScope);
                model.SubHeading8_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.SubHeading8, storeScope);

                model.Picture9Id_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Picture9Id, storeScope);
                model.Text9_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Text9, storeScope);
                model.Link9_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Link9, storeScope);
                model.Select9_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Select9, storeScope);
                model.Heading9_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.Heading9, storeScope);
                model.SubHeading9_OverrideForStore = _settingService.SettingExists(nivoSliderSettings, x => x.SubHeading9, storeScope);
            }

            return View("~/Plugins/Widgets.NivoSlider/Views/Configure.cshtml", model);
        }

        [HttpPost]
        [AdminAuthorize]
        [ChildActionOnly]
        public ActionResult Configure(ConfigurationModel model)
        {
            //load settings for a chosen store scope
            var storeScope = this.GetActiveStoreScopeConfiguration(_storeService, _workContext);
            var nivoSliderSettings = _settingService.LoadSetting<NivoSliderSettings>(storeScope);

            //get previous picture identifiers
            var previousPictureIds = new[] 
            {
                nivoSliderSettings.Picture1Id,
                nivoSliderSettings.Picture2Id,
                nivoSliderSettings.Picture3Id,
                nivoSliderSettings.Picture4Id,
                nivoSliderSettings.Picture5Id,
                nivoSliderSettings.Picture6Id,
                nivoSliderSettings.Picture7Id,
                nivoSliderSettings.Picture8Id,
                nivoSliderSettings.Picture9Id
            };

            nivoSliderSettings.Picture1Id = model.Picture1Id;
            nivoSliderSettings.Text1 = model.Text1;
            nivoSliderSettings.Link1 = model.Link1;            
            nivoSliderSettings.Select1 = model.Select1;            
            nivoSliderSettings.Heading1 = model.Heading1;
            nivoSliderSettings.SubHeading1 = model.SubHeading1;

            nivoSliderSettings.Picture2Id = model.Picture2Id;
            nivoSliderSettings.Text2 = model.Text2;
            nivoSliderSettings.Link2 = model.Link2;
            nivoSliderSettings.Select2 = model.Select2;
            nivoSliderSettings.Heading2 = model.Heading2;
            nivoSliderSettings.SubHeading2 = model.SubHeading2;

            nivoSliderSettings.Picture3Id = model.Picture3Id;
            nivoSliderSettings.Text3 = model.Text3;
            nivoSliderSettings.Link3 = model.Link3;
            nivoSliderSettings.Select3 = model.Select3;
            nivoSliderSettings.Heading3 = model.Heading3;
            nivoSliderSettings.SubHeading3 = model.SubHeading3;

            nivoSliderSettings.Picture4Id = model.Picture4Id;
            nivoSliderSettings.Text4 = model.Text4;
            nivoSliderSettings.Link4 = model.Link4;
            nivoSliderSettings.Select4 = model.Select4;
            nivoSliderSettings.Heading4 = model.Heading4;
            nivoSliderSettings.SubHeading4 = model.SubHeading4;

            nivoSliderSettings.Picture5Id = model.Picture5Id;
            nivoSliderSettings.Text5 = model.Text5;
            nivoSliderSettings.Link5 = model.Link5;
            nivoSliderSettings.Select5 = model.Select5;
            nivoSliderSettings.Heading5 = model.Heading5;
            nivoSliderSettings.SubHeading5 = model.SubHeading5;

            nivoSliderSettings.Picture6Id = model.Picture6Id;
            nivoSliderSettings.Text6 = model.Text6;
            nivoSliderSettings.Link6 = model.Link6;
            nivoSliderSettings.Select6 = model.Select6;
            nivoSliderSettings.Heading6 = model.Heading6;
            nivoSliderSettings.SubHeading6 = model.SubHeading6;

            nivoSliderSettings.Picture7Id = model.Picture7Id;
            nivoSliderSettings.Text7 = model.Text7;
            nivoSliderSettings.Link7 = model.Link7;
            nivoSliderSettings.Select7 = model.Select7;
            nivoSliderSettings.Heading7 = model.Heading7;
            nivoSliderSettings.SubHeading7 = model.SubHeading7;

            nivoSliderSettings.Picture8Id = model.Picture8Id;
            nivoSliderSettings.Text8 = model.Text8;
            nivoSliderSettings.Link8 = model.Link8;
            nivoSliderSettings.Select8 = model.Select8;
            nivoSliderSettings.Heading8 = model.Heading8;
            nivoSliderSettings.SubHeading8 = model.SubHeading8;

            nivoSliderSettings.Picture9Id = model.Picture9Id;
            nivoSliderSettings.Text9 = model.Text9;
            nivoSliderSettings.Link9 = model.Link9;
            nivoSliderSettings.Select9 = model.Select9;
            nivoSliderSettings.Heading9 = model.Heading9;
            nivoSliderSettings.SubHeading9 = model.SubHeading9;

            /* We do not clear cache after each setting update.
             * This behavior can increase performance because cached settings will not be cleared 
             * and loaded from database after each update */
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Picture1Id, model.Picture1Id_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Text1, model.Text1_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Link1, model.Link1_OverrideForStore, storeScope, false);
            //Added for drop down
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Select1, model.Select1_OverrideForStore, storeScope, false);
            //Added for Heading
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Heading1, model.Heading1_OverrideForStore, storeScope, false);
            //Added for SubHeading
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.SubHeading1, model.SubHeading1_OverrideForStore, storeScope, false);

            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Picture2Id, model.Picture2Id_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Text2, model.Text2_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Link2, model.Link2_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Select2, model.Select2_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Heading2, model.Heading2_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.SubHeading2, model.SubHeading2_OverrideForStore, storeScope, false);

            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Picture3Id, model.Picture3Id_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Text3, model.Text3_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Link3, model.Link3_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Select3, model.Select3_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Heading3, model.Heading3_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.SubHeading3, model.SubHeading3_OverrideForStore, storeScope, false);

            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Picture4Id, model.Picture4Id_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Text4, model.Text4_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Link4, model.Link4_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Select4, model.Select4_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Heading4, model.Heading4_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.SubHeading4, model.SubHeading4_OverrideForStore, storeScope, false);

            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Picture5Id, model.Picture5Id_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Text5, model.Text5_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Link5, model.Link5_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Select5, model.Select5_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Heading5, model.Heading5_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.SubHeading5, model.SubHeading5_OverrideForStore, storeScope, false);

            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Picture6Id, model.Picture6Id_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Text6, model.Text6_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Link6, model.Link6_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Select6, model.Select6_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Heading6, model.Heading6_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.SubHeading6, model.SubHeading6_OverrideForStore, storeScope, false);

            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Picture7Id, model.Picture7Id_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Text7, model.Text7_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Link7, model.Link7_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Select7, model.Select7_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Heading7, model.Heading7_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.SubHeading7, model.SubHeading7_OverrideForStore, storeScope, false);

            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Picture8Id, model.Picture8Id_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Text8, model.Text8_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Link8, model.Link8_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Select8, model.Select8_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Heading8, model.Heading8_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.SubHeading8, model.SubHeading8_OverrideForStore, storeScope, false);

            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Picture9Id, model.Picture9Id_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Text9, model.Text9_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Link9, model.Link9_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Select9, model.Select9_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.Heading9, model.Heading9_OverrideForStore, storeScope, false);
            _settingService.SaveSettingOverridablePerStore(nivoSliderSettings, x => x.SubHeading9, model.SubHeading9_OverrideForStore, storeScope, false);
            
            //now clear settings cache
            _settingService.ClearCache();
            
            //get current picture identifiers
            var currentPictureIds = new[]
            {
                nivoSliderSettings.Picture1Id,
                nivoSliderSettings.Picture2Id,
                nivoSliderSettings.Picture3Id,
                nivoSliderSettings.Picture4Id,
                nivoSliderSettings.Picture5Id,
                nivoSliderSettings.Picture6Id,
                nivoSliderSettings.Picture7Id,
                nivoSliderSettings.Picture8Id,
                nivoSliderSettings.Picture9Id
            };

            //delete an old picture (if deleted or updated)
            foreach (var pictureId in previousPictureIds.Except(currentPictureIds))
            { 
                var previousPicture = _pictureService.GetPictureById(pictureId);
                if (previousPicture != null)
                    _pictureService.DeletePicture(previousPicture);
            }

            SuccessNotification(_localizationService.GetResource("Admin.Plugins.Saved"));
            return Configure();
        }

        [ChildActionOnly]
        public ActionResult PublicInfo(string widgetZone, object additionalData = null)
        {
            var nivoSliderSettings = _settingService.LoadSetting<NivoSliderSettings>(_storeContext.CurrentStore.Id);

            var model = new PublicInfoModel();
            model.Picture1Url = GetPictureUrl(nivoSliderSettings.Picture1Id);
            model.Text1 = nivoSliderSettings.Text1;
            model.Link1 = nivoSliderSettings.Link1;
            //Added for drop down
            model.Select1 = nivoSliderSettings.Select1;
            //Added for Heading
            model.Heading1 = nivoSliderSettings.Heading1;
            //Added for SubHeading
            model.SubHeading1 = nivoSliderSettings.SubHeading1;

            model.Picture2Url = GetPictureUrl(nivoSliderSettings.Picture2Id);
            model.Text2 = nivoSliderSettings.Text2;
            model.Link2 = nivoSliderSettings.Link2;
            model.Select2 = nivoSliderSettings.Select2;
            model.Heading2 = nivoSliderSettings.Heading2;
            model.SubHeading2 = nivoSliderSettings.SubHeading2;

            model.Picture3Url = GetPictureUrl(nivoSliderSettings.Picture3Id);
            model.Text3 = nivoSliderSettings.Text3;
            model.Link3 = nivoSliderSettings.Link3;
            model.Select3 = nivoSliderSettings.Select3;
            model.Heading3 = nivoSliderSettings.Heading3;
            model.SubHeading3 = nivoSliderSettings.SubHeading3;

            model.Picture4Url = GetPictureUrl(nivoSliderSettings.Picture4Id);
            model.Text4 = nivoSliderSettings.Text4;
            model.Link4 = nivoSliderSettings.Link4;
            model.Select4 = nivoSliderSettings.Select4;
            model.Heading4 = nivoSliderSettings.Heading4;
            model.SubHeading4 = nivoSliderSettings.SubHeading4;

            model.Picture5Url = GetPictureUrl(nivoSliderSettings.Picture5Id);
            model.Text5 = nivoSliderSettings.Text5;
            model.Link5 = nivoSliderSettings.Link5;
            model.Select5 = nivoSliderSettings.Select5;
            model.Heading5 = nivoSliderSettings.Heading5;
            model.SubHeading5 = nivoSliderSettings.SubHeading5;

            model.Picture6Url = GetPictureUrl(nivoSliderSettings.Picture6Id);
            model.Text6 = nivoSliderSettings.Text6;
            model.Link6 = nivoSliderSettings.Link6;
            model.Select6 = nivoSliderSettings.Select6;
            model.Heading6 = nivoSliderSettings.Heading6;
            model.SubHeading6 = nivoSliderSettings.SubHeading6;

            model.Picture7Url = GetPictureUrl(nivoSliderSettings.Picture7Id);
            model.Text7 = nivoSliderSettings.Text7;
            model.Link7 = nivoSliderSettings.Link7;
            model.Select7 = nivoSliderSettings.Select7;
            model.Heading7 = nivoSliderSettings.Heading7;
            model.SubHeading7 = nivoSliderSettings.SubHeading7;

            model.Picture8Url = GetPictureUrl(nivoSliderSettings.Picture8Id);
            model.Text8 = nivoSliderSettings.Text8;
            model.Link8 = nivoSliderSettings.Link8;
            model.Select8 = nivoSliderSettings.Select8;
            model.Heading8 = nivoSliderSettings.Heading8;
            model.SubHeading8 = nivoSliderSettings.SubHeading8;

            model.Picture9Url = GetPictureUrl(nivoSliderSettings.Picture9Id);
            model.Text9 = nivoSliderSettings.Text9;
            model.Link9 = nivoSliderSettings.Link9;
            model.Select9 = nivoSliderSettings.Select9;
            model.Heading9 = nivoSliderSettings.Heading9;
            model.SubHeading9 = nivoSliderSettings.SubHeading9;

            if (string.IsNullOrEmpty(model.Picture1Url) && string.IsNullOrEmpty(model.Picture2Url) &&
                string.IsNullOrEmpty(model.Picture3Url) && string.IsNullOrEmpty(model.Picture4Url) &&
                string.IsNullOrEmpty(model.Picture5Url) && string.IsNullOrEmpty(model.Picture6Url) &&
                string.IsNullOrEmpty(model.Picture7Url) && string.IsNullOrEmpty(model.Picture8Url) &&
                string.IsNullOrEmpty(model.Picture9Url))
                //no pictures uploaded
                return Content("");


            return View("~/Plugins/Widgets.NivoSlider/Views/PublicInfo.cshtml", model);
        }
    }
}