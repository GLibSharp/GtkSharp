﻿using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace ${Namespace}
{
	class MainWindow : Window
	{
#pragma warning disable 0649
		[UI] private Label _label1;
		[UI] private Button _button1;
#pragma warning restore 0649

		private int _counter;

		public MainWindow() : this(new Builder("${Namespace}.MainWindow.glade")) { }

		private MainWindow(Builder builder) : base(builder.GetObject("MainWindow").Handle)
		{
			builder.Autoconnect(this);

			DeleteEvent += OnDeleteEvent;
			_button1.Clicked += Button1_Clicked;
		}

		private void OnDeleteEvent(object sender, DeleteEventArgs a)
		{
			Application.Quit();
		}

		private void Button1_Clicked(object sender, EventArgs a)
		{
			_counter++;
			_label1.Text = "Hello World! This button has been clicked " + _counter + " time(s).";
		}
	}
}
