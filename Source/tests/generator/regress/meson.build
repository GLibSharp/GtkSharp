pkg = 'regress'
assembly_name = pkg + '-sharp'
symbols = ''

raw_api_fname = join_paths(meson.current_source_dir(), assembly_name + '-api.xml')
metadata_fname = ''

custom_c_args = []
#if cc.get_id() != 'msvc'
#  custom_c_args = cc.get_supported_arguments([
#    '-Wno-unused-parameter',
#  ])
#endif

regress_deps = [gobject_dep, gio_dep]
if cairo_dep.found() and cairo_gobject_dep.found()
  regress_deps += [cairo_dep, cairo_gobject_dep]
  regress_c_args = []
else
  regress_c_args = ['-D_GI_DISABLE_CAIRO']
endif


utility_sources = ['utility.c']
utility_headers = ['utility.h']

utility_sources = ['utility.c', 'utility.h']
utility_deps = []
utility_lib = shared_library('utility-1.0',
  sources: utility_sources,
  include_directories : [include_directories('.')],
  c_args: custom_c_args,
  dependencies: [gobject_dep],
)

regress_sources = ['regress.c', 'annotation.c', 'foo.c', 'drawable.c', 'misc.c']
regress_headers = ['regress.h', 'annotation.h', 'foo.h', 'drawable.h', 'misc.h']

regress_lib = shared_library('regress-1.0',
  sources: regress_sources + utility_sources,
  include_directories : [include_directories('.')],
  link_with: utility_lib,
  c_args: regress_c_args + custom_c_args,
  dependencies: regress_deps,
)

search_dirs = [meson.current_build_dir()]
foreach dep: regress_deps
  dep_type = dep.type_name()
  if dep_type == 'pkgconfig'
    search_dirs += dep.get_variable(pkgconfig: 'libdir')
  elif dep_type == 'internal'
    if not search_dirs.contains(meson.global_build_root())
      search_dirs += meson.global_build_root()
    endif
  endif
endforeach

search_dirs_data = configuration_data()
search_dirs_data.set('SEARCH_DIRS', ';'.join(search_dirs))
configure_file(input: 'SearchDirs.cs.in', output: 'SearchDirs.cs', configuration : search_dirs_data)

gnome = import('gnome')
utility_gir = gnome.generate_gir(
  utility_lib,
  sources: utility_sources + utility_headers,
  namespace: 'Utility',
  nsversion: '1.0',
  identifier_prefix: 'Utility',
  symbol_prefix: 'utility',
  export_packages: 'utility',
  dependencies: utility_deps,
  includes: ['GLib-2.0'],
  header: 'utility.h',
  install: true,
  extra_args: custom_c_args,
)

regress_gir = gnome.generate_gir(
  regress_lib,
  sources: regress_sources + regress_headers,
  namespace: 'Regress',
  nsversion: '1.0',
  identifier_prefix: 'Regress',
  symbol_prefix: 'regress',
  export_packages: 'regress',
  dependencies: regress_deps,
  includes: ['GLib-2.0', 'Gio-2.0', 'cairo-1.0', utility_gir[0]],
  header: 'regress.h',
  install: false,
  extra_args: custom_c_args + regress_c_args,
)

girs_dir = join_paths(meson.current_build_dir())
env = environment()
env.append('GI_TYPELIB_PATH', girs_dir)
if bindinate_found
  run_target('bindinate_regress',
      command: [bindinate,
          '--name=regress',
          '--regenerate=true',
          '--regenerate-raw=' + raw_api_fname,
          '--gir=Regress-1.0',
          '--out=' + meson.current_source_dir()
      ],
      env: env,
      depends: []
  )
endif

run_target('update_code_regress',
        command: [
            generate_api,
            '--api-raw', raw_api_fname,
            '--gapi-fixup', gapi_fixup.full_path(),
            '--metadata', metadata_fname,
            '--gapi-codegen', gapi_codegen.full_path(),
            '--extra-includes', glib_api_includes,
            '--out', join_paths(meson.current_source_dir(), 'generated'),
            '--skip-files-check',
            '--assembly-name', assembly_name,
            '--abi-includes', 'regress.h',
            '--abi-cs-usings', 'Regress,GLib',
        ],
        depends: [gapi_codegen, gapi_fixup],
    )