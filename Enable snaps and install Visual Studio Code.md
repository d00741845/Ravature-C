
# Enable snaps / Install Visual Studio Code / Install .NET Core SDK

Snaps are applications packaged with all their dependencies to run on all popular Linux distributions from a single build. They update automatically and roll back gracefully.

Snaps are discoverable and installable from the Snap Store(https://snapcraft.io/store), an app store with an audience of millions.


## Enable snapd
Snap is available for Linux Mint 18.2 (Sonya), Linux Mint 18.3 (Sylvia), and the latest releases, Linux Mint 19 (Tara), Linux Mint 19.1 (Tessa), Linux Mint 19.2 (Tina) and Linux Mint 19.3 (Tricia). You can find out which version of Linux Mint you’re running by opening System info from the Preferences menu. To install snap from the Software Manager application, search for snapd and click Install.

## Alternatively, snapd can be installed from the command line:
```bash
sudo apt update
sudo apt install snapd
```
Reboot to complete the installation.



## Install Visual Studio Code
Install Visual Studio Code:
```bash
sudo snap install code --classic
```


# Register Microsoft key and Needed before installing .NET:
  1. Register the Microsoft key.
  2. Register the product repository.
  3. Install required dependencies.
  ** This only needs to be done once per machine.
Run:
```bash
wget -q https://packages.microsoft.com/config/ubuntu/19.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
```

## Install the .NET Core SDK
Update & Install the .NET Core SDK: 

```bash
sudo apt-get update
sudo apt-get install apt-transport-https
sudo apt-get update
sudo apt-get install dotnet-sdk-3.1
```
If error message see the troubleshoot:
https://docs.microsoft.com/en-us/dotnet/core/install/linux-package-manager-ubuntu-1904#troubleshoot-the-package-manager


## Install the ASP.NET Core runtime
Update the products available for installation, then install the ASP.NET Core runtime. In your terminal, run the following commands.

```bash
sudo apt-get update
sudo apt-get install apt-transport-https
sudo apt-get update
sudo apt-get install aspnetcore-runtime-3.1
```
If error message:
https://docs.microsoft.com/en-us/dotnet/core/install/linux-package-manager-ubuntu-1904#troubleshoot-the-package-manager


# Install the .NET Core runtime
Update the products available for installation, then install the .NET Core runtime. In your terminal, run the following commands.
```bash
sudo apt-get update
sudo apt-get install apt-transport-https
sudo apt-get update
sudo apt-get install dotnet-runtime-3.1
```
If error message troubleshoot:
https://docs.microsoft.com/en-us/dotnet/core/install/linux-package-manager-ubuntu-1904#troubleshoot-the-package-manager

# How to install other versions
The packages added to the package manager feeds are named in a hackable format: 
{product}-{type}-{version}.

  product
  The type of .NET product to install. Valid options are:
    dotnet
    aspnetcore
  type
  Chooses the SDK or the runtime. Valid options are:
    sdk
    runtime
  version
  The version of the SDK or runtime to install. 
  This article will always give the instructions for the latest supported version. 
  Valid options are any released version, such as:
    3.0
    2.2
    2.1
  Examples
    Install the .NET Core 2.2 SDK: dotnet-sdk-2.2
    Install the ASP.NET Core 3.1 runtime: aspnetcore-runtime-3.1
    Install the .NET Core 2.1 runtime: dotnet-runtime-2.1
