assembly_name = 'cairo-sharp'

raw_api_fname = join_paths(meson.current_source_dir(), 'cairo-api.raw')
metadata_fname = join_paths(meson.current_source_dir(), 'cairo.metadata')

configure_file(input: assembly_name + '.dll.config.in',
        output: assembly_name + '.dll.config',
        configuration : remap_dl_data)

sources = [
    'Antialias.cs',
    'Cairo.cs',
    'CairoDebug.cs',
    'Color.cs',
    'Content.cs',
    'Context.cs',
    'Device.cs',
    'DirectFBSurface.cs',
    'Distance.cs',
    'Extend.cs',
    'FillRule.cs',
    'Filter.cs',
    'FontExtents.cs',
    'FontFace.cs',
    'FontOptions.cs',
    'FontSlant.cs',
    'FontType.cs',
    'FontWeight.cs',
    'Format.cs',
    'GlitzSurface.cs',
    'Glyph.cs',
    'Gradient.cs',
    'HintMetrics.cs',
    'HintStyle.cs',
    'ImageSurface.cs',
    'LinearGradient.cs',
    'LineCap.cs',
    'LineJoin.cs',
    'Matrix.cs',
    'NativeMethods.cs',
    'Operator.cs',
    'Path.cs',
    'Pattern.cs',
    'PatternType.cs',
    'PdfSurface.cs',
    'Point.cs',
    'PointD.cs',
    'PSSurface.cs',
    'RadialGradient.cs',
    'Rectangle.cs',
    'Region.cs',
    'ScaledFont.cs',
    'SolidPattern.cs',
    'Status.cs',
    'SubpixelOrder.cs',
    'Surface.cs',
    'SurfacePattern.cs',
    'SurfaceType.cs',
    'SvgSurface.cs',
    'SvgVersion.cs',
    'TextExtents.cs',
    'Win32Surface.cs',
    'XcbSurface.cs',
    'XlibSurface.cs',
]

cairo_sharp = shared_library(assembly_name, sources, assemblyinfo,
        install: install,
        install_dir: lib_install_dir
)

nuget_infos += [['CairoSharp', cairo_sharp, []]]
install_infos += [assembly_name, cairo_sharp.full_path()]
cairo_api_includes = join_paths(meson.current_source_dir(), 'cairo-api.xml')

if install
    install_data(cairo_api_includes, install_dir: gapi_xml_installdir)
endif

cairo_sharp_dep = declare_dependency(link_with: cairo_sharp)
