// Pango.AttrList.cs - Pango AttrList customizations
//
// Authors:  Mike Kestner  <mkestner@novell.com>
//
// Copyright (c) 2008 Novell, Inc.
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

	public partial class AttrList {

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr pango_attribute_copy(IntPtr raw);

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_attr_list_insert(IntPtr raw, IntPtr attr);

		public void Insert(Pango.Attribute attr) {
			pango_attr_list_insert(Handle, pango_attribute_copy(attr.Handle));
		}

		[DllImport("pango-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void pango_attr_list_insert_before(IntPtr raw, IntPtr attr);

		public void InsertBefore(Pango.Attribute attr) {
			pango_attr_list_insert_before(Handle, pango_attribute_copy(attr.Handle));
		}
	}
}