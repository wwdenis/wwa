// Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
// See License.txt in the project root for license information.

using Wwa.Core.Collections;
using Wwa.Core.Logic;
using Marketplace.Domain.Models.Security;
using Marketplace.Logic.Queries.Security;

namespace Marketplace.Logic.Contracts.Security
{
    public interface IUserService : IUpdatableService<User>
    {
        User Get(string userName);

        PagedList<User> List(UserQuery request);
    }
}