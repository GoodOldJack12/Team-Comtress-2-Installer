# Team-Comtress-2-Installer
An application that installs or updates [Team Comtress 2](https://github.com/mastercomfig/team-comtress-2)
**Confused? Click [here](#Install-guide)**
## Features
* Automatically downloading the latest TC2 release
* Installing TC2 in a directory that you choose
* Ability to start from scratch (clean mode)
* Remembers what configuration you used the last time
* CLI support

These features are available from two different executables:
## GUI installer
#### [Download](https://github.com/GoodOldJack12/Team-Comtress-2-Installer/releases/latest/download/TeamComtressInstaller.zip)
![gui](https://i.imgur.com/eDjrvW7.png)

#### Features
* Install directory picker 
* Detects if the chosen directories are valid
* You can choose to overwrite existing files
* Status of the install is shown

## CLI Installer
#### [Download](https://github.com/GoodOldJack12/Team-Comtress-2-Installer/releases/latest/download/TCInstaller_CLI.zip)
**This application is meant for people who know what they're doing**

With this command line tool you can automate your testserver's updates.
It will print out it's current status every time it changes, and will close when it's done.
![CLI](https://i.imgur.com/b0WmnvI.png)
#### Usage
```
TCInstaller_CLI.exe
  -c, --clean    (Default: false) Clean the target directory

  --tf2dir       Where the TF2 installation dir is located

  --tc2dir       Where TC2 should be installed.

  --help         Display this help screen.

  --version      Display version information
```
#### Configuration
The CLI uses the same [Configuration File](#Configuration-File) as the GUI installer does.
If ``--tf2dir`` and/or ``--tc2dir`` are not supplied, it will try to get them from the config file.

## Install guide
This is how you use the GUI installer:
1. [Download](https://github.com/GoodOldJack12/Team-Comtress-2-Installer/releases/latest/download/TeamComtressInstaller.zip) the installer and unzip it.
2. Put ``TeamComtressInstaller.exe`` on your Desktop
3. Double-click ``TeamComtressInstaller.exe``
4. Is the box 'TF2Path' green? If not:
    1. Click the select button on the right of the box
    2. Find where TF2 is installed and select that folder
5. Click the select box next to the ``TC2 Path`` textbox
6. Select the folder where you want Team Comtress to be installed
7. Click the ``Patch`` button
8. Go to the folder you selected in step 6
9. Click start_tf2.bat

## Configuration File
The configuration file for TCInstaller is in ``Documents/TCUpdater/config.yml``.
This file will be used as the default for the GUI and the CLI tools.

## Platform compatibilty
TCInstaller uses .NET Core, so it is technically platform independent. However, the releases only contain binaries for 64bit Windows.
