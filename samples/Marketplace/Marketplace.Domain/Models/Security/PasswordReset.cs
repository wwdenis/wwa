// Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
// See License.txt in the project root for license information.

using System;

namespace Marketplace.Domain.Models.Security
{
    public class PasswordReset
    {
        public string IdentityId { get; set; }
        public string NewPassword { get; set; }
    }
}
