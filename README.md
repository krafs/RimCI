# RimCI

This repository demonstrates a barebone, but fully functional, RimWorld mod being built using
**GitHub Actions** on **Windows**, **Ubuntu** and **MacOS**.

It currently has two workflows called **Build** and **Release**.

## Build

The basic **Build** workflow is defined in `.github/workflows/main.yml`. It builds on push and
pull_requests, but ignores changes to your `README.md` so you can modify it without triggering a
build. It also ignores git tags starting with "v", more on that later.

It uses a build matrix to build on **Windows**, **Ubuntu** and **MacOS** using `dotnet`. It is
heavily commented, so you should be able to figure out what's going on. There's also some commented
out steps to run tests using `dotnet test`, though we don't know how useful that will be without
Rimworld installed.

The **Build** workflow outputs a nice artifact with your compiled code.

## Release

The **Release** workflow is defined in `.github/workflows/release.yml` and was contributed by
[@RobRoseKnows](https://github.com/RobRoseKnows). It only runs on version tags (a `git tag`
starting with v) that the **Build** workflow is configured not to run on. 

It builds a single build on Ubuntu (which seems to be the fastest) and then zips it up for release
and then creates a draft release (by default) and uploads the zip file to it.

This badge displays the status of the last run:

[![](https://github.com/krafs/RimCI/workflows/Build/badge.svg)](https://github.com/krafs/RimCI/actions)
