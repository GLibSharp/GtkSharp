#!/bin/sh

srcdir=`dirname $0`
test -z "$srcdir" && srcdir=.

DIE=0

(autoconf --version) < /dev/null > /dev/null 2>&1 || {
  echo
  echo "**Error**: You must have \`autoconf' installed to compile Gtk#."
  echo "Download the appropriate package for your distribution,"
  echo "or get the source tarball at ftp://ftp.gnu.org/pub/gnu/"
  DIE=1
}

if [ -z "$LIBTOOL" ]; then
  LIBTOOL=`which glibtool 2>/dev/null` 
  if [ ! -x "$LIBTOOL" ]; then
    LIBTOOL=`which libtool`
  fi
fi

(grep "^AM_PROG_LIBTOOL" $srcdir/configure.ac >/dev/null) && {
  ($LIBTOOL --version) < /dev/null > /dev/null 2>&1 || {
    echo
    echo "**Error**: You must have \`libtool' installed to compile Gtk#."
    echo "Get ftp://ftp.gnu.org/pub/gnu/libtool-1.2d.tar.gz"
    echo "(or a newer version if it is available)"
    DIE=1
  }
}

(automake --version) < /dev/null > /dev/null 2>&1 || {
  echo
  echo "**Error**: You must have \`automake' installed to compile Gtk#."
  echo "Get ftp://ftp.gnu.org/pub/gnu/automake-1.3.tar.gz"
  echo "(or a newer version if it is available)"
  DIE=1
  NO_AUTOMAKE=yes
}


# if no automake, don't bother testing for aclocal
test -n "$NO_AUTOMAKE" || (aclocal --version) < /dev/null > /dev/null 2>&1 || {
  echo
  echo "**Error**: Missing \`aclocal'.  The version of \`automake'"
  echo "installed doesn't appear recent enough."
  echo "Get ftp://ftp.gnu.org/pub/gnu/automake-1.3.tar.gz"
  echo "(or a newer version if it is available)"
  DIE=1
}

if test "$DIE" -eq 1; then
  exit 1
fi

if test -z "$*"; then
  echo "**Warning**: I am going to run \`configure' with no arguments."
  echo "If you wish to pass any to it, please specify them on the"
  echo \`$0\'" command line."
  echo
fi

case $CC in
xlc )
  am_opt=--include-deps;;
esac


LIBTOOLIZE=${LIBTOOLIZE:-libtoolize}

if grep "^AM_PROG_LIBTOOL" configure.ac >/dev/null; then
  if test -z "$NO_LIBTOOLIZE" ; then 
    echo "Running $LIBTOOLIZE..."
    $LIBTOOLIZE --force --copy --quiet
  fi
fi

echo "Running aclocal $ACLOCAL_FLAGS ..."
aclocal $ACLOCAL_FLAGS || {
  echo
  echo "**Error**: aclocal failed. This may mean that you have not"
  echo "installed all of the packages you need, or you may need to"
  echo "set ACLOCAL_FLAGS to include \"-I \$prefix/share/aclocal\""
  echo "for the prefix where you installed the packages whose"
  echo "macros were not found"
  exit 1
}

if grep "^AC_CONFIG_HEADERS" configure.ac >/dev/null; then
  echo "Running autoheader..."
  autoheader || { echo "**Error**: autoheader failed."; exit 1; }
fi

echo "Running automake --foreign $am_opt ..."
automake --add-missing --foreign $am_opt ||
  { echo "**Error**: automake failed."; exit 1; }
echo "Running autoconf ..."
autoconf || { echo "**Error**: autoconf failed."; exit 1; }


conf_flags="--enable-maintainer-mode"

if test x$NOCONFIGURE = x; then
  echo Running $srcdir/configure $conf_flags "$@" ...
  $srcdir/configure $conf_flags "$@" \
  && echo Now type \`make\' to compile gtk-sharp || exit 1
else
  echo Skipping configure process.
fi
