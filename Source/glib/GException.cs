// GException.cs : GError handling
//
// Authors: Rachel Hestilow  <hestilow@ximian.com>
//
// Copyright (c) 2002 Rachel Hestilow 
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


namespace GLib
{

    using System;
    using System.Runtime.InteropServices;

    public class GException : Exception
    {

        [DllImport(Global.GLibNativeDll, CallingConvention = CallingConvention.Cdecl)]
        static extern void g_error_free(IntPtr errptr);

        public GException(IntPtr errptr, bool owned = true) : base()
        {
            GError err = (GError)Marshal.PtrToStructure(errptr, typeof(GError));
            Code = err.Code;
            Domain = err.Domain;
            Message = Marshaller.Utf8PtrToString(err.Msg);
            if (owned)
            {
                g_error_free(errptr);
            }
        }

        struct GError
        {
            public int Domain;
            public int Code;
            public IntPtr Msg;
        }

        public int Code { get; }

        public int Domain { get; }

        public override string Message { get; }
    }
}

