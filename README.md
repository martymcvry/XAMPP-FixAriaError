# XAMPP-FixAriaError

## Why does this program exist?

Recently, errors started occuring with the MariaDB-application in XAMPP. The error log shows the following:

```text
[ERROR] mysqld.exe: Aria recovery failed. Please run aria_chk -r on all Aria tables and delete all aria_log.######## files
[ERROR] Plugin 'Aria' init function returned error.
[ERROR] Plugin 'Aria' registration as a STORAGE ENGINE failed.
```

MariaDB would not start.


## Installation

The installation can be initiated through the website [https://software.mverstraelen.be/XAMPPFix/](https://software.mverstraelen.be/XAMPPFix/).  
Click the "Install"-button to download the application setup-file.

## Usage

**WARNING**: Only use this program if and when the Aria-error occurs!

Upon launch, the program will first check for updates. After that, the program will try to find the location where XAMPP is installed, either through its own registry key (created once the installation has been found), or through the registry key created by installing XAMPP. If both searches fail, the user will have to point to the location where XAMPP is installed.

When clicking the "Repareer de Aria-fout"-button, the program will check if the `mysql\data`-directory exists and delete the necessary files.

The program closes automatically.

After that, try to start the MariaDB-instance.
