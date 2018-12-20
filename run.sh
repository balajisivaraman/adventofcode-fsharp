#!/bin/bash

set -e

pushd src/App
    dotnet run "$@"
popd
