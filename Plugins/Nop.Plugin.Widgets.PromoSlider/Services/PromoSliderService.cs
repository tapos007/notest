using System;
using Nop.Core;
using Nop.Core.Caching;
using Nop.Core.Data;
using Nop.Plugin.Widgets.PromoSlider.Domain;
using Nop.Services.Events;

namespace Nop.Plugin.Widgets.PromoSlider.Services
{
    /// <summary>
    /// Tax rate service
    /// </summary>
    public partial class PromoSliderService : IPromoSliderService
    {
        #region Fields

        private readonly IEventPublisher _eventPublisher;
        private readonly IRepository<PromoSliderRecord> _promoSliderRepository;
        private readonly IRepository<PromoImageRecord> _promoImageRecordRepository;
        private readonly ICacheManager _cacheManager;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="eventPublisher">Event publisher</param>
        /// <param name="cacheManager">Cache manager</param>
        /// <param name="promoSliderRepository"></param>
        /// <param name="promoImageRecordRepository"></param>
        public PromoSliderService(IEventPublisher eventPublisher,
            ICacheManager cacheManager,
            IRepository<PromoSliderRecord> promoSliderRepository,
             IRepository<PromoImageRecord> promoImageRecordRepository
            )
        {
            this._eventPublisher = eventPublisher;
            this._cacheManager = cacheManager;
            this._promoSliderRepository = promoSliderRepository;
            this._promoImageRecordRepository = promoImageRecordRepository;
        }

        #endregion

        #region Methods

        
        #endregion
    }
}