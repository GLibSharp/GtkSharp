pkg = 'regress'
assembly_name = pkg + '-sharp'
symbols = ''

raw_api_fname = join_paths(meson.current_source_dir(), assembly_name + '-api.xml')
metadata_fname = ''

regress_deps = []
regress_c_args = ['-D_GI_DISABLE_CAIRO']

regress_lib = shared_library('regress-1.0',
  sources: ['regress.c', 'annotation.c', 'foo.c', 'drawable.c', 'utility.c'],
  include_directories : [include_directories('.')],
  c_args: regress_c_args,
  dependencies: [gobject_dep, gio_dep] + regress_deps,
)

if bindinator.get_variable('found')
  girs_dir = join_paths(meson.current_source_dir(), 'girs')
  env = environment()
  env.append('GI_TYPELIB_PATH', meson.current_source_dir())
  run_target('bindinate_regress',
      command: [bindinate,
          '--name=regress',
          '--regenerate=true',
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
            '--files', ';'.join(generated_sources),
            '--assembly-name', assembly_name,
            '--abi-includes', 'regress.h',
            '--abi-cs-usings', 'Regress,GLib',
        ],
        depends: [gapi_codegen, gapi_fixup],
    )