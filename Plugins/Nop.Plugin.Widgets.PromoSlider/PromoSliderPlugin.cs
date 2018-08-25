using System;
using System.Collections.Generic;
using System.Text;
using Nop.Core.Plugins;
using Nop.Plugin.Widgets.PromoSlider.Data;
using Nop.Services.Cms;

namespace Nop.Plugin.Widgets.PromoSlider
{
   public class PromoSliderPlugin : BasePlugin, IWidgetPlugin
    {
        private readonly PromoSliderObjectContext _context;

        public PromoSliderPlugin(PromoSliderObjectContext context)
        {
            _context = context;
        }

        public override void Install()
        {
            _context.Install();
            base.Install();
        }

        public override void Uninstall()
        {
            _context.Uninstall();
            base.Uninstall();
        }


        public IList<string> GetWidgetZones()
        {
            return new List<string>();
        }

        public string GetWidgetViewComponentName(string widgetZone)
        {
            return "WidgetsPromoSlider";
        }
    }
}
