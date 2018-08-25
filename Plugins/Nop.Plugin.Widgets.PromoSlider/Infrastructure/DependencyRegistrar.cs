using Autofac;
using Autofac.Core;
using Nop.Core.Configuration;
using Nop.Core.Data;
using Nop.Core.Infrastructure;
using Nop.Core.Infrastructure.DependencyManagement;
using Nop.Data;
using Nop.Plugin.Widgets.PromoSlider.Data;
using Nop.Plugin.Widgets.PromoSlider.Domain;
using Nop.Plugin.Widgets.PromoSlider.Services;
using Nop.Web.Framework.Infrastructure.Extensions;

namespace Nop.Plugin.Widgets.PromoSlider.Infrastructure
{
    /// <summary>
    /// Dependency registrar
    /// </summary>
    public class DependencyRegistrar : IDependencyRegistrar
    {
        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="builder">Container builder</param>
        /// <param name="typeFinder">Type finder</param>
        /// <param name="config">Config</param>
        public virtual void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config)
        {
            builder.RegisterType<PromoSliderService>().As<IPromoSliderService>().InstancePerLifetimeScope();

            //data context
            builder.RegisterPluginDataContext<PromoSliderObjectContext>("nop_object_context_widget_promo_slider_zip");

            //override required repository with our custom context
            builder.RegisterType<EfRepository<PromoSliderRecord>>().As<IRepository<PromoSliderRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>("nop_object_context_shipping_weight_total_zip"))
                .InstancePerLifetimeScope();


            builder.RegisterType<EfRepository<PromoImageRecord>>().As<IRepository<PromoImageRecord>>()
                .WithParameter(ResolvedParameter.ForNamed<IDbContext>("nop_object_context_widget_promo_slider_zip"))
                .InstancePerLifetimeScope();
        }

        /// <summary>
        /// Order of this dependency registrar implementation
        /// </summary>
        public int Order => 1;
    }
}