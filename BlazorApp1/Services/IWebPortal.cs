﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorApp1.Data;


namespace BlazorApp1.Services
{
    public interface IWebPortal
    {
        Task<List<OrderDetails>> GetAllOrder();

    }
}
