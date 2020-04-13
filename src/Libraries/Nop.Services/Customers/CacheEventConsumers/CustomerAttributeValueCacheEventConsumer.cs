﻿using Nop.Core.Domain.Customers;
using Nop.Services.Caching;

namespace Nop.Services.Customers.CacheEventConsumers
{
    /// <summary>
    /// Represents a customer attribute value cache event consumer
    /// </summary>
    public partial class CustomerAttributeValueCacheEventConsumer : CacheEventConsumer<CustomerAttributeValue>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(CustomerAttributeValue entity)
        {
            base.Remove(NopCustomerServicesDefaults.CustomerAttributesAllCacheKey);
            base.Remove(_cacheKeyService.PrepareKeyForDefaultCache(NopCustomerServicesDefaults.CustomerAttributeValuesAllCacheKey, entity.CustomerAttributeId));
        }
    }
}