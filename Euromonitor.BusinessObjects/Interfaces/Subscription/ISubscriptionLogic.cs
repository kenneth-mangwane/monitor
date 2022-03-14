using Euromonitor.Data;
using System;
using System.Collections.Generic;

namespace Euromonitor.BusinessObjects.Interfaces
{
    public interface ISubscriptionLogic
    {
        public Subscription GetSubscription(Guid subscriptionId);
        public Subscription GetSubscription(Guid bookId, int userId);
        public List<Subscription> GetSubscriptions(int limit = 10, int skip = 0);
        public Subscription Subscribe(Guid bookId, int userId);
        public Subscription Unsubscribe(Guid bookId, int userId);
        public Subscription Unsubscribe(Guid subcriptionId);
    }
}
