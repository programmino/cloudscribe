﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Author:					Joe Audette
// Created:					2014-08-10
// Last Modified:			2016-04-27
// 

using System;

namespace cloudscribe.Core.Models
{
    public class UserClaim : IUserClaim
    {

        public UserClaim()
        { }

        
        public Guid Id { get; set; } = Guid.Empty;
        public Guid SiteGuid { get; set; } = Guid.Empty;
        public Guid UserGuid { get; set; } = Guid.Empty;
        
        private string claimType = string.Empty;
        public string ClaimType
        {
            get { return claimType ?? string.Empty; }
            set { claimType = value; }
        }

        private string claimValue = string.Empty;
        public string ClaimValue
        {
            get { return claimValue ?? string.Empty; }
            set { claimValue = value; }
        }

        
        public static UserClaim FromIUserClaim(IUserClaim i)
        {
            UserClaim u = new UserClaim();

            u.ClaimType = i.ClaimType;
            u.ClaimValue = i.ClaimValue;
            u.Id = i.Id;
            u.SiteGuid = i.SiteGuid;
            u.UserGuid = i.UserGuid;
           

            return u;
        }

    }

}
