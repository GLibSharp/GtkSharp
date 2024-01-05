if host_machine.system() == 'windows'
  if host_machine.cpu() == 'amd64'
    add_project_arguments('-define:WIN64LONGS', language: 'cs')
  endif
endif


version = meson.project_version()
apiversion = '3.0.0.0'
mono_required_version = '>=3.2.0'
gtk_required_version='>=3.22.0'
glib_required_version='>=2.32.0'
gi_required_version='>=1.68.0'


csc = meson.get_compiler('cs')

runtime = ''
runtime_debug_flags = ''
if get_option('buildtype') == 'debug' or get_option('buildtype') == 'debugoptimized'
  runtime_debug_flags=' --debug'
endif

if csc.get_id() == 'mono'
    if not csc.version().version_compare(mono_required_version)
        error('Mono required version @0@ not found (@1@)'.format(
            mono_required_version, csc.version()))
    endif

    mono_runtime_dep = dependency('mono', required: false)
    if mono_runtime_dep.found()
        runtime = 'mono' + runtime_debug_flags
    endif

    add_project_arguments('-keyfile:' + join_paths(meson.current_source_dir(), 'gtk-sharp.snk'),
        language: ['cs'])
endif

install = get_option('install')
assemblyinfo='/AssemblyInfo.cs'

gacutil = find_program('gacutil', required: install)
diff = find_program('audit/test_abi.py')

glib_dep = dependency('glib-2.0', version: glib_required_version,
        fallback: ['glib', 'libglib_dep'])
gio_dep = dependency('gio-2.0', version: glib_required_version,
        fallback: ['glib', 'libgio_dep'])
gobject_dep = dependency('gobject-2.0', version : glib_required_version,
  fallback: ['glib', 'libgobject_dep'])
gi_dep = dependency('gobject-introspection-1.0', version: gi_required_version,
    fallback: ['gobject-introspection'])

# FIXME Check how to enabled debug flags (if at all needed).

# TODO monodoc

prefix = get_option('prefix')
assembly_data = configuration_data()
assembly_data.set('API_VERSION', apiversion)
assemblyinfo = configure_file(input: 'AssemblyInfo.cs.in', output: 'AssemblyInfo.cs', configuration : assembly_data)

version_props_data = configuration_data()
version_props_data.set('API_VERSION', version)
version_props_targets = configure_file(input: 'version.props.in', output: 'version.props', configuration : version_props_data)

policy_config = files('policy.config.in')
if host_machine.system() == 'darwin'
  lib_prefix=''
  lib_suffix='.dylib'
else
  lib_prefix='.so'
  lib_suffix=''
endif

remap_dl_data = configuration_data()
remap_dl_data.set('LIB_PREFIX', lib_prefix)
remap_dl_data.set('LIB_SUFFIX', lib_suffix)

pkg_version = meson.project_name() + '-3.0'
version_data = configuration_data()
version_data.set('VERSION', version)
version_data.set('PACKAGE_VERSION', pkg_version)

install_infos = []
lib_install_dir = join_paths(get_option('libdir'), 'mono', pkg_version)
pkg_install_dir = join_paths(get_option('libdir'), 'pkgconfig')
gapi_xml_installdir = join_paths(get_option('datadir'), 'gapi-3.0')

schema = join_paths(meson.current_source_dir(), 'gapi.xsd')


if host_machine.system() == 'windows'
    pathsep = ';'
else
    pathsep = ':'
endif
mono_path = ''
foreach d: [ 'glib',  'gio' ]
    mono_path += pathsep + join_paths(meson.current_build_dir(), d)
endforeach

dep_type = gi_dep.type_name()
if dep_type == 'internal'
    subprojdir = 'subprojects'
    glib_girdir = join_paths(meson.global_build_root(), subprojdir, 'gobject-introspection', 'gir')
    gio_girdir = glib_girdir
elif dep_type == 'pkgconfig'
    glib_girdir = gi_dep.get_variable(pkgconfig: 'girdir')
    gio_girdir = glib_girdir
endif

dotnet_pack = ['dotnet', 'pack', '--configuration', 'Release']

subdir('parser')
subdir('generator')
subdir('bindinator')
subdir('glib')
subdir('gio')

cairo_dep = dependency('cairo', required: get_option('cairo'))
if cairo_dep.found()
    mono_path += pathsep + join_paths(meson.current_build_dir(), 'cairo')
    subdir('cairo')
else
    message('Cairo not found, not building')
endif
cairo_gobject_dep = dependency('cairo-gobject', required: get_option('cairo'))

pango_dep = dependency('pango', required: get_option('pango'))
if pango_dep.found()
    mono_path += pathsep + join_paths(meson.current_build_dir(), 'pango')
    subdir('pango')
else
    message('Pango not found, not building')
endif

atk_dep = dependency('atk', required: get_option('atk'))
if atk_dep.found()
    mono_path += pathsep + join_paths(meson.current_build_dir(), 'atk')
    subdir('atk')
else
    message('Atk not found, not building')
endif

gdk_dep = dependency('gdk-3.0', version: gtk_required_version, required: get_option('gdk'))
if gdk_dep.found() and atk_dep.found() and pango_dep.found()
    mono_path += pathsep + join_paths(meson.current_build_dir(), 'gdk')
    subdir('gdk')
    has_gdk = true
else
    message('Gdk not found, not building')
    has_gdk = false
endif

gtk_dep = dependency('gtk+-3.0', version: gtk_required_version, required: get_option('gtk'))
if gtk_dep.found() and atk_dep.found() and pango_dep.found()
    mono_path += pathsep + join_paths(meson.current_build_dir(), 'gtk')
    subdir('gtk')
    subdir('sample/GtkDemo')
    subdir('sample/valtest')
    has_gtk = true
else
    has_gtk = false
    message('Gtk not found, not building')
endif

if install
    gacutil_install = join_paths(meson.current_source_dir(), 'gacutil_install.py')
    meson.add_install_script(gacutil_install, install_infos)
endif

subdir('tests')