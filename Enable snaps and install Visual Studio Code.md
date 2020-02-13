
# Enable snaps and install Visual Studio Code

Snaps are applications packaged with all their dependencies to run on all popular Linux distributions from a single build. They update automatically and roll back gracefully.

Snaps are discoverable and installable from the Snap Store(https://snapcraft.io/store), an app store with an audience of millions.


## Enable snapd
Snap is available for Linux Mint 18.2 (Sonya), Linux Mint 18.3 (Sylvia), and the latest releases, Linux Mint 19 (Tara), Linux Mint 19.1 (Tessa), Linux Mint 19.2 (Tina) and Linux Mint 19.3 (Tricia). You can find out which version of Linux Mint you’re running by opening System info from the Preferences menu. To install snap from the Software Manager application, search for snapd and click Install.

## Alternatively, snapd can be installed from the command line:
,,,bash
sudo apt update
sudo apt install snapd
,,,

Either restart your machine, or log out and in again, to complete the installation.

## Install Visual Studio Code
To install Visual Studio Code, simply use the following command:
,,,bash
sudo snap install code --classic
,,,


