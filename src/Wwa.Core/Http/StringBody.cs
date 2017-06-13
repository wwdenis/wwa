// Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
// See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wwa.Core.Http
{
	public class StringBody : HttpBody<string>
	{
		public StringBody(string content = null, IDictionary<string, string> cookies = null) : base(content, cookies)
		{
		}
	}
}
