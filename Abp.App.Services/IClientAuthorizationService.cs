﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abp.App.Services
{
    public interface IClientAuthorizationService
    {
        Task<bool> ValidateClientAuthorizationSecret(string clientId, string clientSecret);
    }
}