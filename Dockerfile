FROM archlinux/archlinux:base-devel-20210627.0.27153

RUN pacman -Syy --noconfirm
RUN pacman -Syu --noconfirm
RUN pacman -S --noconfirm meson mono gtk3 git

ENV SOURCE_DIR="/source"

RUN mkdir -p "${SOURCE_DIR}"

COPY / "${SOURCE_DIR}"

CMD ["/source/.ci_build.sh"]
