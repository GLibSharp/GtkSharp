using System;
using Gtk;
using Cairo;

class CairoSample : DrawingArea
{
	static void Main ()
	{
		Application.Init ();
		Window win = new Window ("Cairo with Gtk# 3");
		win.SetDefaultSize (400, 400);
		win.DeleteEvent += delegate { Application.Quit (); };
		win.Add (new CairoSample ());
		win.ShowAll ();
		Application.Run ();
	}

	void OvalPath (Context cr, double xc, double yc, double xr, double yr)
	{
		Matrix m = cr.Matrix;

		cr.Translate (xc, yc);
		cr.Scale (1.0, yr / xr);
		cr.MoveTo (xr, 0.0);
		cr.Arc (0, 0, xr, 0, 2 * Math.PI);
		cr.ClosePath ();

		cr.Matrix = m;
	}

	void FillChecks (Context cr, int x, int y, int width, int height)
	{
		int CHECK_SIZE = 32;
		
		cr.Save ();
		Surface check;
		using (var target = cr.GetTarget ()) {
			check = target.CreateSimilar (Content.Color, 2 * CHECK_SIZE, 2 * CHECK_SIZE);
		}
		
		// draw the check
		using (Context cr2 = new Context (check)) {
			cr2.Operator = Operator.Source;
			cr2.SetSourceRGB (0.4, 0.4, 0.4);
			cr2.Rectangle (0, 0, 2 * CHECK_SIZE, 2 * CHECK_SIZE);
			cr2.Fill ();

			cr2.SetSourceRGB (0.7, 0.7, 0.7);
			cr2.Rectangle (x, y, CHECK_SIZE, CHECK_SIZE);
			cr2.Fill ();

			cr2.Rectangle (x + CHECK_SIZE, y + CHECK_SIZE, CHECK_SIZE, CHECK_SIZE);
			cr2.Fill ();
		}

		// Fill the whole surface with the check
		SurfacePattern check_pattern = new SurfacePattern (check);
		check_pattern.Extend = Extend.Repeat;
		cr.SetSource (check_pattern);
		cr.Rectangle (0, 0, width, height);
		cr.Fill ();

		check_pattern.Dispose ();
		check.Dispose ();
		cr.Restore ();
	}

	void Draw3Circles (Context cr, int xc, int yc, double radius, double alpha)
	{
		double subradius = radius * (2 / 3.0 - 0.1);

		cr.SetSourceRGBA (1.0, 0.0, 0.0, alpha);
		OvalPath (cr, xc + radius / 3.0 * Math.Cos (Math.PI * 0.5), yc - radius / 3.0 * Math.Sin (Math.PI * 0.5), subradius, subradius);
		cr.Fill ();

		cr.SetSourceRGBA (0.0, 1.0, 0.0, alpha);
		OvalPath (cr, xc + radius / 3.0 * Math.Cos (Math.PI * (0.5 + 2 / 0.3)), yc - radius / 3.0 * Math.Sin (Math.PI * (0.5 + 2 / 0.3)), subradius, subradius);
		cr.Fill ();

		cr.SetSourceRGBA (0.0, 0.0, 1.0, alpha);
		OvalPath (cr, xc + radius / 3.0 * Math.Cos (Math.PI * (0.5 + 4 / 0.3)), yc - radius / 3.0 * Math.Sin (Math.PI * (0.5 + 4 / 0.3)), subradius, subradius);
		cr.Fill ();
	}

	void Draw (Context cr, int width, int height)
	{
		double radius = 0.5 * Math.Min (width, height) - 10;
		int xc = width / 2;
		int yc = height / 2;

		Surface overlay, punch, circles;
		using (var target = cr.GetTarget ()) {
			overlay = target.CreateSimilar (Content.ColorAlpha, width, height);
			punch   = target.CreateSimilar (Content.Alpha, width, height);
			circles = target.CreateSimilar (Content.ColorAlpha, width, height);
		}

		FillChecks (cr, 0, 0, width, height);
		cr.Save ();

		// Draw a black circle on the overlay
		using (Context cr_overlay = new Context (overlay)) {
			cr_overlay.SetSourceRGB (0.0, 0.0, 0.0);
			OvalPath (cr_overlay, xc, yc, radius, radius);
			cr_overlay.Fill ();

			// Draw 3 circles to the punch surface, then cut
			// that out of the main circle in the overlay
			using (Context cr_tmp = new Context (punch))
				Draw3Circles (cr_tmp, xc, yc, radius, 1.0);

			cr_overlay.Operator = Operator.DestOut;
			cr_overlay.SetSourceSurface (punch, 0, 0);
			cr_overlay.Paint ();

			// Now draw the 3 circles in a subgroup again
			// at half intensity, and use OperatorAdd to join up
			// without seams.
			using (Context cr_circles = new Context (circles)) {
				cr_circles.Operator = Operator.Over;
				Draw3Circles (cr_circles, xc, yc, radius, 0.5);
			}

			cr_overlay.Operator = Operator.Add;
			cr_overlay.SetSourceSurface (circles, 0, 0);
			cr_overlay.Paint ();
		}

		cr.SetSourceSurface (overlay, 0, 0);
		cr.Paint ();

		overlay.Dispose ();
		punch.Dispose ();
		circles.Dispose ();
	}

	protected override bool OnDrawn (Cairo.Context ctx)
	{
		Draw (ctx, AllocatedWidth, AllocatedHeight);
		return true;
	}
}

