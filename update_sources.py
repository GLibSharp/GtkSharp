#!/usr/bin/env python3

import subprocess
import os
import sys
import shutil
import argparse

def accept_command(commands):
    """Search @commands and returns the first found absolute path."""
    for command in commands:
        command = shutil.which(command)
        if command:
            return command

    return None

if __name__ == "__main__":
    parser = argparse.ArgumentParser()
    parser.add_argument('args', nargs='+')
    options = parser.parse_args()
    ninja = accept_command(["ninja", "ninja-build"])
    buildroot = os.environ["MESON_BUILD_ROOT"]

    if 'gtk-sharp' in os.environ['MESON_SUBDIR']:
        subproject_prefix = 'gtk-sharp@@'
    else:
        subproject_prefix = ''

    for pkg in options.args:
        print("Update %s bindings" % pkg)
        subprocess.check_call([ninja, "-C", buildroot, subproject_prefix + "update_%s_code" % pkg])