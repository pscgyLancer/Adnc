﻿using Adnc.Infra.EventBus;
using System;

namespace Adnc.Shared.Events
{
    /// <summary>
    /// 客户充值
    /// </summary>
    [Serializable]
    public class CustomerRechargedEvent : BaseEvent<CustomerRechargedEvent.EventData>
    {
        public CustomerRechargedEvent()
        {
        }

        public CustomerRechargedEvent(long id, EventData eventData, string source)
            : base(id, eventData, source)
        {
        }

        public class EventData
        {
            public long CustomerId { get; set; }

            public decimal Amount { get; set; }

            public long TransactionLogId { get; set; }
        }
    }
}