﻿using System;
using System.Collections.Generic;
using System.Text;
using Adnc.Core.Shared.Entities;

namespace Adnc.Usr.Core.Entities
{
    public class UserRechargeLogs : EfEntity
    {
        public long UserId { get; set; }

        public string Type { get; set; }

        public decimal Amount { get; set; }


    }
}
