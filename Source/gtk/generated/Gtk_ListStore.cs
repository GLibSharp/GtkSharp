// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gtk {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class ListStore : GLib.Object, Gtk.ITreeModel, Gtk.ITreeDragSource, Gtk.ITreeDragDest, Gtk.ITreeSortable {

		public ListStore (IntPtr raw) : base(raw) {}

		protected ListStore() : base(IntPtr.Zero)
		{
			CreateNativeObject (new string [0], new GLib.Value [0]);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _class_abi = null;
		static public new GLib.AbiStruct class_abi {
			get {
				if (_class_abi == null)
					_class_abi = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("_gtk_reserved1"
							, GLib.Object.class_abi.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved1
							, null
							, "_gtk_reserved2"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved2"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved2
							, "_gtk_reserved1"
							, "_gtk_reserved3"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved3"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved3
							, "_gtk_reserved2"
							, "_gtk_reserved4"
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
						new GLib.AbiField("_gtk_reserved4"
							, -1
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // _gtk_reserved4
							, "_gtk_reserved3"
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _class_abi;
			}
		}


		// End of the ABI representation.

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_store_append(IntPtr raw, IntPtr iter);

		public Gtk.TreeIter Append() {
			Gtk.TreeIter iter;
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			gtk_list_store_append(Handle, native_iter);
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return iter;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_store_clear(IntPtr raw);

		public void Clear() {
			gtk_list_store_clear(Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_list_store_get_type();

		public static new GLib.GType GType { 
			get {
				IntPtr raw_ret = gtk_list_store_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_store_insert(IntPtr raw, IntPtr iter, int position);

		public Gtk.TreeIter Insert(int position) {
			Gtk.TreeIter iter;
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			gtk_list_store_insert(Handle, native_iter, position);
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return iter;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_store_insert_after(IntPtr raw, IntPtr iter, IntPtr sibling);

		public Gtk.TreeIter InsertAfter(Gtk.TreeIter sibling) {
			Gtk.TreeIter iter;
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			IntPtr native_sibling = GLib.Marshaller.StructureToPtrAlloc (sibling);
			gtk_list_store_insert_after(Handle, native_iter, native_sibling);
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			Marshal.FreeHGlobal (native_sibling);
			return iter;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_store_insert_before(IntPtr raw, IntPtr iter, IntPtr sibling);

		public Gtk.TreeIter InsertBefore(Gtk.TreeIter sibling) {
			Gtk.TreeIter iter;
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			IntPtr native_sibling = GLib.Marshaller.StructureToPtrAlloc (sibling);
			gtk_list_store_insert_before(Handle, native_iter, native_sibling);
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			Marshal.FreeHGlobal (native_sibling);
			return iter;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_store_insert_with_valuesv(IntPtr raw, IntPtr iter, int position, out int columns, IntPtr values, int n_values);

		[Obsolete]
		public int InsertWithValuesv(Gtk.TreeIter iter, int position, GLib.Value values, int n_values) {
			int columns;
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			IntPtr native_values = GLib.Marshaller.StructureToPtrAlloc (values);
			gtk_list_store_insert_with_valuesv(Handle, native_iter, position, out columns, native_values, n_values);
			Marshal.FreeHGlobal (native_iter);
			Marshal.FreeHGlobal (native_values);
			return columns;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_list_store_iter_is_valid(IntPtr raw, IntPtr iter);

		public bool IterIsValid(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool raw_ret = gtk_list_store_iter_is_valid(Handle, native_iter);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_store_move_after(IntPtr raw, IntPtr iter, IntPtr position);

		public void MoveAfter(Gtk.TreeIter iter, Gtk.TreeIter position) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			IntPtr native_position = GLib.Marshaller.StructureToPtrAlloc (position);
			gtk_list_store_move_after(Handle, native_iter, native_position);
			Marshal.FreeHGlobal (native_iter);
			Marshal.FreeHGlobal (native_position);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_store_move_before(IntPtr raw, IntPtr iter, IntPtr position);

		public void MoveBefore(Gtk.TreeIter iter, Gtk.TreeIter position) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			IntPtr native_position = GLib.Marshaller.StructureToPtrAlloc (position);
			gtk_list_store_move_before(Handle, native_iter, native_position);
			Marshal.FreeHGlobal (native_iter);
			Marshal.FreeHGlobal (native_position);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_store_prepend(IntPtr raw, IntPtr iter);

		public Gtk.TreeIter Prepend() {
			Gtk.TreeIter iter;
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			gtk_list_store_prepend(Handle, native_iter);
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return iter;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_list_store_remove(IntPtr raw, IntPtr iter);

		public bool Remove(ref Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool raw_ret = gtk_list_store_remove(Handle, native_iter);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_store_reorder(IntPtr raw, int[] new_order);

		public void Reorder(int[] new_order) {
			gtk_list_store_reorder(Handle, new_order);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_store_set_column_types(IntPtr raw, int n_columns, IntPtr[] types);

		public GLib.GType[] ColumnTypes { 
			set {
				int cnt_value = value == null ? 0 : value.Length;
				IntPtr[] native_value = new IntPtr [cnt_value];
				for (int i = 0; i < cnt_value; i++)
					native_value [i] = value[i].Val;
				gtk_list_store_set_column_types(Handle, cnt_value,  native_value);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_store_set_valist(IntPtr raw, IntPtr iter, IntPtr var_args);

		public void SetValist(Gtk.TreeIter iter, IntPtr var_args) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_list_store_set_valist(Handle, native_iter, var_args);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_store_set_value(IntPtr raw, IntPtr iter, int column, IntPtr value);

		public void SetValue(Gtk.TreeIter iter, int column, GLib.Value value) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gtk_list_store_set_value(Handle, native_iter, column, native_value);
			Marshal.FreeHGlobal (native_iter);
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_list_store_swap(IntPtr raw, IntPtr a, IntPtr b);

		public void Swap(Gtk.TreeIter a, Gtk.TreeIter b) {
			IntPtr native_a = GLib.Marshaller.StructureToPtrAlloc (a);
			IntPtr native_b = GLib.Marshaller.StructureToPtrAlloc (b);
			gtk_list_store_swap(Handle, native_a, native_b);
			Marshal.FreeHGlobal (native_a);
			Marshal.FreeHGlobal (native_b);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_foreach(IntPtr raw, GtkSharp.TreeModelForeachFuncNative func, IntPtr user_data);

		public void Foreach(Gtk.TreeModelForeachFunc func) {
			GtkSharp.TreeModelForeachFuncWrapper func_wrapper = new GtkSharp.TreeModelForeachFuncWrapper (func);
			gtk_tree_model_foreach(Handle, func_wrapper.NativeDelegate, IntPtr.Zero);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_model_get_column_type(IntPtr raw, int index_);

		public GLib.GType GetColumnType(int index_) {
			IntPtr raw_ret = gtk_tree_model_get_column_type(Handle, index_);
			GLib.GType ret = new GLib.GType(raw_ret);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tree_model_get_flags(IntPtr raw);

		public Gtk.TreeModelFlags Flags { 
			get {
				int raw_ret = gtk_tree_model_get_flags(Handle);
				Gtk.TreeModelFlags ret = (Gtk.TreeModelFlags) raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_get_iter(IntPtr raw, IntPtr iter, IntPtr path);

		public bool GetIter(out Gtk.TreeIter iter, Gtk.TreePath path) {
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			bool raw_ret = gtk_tree_model_get_iter(Handle, native_iter, path == null ? IntPtr.Zero : path.Handle);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_get_iter_first(IntPtr raw, IntPtr iter);

		public bool GetIterFirst(out Gtk.TreeIter iter) {
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			bool raw_ret = gtk_tree_model_get_iter_first(Handle, native_iter);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_get_iter_from_string(IntPtr raw, IntPtr iter, IntPtr path_string);

		public bool GetIterFromString(out Gtk.TreeIter iter, string path_string) {
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			IntPtr native_path_string = GLib.Marshaller.StringToPtrGStrdup (path_string);
			bool raw_ret = gtk_tree_model_get_iter_from_string(Handle, native_iter, native_path_string);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			GLib.Marshaller.Free (native_path_string);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tree_model_get_n_columns(IntPtr raw);

		public int NColumns { 
			get {
				int raw_ret = gtk_tree_model_get_n_columns(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_model_get_path(IntPtr raw, IntPtr iter);

		public Gtk.TreePath GetPath(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			IntPtr raw_ret = gtk_tree_model_get_path(Handle, native_iter);
			Gtk.TreePath ret = raw_ret == IntPtr.Zero ? null : (Gtk.TreePath) GLib.Opaque.GetOpaque (raw_ret, typeof (Gtk.TreePath), true);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gtk_tree_model_get_string_from_iter(IntPtr raw, IntPtr iter);

		public string GetStringFromIter(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			IntPtr raw_ret = gtk_tree_model_get_string_from_iter(Handle, native_iter);
			string ret = GLib.Marshaller.PtrToStringGFree(raw_ret);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_get_valist(IntPtr raw, IntPtr iter, IntPtr var_args);

		public void GetValist(Gtk.TreeIter iter, IntPtr var_args) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_get_valist(Handle, native_iter, var_args);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_get_value(IntPtr raw, IntPtr iter, int column, IntPtr value);

		public void GetValue(Gtk.TreeIter iter, int column, ref GLib.Value value) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			IntPtr native_value = GLib.Marshaller.StructureToPtrAlloc (value);
			gtk_tree_model_get_value(Handle, native_iter, column, native_value);
			Marshal.FreeHGlobal (native_iter);
			value = (GLib.Value) Marshal.PtrToStructure (native_value, typeof (GLib.Value));
			Marshal.FreeHGlobal (native_value);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_iter_children(IntPtr raw, IntPtr iter, IntPtr parent);

		public bool IterChildren(out Gtk.TreeIter iter, Gtk.TreeIter parent) {
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			IntPtr native_parent = GLib.Marshaller.StructureToPtrAlloc (parent);
			bool raw_ret = gtk_tree_model_iter_children(Handle, native_iter, native_parent);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			Marshal.FreeHGlobal (native_parent);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_iter_has_child(IntPtr raw, IntPtr iter);

		public bool IterHasChild(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool raw_ret = gtk_tree_model_iter_has_child(Handle, native_iter);
			bool ret = raw_ret;
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gtk_tree_model_iter_n_children(IntPtr raw, IntPtr iter);

		public int IterNChildren(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			int raw_ret = gtk_tree_model_iter_n_children(Handle, native_iter);
			int ret = raw_ret;
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_iter_next(IntPtr raw, IntPtr iter);

		public bool IterNext(ref Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool raw_ret = gtk_tree_model_iter_next(Handle, native_iter);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_iter_nth_child(IntPtr raw, IntPtr iter, IntPtr parent, int n);

		public bool IterNthChild(out Gtk.TreeIter iter, Gtk.TreeIter parent, int n) {
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			IntPtr native_parent = GLib.Marshaller.StructureToPtrAlloc (parent);
			bool raw_ret = gtk_tree_model_iter_nth_child(Handle, native_iter, native_parent, n);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			Marshal.FreeHGlobal (native_parent);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_iter_parent(IntPtr raw, IntPtr iter, IntPtr child);

		public bool IterParent(out Gtk.TreeIter iter, Gtk.TreeIter child) {
			IntPtr native_iter = Marshal.AllocHGlobal (Marshal.SizeOf (typeof (Gtk.TreeIter)));
			IntPtr native_child = GLib.Marshaller.StructureToPtrAlloc (child);
			bool raw_ret = gtk_tree_model_iter_parent(Handle, native_iter, native_child);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			Marshal.FreeHGlobal (native_child);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_model_iter_previous(IntPtr raw, IntPtr iter);

		public bool IterPrevious(ref Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			bool raw_ret = gtk_tree_model_iter_previous(Handle, native_iter);
			bool ret = raw_ret;
			iter = Gtk.TreeIter.New (native_iter);
			Marshal.FreeHGlobal (native_iter);
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_ref_node(IntPtr raw, IntPtr iter);

		public void RefNode(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_ref_node(Handle, native_iter);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_row_changed(IntPtr raw, IntPtr path, IntPtr iter);

		public void EmitRowChanged(Gtk.TreePath path, Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_row_changed(Handle, path == null ? IntPtr.Zero : path.Handle, native_iter);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_row_deleted(IntPtr raw, IntPtr path);

		public void EmitRowDeleted(Gtk.TreePath path) {
			gtk_tree_model_row_deleted(Handle, path == null ? IntPtr.Zero : path.Handle);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_row_has_child_toggled(IntPtr raw, IntPtr path, IntPtr iter);

		public void EmitRowHasChildToggled(Gtk.TreePath path, Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_row_has_child_toggled(Handle, path == null ? IntPtr.Zero : path.Handle, native_iter);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_row_inserted(IntPtr raw, IntPtr path, IntPtr iter);

		public void EmitRowInserted(Gtk.TreePath path, Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_row_inserted(Handle, path == null ? IntPtr.Zero : path.Handle, native_iter);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_rows_reordered(IntPtr raw, IntPtr path, IntPtr iter, int[] new_order);

		public void EmitRowsReordered(Gtk.TreePath path, Gtk.TreeIter iter, int[] new_order) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_rows_reordered(Handle, path == null ? IntPtr.Zero : path.Handle, native_iter, new_order);
			Marshal.FreeHGlobal (native_iter);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_rows_reordered_with_length(IntPtr raw, IntPtr path, IntPtr iter, out int new_order, int length);

		public int RowsReorderedWithLength(Gtk.TreePath path, Gtk.TreeIter iter, int length) {
			int new_order;
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_rows_reordered_with_length(Handle, path == null ? IntPtr.Zero : path.Handle, native_iter, out new_order, length);
			Marshal.FreeHGlobal (native_iter);
			return new_order;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_model_unref_node(IntPtr raw, IntPtr iter);

		public void UnrefNode(Gtk.TreeIter iter) {
			IntPtr native_iter = GLib.Marshaller.StructureToPtrAlloc (iter);
			gtk_tree_model_unref_node(Handle, native_iter);
			Marshal.FreeHGlobal (native_iter);
		}

		[GLib.Signal("row-changed")]
		public event Gtk.RowChangedHandler RowChanged {
			add {
				this.AddSignalHandler ("row-changed", value, typeof (Gtk.RowChangedArgs));
			}
			remove {
				this.RemoveSignalHandler ("row-changed", value);
			}
		}

		[GLib.Signal("row-has-child-toggled")]
		public event Gtk.RowHasChildToggledHandler RowHasChildToggled {
			add {
				this.AddSignalHandler ("row-has-child-toggled", value, typeof (Gtk.RowHasChildToggledArgs));
			}
			remove {
				this.RemoveSignalHandler ("row-has-child-toggled", value);
			}
		}

		[GLib.Signal("row-inserted")]
		public event Gtk.RowInsertedHandler RowInserted {
			add {
				this.AddSignalHandler ("row-inserted", value, typeof (Gtk.RowInsertedArgs));
			}
			remove {
				this.RemoveSignalHandler ("row-inserted", value);
			}
		}

		[GLib.Signal("row-deleted")]
		public event Gtk.RowDeletedHandler RowDeleted {
			add {
				this.AddSignalHandler ("row-deleted", value, typeof (Gtk.RowDeletedArgs));
			}
			remove {
				this.RemoveSignalHandler ("row-deleted", value);
			}
		}

		static RowChangedNativeDelegate RowChanged_cb_delegate;
		static RowChangedNativeDelegate RowChangedVMCallback {
			get {
				if (RowChanged_cb_delegate == null)
					RowChanged_cb_delegate = new RowChangedNativeDelegate (RowChanged_cb);
				return RowChanged_cb_delegate;
			}
		}

		static void OverrideRowChanged (GLib.GType gtype)
		{
			OverrideRowChanged (gtype, RowChangedVMCallback);
		}

		static void OverrideRowChanged (GLib.GType gtype, RowChangedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "row-changed", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RowChangedNativeDelegate (IntPtr inst, IntPtr path, IntPtr iter);

		static void RowChanged_cb (IntPtr inst, IntPtr path, IntPtr iter)
		{
			try {
				Gtk.ListStore __obj = GLib.Object.GetObject (inst, false) as Gtk.ListStore;
				__obj.OnRowChanged (path == IntPtr.Zero ? null : (Gtk.TreePath) GLib.Opaque.GetOpaque (path, typeof (Gtk.TreePath), false), Gtk.TreeIter.New (iter));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ListStore), ConnectionMethod="OverrideRowChanged")]
		protected virtual void OnRowChanged (Gtk.TreePath path, Gtk.TreeIter iter)
		{
			InternalRowChanged (path, iter);
		}

		private void InternalRowChanged (Gtk.TreePath path, Gtk.TreeIter iter)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (3);
			GLib.Value[] vals = new GLib.Value [3];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (path);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (iter);
			inst_and_params.Append (vals [2]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static RowInsertedNativeDelegate RowInserted_cb_delegate;
		static RowInsertedNativeDelegate RowInsertedVMCallback {
			get {
				if (RowInserted_cb_delegate == null)
					RowInserted_cb_delegate = new RowInsertedNativeDelegate (RowInserted_cb);
				return RowInserted_cb_delegate;
			}
		}

		static void OverrideRowInserted (GLib.GType gtype)
		{
			OverrideRowInserted (gtype, RowInsertedVMCallback);
		}

		static void OverrideRowInserted (GLib.GType gtype, RowInsertedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "row-inserted", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RowInsertedNativeDelegate (IntPtr inst, IntPtr path, IntPtr iter);

		static void RowInserted_cb (IntPtr inst, IntPtr path, IntPtr iter)
		{
			try {
				Gtk.ListStore __obj = GLib.Object.GetObject (inst, false) as Gtk.ListStore;
				__obj.OnRowInserted (path == IntPtr.Zero ? null : (Gtk.TreePath) GLib.Opaque.GetOpaque (path, typeof (Gtk.TreePath), false), Gtk.TreeIter.New (iter));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ListStore), ConnectionMethod="OverrideRowInserted")]
		protected virtual void OnRowInserted (Gtk.TreePath path, Gtk.TreeIter iter)
		{
			InternalRowInserted (path, iter);
		}

		private void InternalRowInserted (Gtk.TreePath path, Gtk.TreeIter iter)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (3);
			GLib.Value[] vals = new GLib.Value [3];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (path);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (iter);
			inst_and_params.Append (vals [2]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static RowHasChildToggledNativeDelegate RowHasChildToggled_cb_delegate;
		static RowHasChildToggledNativeDelegate RowHasChildToggledVMCallback {
			get {
				if (RowHasChildToggled_cb_delegate == null)
					RowHasChildToggled_cb_delegate = new RowHasChildToggledNativeDelegate (RowHasChildToggled_cb);
				return RowHasChildToggled_cb_delegate;
			}
		}

		static void OverrideRowHasChildToggled (GLib.GType gtype)
		{
			OverrideRowHasChildToggled (gtype, RowHasChildToggledVMCallback);
		}

		static void OverrideRowHasChildToggled (GLib.GType gtype, RowHasChildToggledNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "row-has-child-toggled", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RowHasChildToggledNativeDelegate (IntPtr inst, IntPtr path, IntPtr iter);

		static void RowHasChildToggled_cb (IntPtr inst, IntPtr path, IntPtr iter)
		{
			try {
				Gtk.ListStore __obj = GLib.Object.GetObject (inst, false) as Gtk.ListStore;
				__obj.OnRowHasChildToggled (path == IntPtr.Zero ? null : (Gtk.TreePath) GLib.Opaque.GetOpaque (path, typeof (Gtk.TreePath), false), Gtk.TreeIter.New (iter));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ListStore), ConnectionMethod="OverrideRowHasChildToggled")]
		protected virtual void OnRowHasChildToggled (Gtk.TreePath path, Gtk.TreeIter iter)
		{
			InternalRowHasChildToggled (path, iter);
		}

		private void InternalRowHasChildToggled (Gtk.TreePath path, Gtk.TreeIter iter)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (3);
			GLib.Value[] vals = new GLib.Value [3];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (path);
			inst_and_params.Append (vals [1]);
			vals [2] = new GLib.Value (iter);
			inst_and_params.Append (vals [2]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		static RowDeletedNativeDelegate RowDeleted_cb_delegate;
		static RowDeletedNativeDelegate RowDeletedVMCallback {
			get {
				if (RowDeleted_cb_delegate == null)
					RowDeleted_cb_delegate = new RowDeletedNativeDelegate (RowDeleted_cb);
				return RowDeleted_cb_delegate;
			}
		}

		static void OverrideRowDeleted (GLib.GType gtype)
		{
			OverrideRowDeleted (gtype, RowDeletedVMCallback);
		}

		static void OverrideRowDeleted (GLib.GType gtype, RowDeletedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "row-deleted", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void RowDeletedNativeDelegate (IntPtr inst, IntPtr path);

		static void RowDeleted_cb (IntPtr inst, IntPtr path)
		{
			try {
				Gtk.ListStore __obj = GLib.Object.GetObject (inst, false) as Gtk.ListStore;
				__obj.OnRowDeleted (path == IntPtr.Zero ? null : (Gtk.TreePath) GLib.Opaque.GetOpaque (path, typeof (Gtk.TreePath), false));
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ListStore), ConnectionMethod="OverrideRowDeleted")]
		protected virtual void OnRowDeleted (Gtk.TreePath path)
		{
			InternalRowDeleted (path);
		}

		private void InternalRowDeleted (Gtk.TreePath path)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (2);
			GLib.Value[] vals = new GLib.Value [2];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			vals [1] = new GLib.Value (path);
			inst_and_params.Append (vals [1]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_drag_source_drag_data_delete(IntPtr raw, IntPtr path);

		public bool DragDataDelete(Gtk.TreePath path) {
			bool raw_ret = gtk_tree_drag_source_drag_data_delete(Handle, path == null ? IntPtr.Zero : path.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_drag_source_drag_data_get(IntPtr raw, IntPtr path, IntPtr selection_data);

		public bool DragDataGet(Gtk.TreePath path, Gtk.SelectionData selection_data) {
			bool raw_ret = gtk_tree_drag_source_drag_data_get(Handle, path == null ? IntPtr.Zero : path.Handle, selection_data == null ? IntPtr.Zero : selection_data.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_drag_source_row_draggable(IntPtr raw, IntPtr path);

		public bool RowDraggable(Gtk.TreePath path) {
			bool raw_ret = gtk_tree_drag_source_row_draggable(Handle, path == null ? IntPtr.Zero : path.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_drag_dest_drag_data_received(IntPtr raw, IntPtr dest, IntPtr selection_data);

		public bool DragDataReceived(Gtk.TreePath dest, Gtk.SelectionData selection_data) {
			bool raw_ret = gtk_tree_drag_dest_drag_data_received(Handle, dest == null ? IntPtr.Zero : dest.Handle, selection_data == null ? IntPtr.Zero : selection_data.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_drag_dest_row_drop_possible(IntPtr raw, IntPtr dest_path, IntPtr selection_data);

		public bool RowDropPossible(Gtk.TreePath dest_path, Gtk.SelectionData selection_data) {
			bool raw_ret = gtk_tree_drag_dest_row_drop_possible(Handle, dest_path == null ? IntPtr.Zero : dest_path.Handle, selection_data == null ? IntPtr.Zero : selection_data.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_sortable_get_sort_column_id(IntPtr raw, out int sort_column_id, out int order);

		public bool GetSortColumnId(out int sort_column_id, out Gtk.SortType order) {
			int native_order;
			bool raw_ret = gtk_tree_sortable_get_sort_column_id(Handle, out sort_column_id, out native_order);
			bool ret = raw_ret;
			order = (Gtk.SortType) native_order;
			return ret;
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern bool gtk_tree_sortable_has_default_sort_func(IntPtr raw);

		public bool HasDefaultSortFunc { 
			get {
				bool raw_ret = gtk_tree_sortable_has_default_sort_func(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_sortable_set_default_sort_func(IntPtr raw, GtkSharp.TreeIterCompareFuncNative sort_func, IntPtr user_data, GLib.DestroyNotify destroy);

		public Gtk.TreeIterCompareFunc DefaultSortFunc { 
			set {
				GtkSharp.TreeIterCompareFuncWrapper value_wrapper = new GtkSharp.TreeIterCompareFuncWrapper (value);
				IntPtr user_data;
				GLib.DestroyNotify destroy;
				if (value == null) {
					user_data = IntPtr.Zero;
					destroy = null;
				} else {
					user_data = (IntPtr) GCHandle.Alloc (value_wrapper);
					destroy = GLib.DestroyHelper.NotifyHandler;
				}
				gtk_tree_sortable_set_default_sort_func(Handle, value_wrapper.NativeDelegate, user_data, destroy);
			}
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_sortable_set_sort_column_id(IntPtr raw, int sort_column_id, int order);

		public void SetSortColumnId(int sort_column_id, Gtk.SortType order) {
			gtk_tree_sortable_set_sort_column_id(Handle, sort_column_id, (int) order);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_sortable_set_sort_func(IntPtr raw, int sort_column_id, GtkSharp.TreeIterCompareFuncNative sort_func, IntPtr user_data, GLib.DestroyNotify destroy);

		public void SetSortFunc(int sort_column_id, Gtk.TreeIterCompareFunc sort_func) {
			GtkSharp.TreeIterCompareFuncWrapper sort_func_wrapper = new GtkSharp.TreeIterCompareFuncWrapper (sort_func);
			IntPtr user_data;
			GLib.DestroyNotify destroy;
			if (sort_func == null) {
				user_data = IntPtr.Zero;
				destroy = null;
			} else {
				user_data = (IntPtr) GCHandle.Alloc (sort_func_wrapper);
				destroy = GLib.DestroyHelper.NotifyHandler;
			}
			gtk_tree_sortable_set_sort_func(Handle, sort_column_id, sort_func_wrapper.NativeDelegate, user_data, destroy);
		}

		[DllImport("gtk-3-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gtk_tree_sortable_sort_column_changed(IntPtr raw);

		public void ChangeSortColumn() {
			gtk_tree_sortable_sort_column_changed(Handle);
		}

		[GLib.Signal("sort-column-changed")]
		public event System.EventHandler SortColumnChanged {
			add {
				this.AddSignalHandler ("sort-column-changed", value);
			}
			remove {
				this.RemoveSignalHandler ("sort-column-changed", value);
			}
		}

		static SortColumnChangedNativeDelegate SortColumnChanged_cb_delegate;
		static SortColumnChangedNativeDelegate SortColumnChangedVMCallback {
			get {
				if (SortColumnChanged_cb_delegate == null)
					SortColumnChanged_cb_delegate = new SortColumnChangedNativeDelegate (SortColumnChanged_cb);
				return SortColumnChanged_cb_delegate;
			}
		}

		static void OverrideSortColumnChanged (GLib.GType gtype)
		{
			OverrideSortColumnChanged (gtype, SortColumnChangedVMCallback);
		}

		static void OverrideSortColumnChanged (GLib.GType gtype, SortColumnChangedNativeDelegate callback)
		{
			OverrideVirtualMethod (gtype, "sort-column-changed", callback);
		}
		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void SortColumnChangedNativeDelegate (IntPtr inst);

		static void SortColumnChanged_cb (IntPtr inst)
		{
			try {
				Gtk.ListStore __obj = GLib.Object.GetObject (inst, false) as Gtk.ListStore;
				__obj.OnSortColumnChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		[GLib.DefaultSignalHandler(Type=typeof(Gtk.ListStore), ConnectionMethod="OverrideSortColumnChanged")]
		protected virtual void OnSortColumnChanged ()
		{
			InternalSortColumnChanged ();
		}

		private void InternalSortColumnChanged ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			GLib.Value[] vals = new GLib.Value [1];
			vals [0] = new GLib.Value (this);
			inst_and_params.Append (vals [0]);
			g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			foreach (GLib.Value v in vals)
				v.Dispose ();
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (new List<GLib.AbiField>{ 
						new GLib.AbiField("priv"
							, GLib.Object.abi_info.Fields
							, (uint) Marshal.SizeOf(typeof(IntPtr)) // priv
							, null
							, null
							, (uint) Marshal.SizeOf(typeof(IntPtr))
							, 0
							),
					});

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
