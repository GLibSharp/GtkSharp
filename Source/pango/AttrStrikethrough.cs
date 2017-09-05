// Pango.AttrStrikethrough - Pango.Attribute for strikethrough
//
// Copyright (c) 2005 Novell, Inc.
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the Lesser GNU General 
// Public License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.

namespace Pango {

	using System;
	using System.Runtime.InteropServices;

	public class AttrStrikethrough : Attribute {

		[DllImport ("libpango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_attr_strikethrough_new (bool strikethrough);

		public AttrStrikethrough (bool strikethrough) : this (pango_attr_strikethrough_new (strikethrough)) {}

		internal AttrStrikethrough (IntPtr raw) : base (raw) {}

		public bool Strikethrough {
			get {
				return AttrInt.New (Handle).Value != 0;
			}
		}
	}
}
