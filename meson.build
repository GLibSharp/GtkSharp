project('GtkSharp', ['cs', 'c'], version: '3.22.0',
        meson_version: '>=0.58')

pkgs = []
subdir('Source')

run_target('update-code', command: [find_program('update_sources.py')] + pkgs)