#!/bin/bash

set -e

docker build -t gtk-sharp-arch .

docker run gtk-sharp-arch ${@}
