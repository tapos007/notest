using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nop.Plugin.Widgets.PromoSlider.Domain;
using Nop.Data.Mapping;

namespace Nop.Plugin.Widgets.PromoSlider.Data
{
   public  class PromoSliderRecordMap : NopEntityTypeConfiguration<PromoSliderRecord>
    {
        

        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<PromoSliderRecord> builder)
        {
            builder.ToTable(nameof(PromoSliderRecord));
            builder.HasKey(m => m.PromoSliderId);

            builder.Property(m=>m.PromoSliderName);
            builder.Property(m=>m.ZoneName);
            builder.Property(m=>m.Interval);
            builder.Property(m=>m.KeyBoard);
            builder.Property(m=>m.PauseOnHover);
            builder.Property(m=>m.Wrap);
            builder.Property(m=>m.KeyBoard);


        }

        #endregion
    }
}
