﻿using System;
using System.Collections.Generic;

namespace ServiceContracts
{
    public interface IFinnhubService
    {
        Dictionary<string, object> GetCompanyProfile(string stockSymbol);
        Dictionary<string, object> GetStockPriceQuote(string stockSymbol);
    }
}
