import os
import sys
import urllib.request

BASE_URL_TPL="https://gitlab.gnome.org/GNOME/gobject-introspection/-/raw/main/tests/"
URL_TPL = BASE_URL_TPL + "{0}/{1}?inline=false"

def download_file(filename, out_dir, out_filename=None, url_subdir="scanner"):
    if out_filename is None:
        out_filename = filename
    url = URL_TPL.format(url_subdir, filename)
    print(f"Downloading file {url} ")
    urllib.request.urlretrieve(url,
        os.path.join(out_dir, out_filename))


def sync(out_dir):

    download_file("annotation.c", out_dir)
    download_file("annotation.h", out_dir)
    download_file("drawable.c", out_dir)
    download_file("drawable.h", out_dir)
    download_file("foo.c", out_dir)
    download_file("foo.h", out_dir)
    download_file("regress.c", out_dir)
    download_file("regress.h", out_dir)
    download_file("utility.c", out_dir)
    download_file("utility.h", out_dir)
    download_file("Regress-1.0-expected.gir", out_dir, "Regress-1.0.gir")
    download_file("gitestmacros.h", out_dir, url_subdir='')

if __name__ == "__main__":
    sync(os.path.dirname(__file__))