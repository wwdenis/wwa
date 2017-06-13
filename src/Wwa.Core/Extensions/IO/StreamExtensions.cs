// Copyright 2017 (c) [Denis Da Silva]. All rights reserved.
// See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wwa.Core.Extensions.IO
{
	public static class StreamExtensions
	{
		public static byte[] ToByteArray(this Stream stream)
		{
			if (stream == null)
				return null;
			
			using (MemoryStream ms = new MemoryStream())
			{
				stream.CopyTo(ms);
				return ms.ToArray();
			}
		}
	}
}
