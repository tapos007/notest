using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nop.Data.Mapping;
using Nop.Plugin.Widgets.PromoSlider.Domain;

namespace Nop.Plugin.Widgets.PromoSlider.Data
{
   public class PromoImageRecordMap : NopEntityTypeConfiguration<PromoImageRecord>
    {
        #region Methods

        /// <summary>
        /// Configures the entity
        /// </summary>
        /// <param name="builder">The builder to be used to configure the entity</param>
        public override void Configure(EntityTypeBuilder<PromoImageRecord> builder)
        {
            builder.ToTable(nameof(PromoImageRecord));
            builder.HasKey(m => m.PromoImageId);

            builder.Property(m => m.PromoSliderId);
            builder.Property(m => m.Caption);
            builder.Property(m => m.Url);
            builder.Property(m => m.DisplayOrder);


        }

        #endregion
    }
}
