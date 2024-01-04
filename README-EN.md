[![MIT License](http://img.shields.io/badge/license-MIT-blue.svg?style=flat)](https://github.com/Hamumayo55/Sukuramukun/blob/master/LICENSE )

# Maomao Python library automatic installation program

[![product_name](https://raw.githubusercontent.com/Mapleawaa/Python-Library-Auto-Installer/Dev/enlogo.png)

# Python library automatic installer

**[English](https://github.com/Mapleawaa/Python-Library-Auto-Installer-EN)|[Chinese (Simplified)](https://github.com/Mapleawaa/Python-Library-Auto- Installer)**

This project is prepared for developers who do not know Python at all but want to use Python to develop projects.

It is also the easiest way for me to install a development environment on my classmates’ computers more quickly.

(This program is developed using .NET and is suitable for most users’ computers without installing extra frameworks)

All support libraries that need to be installed can be installed with one click, reducing the after-sales burden.

This program is developed for high school students and beginners. If there are any deficiencies, please issue an Issue or modify it yourself.

## how to use    

1. Make sure the preconfiguration file `installer.json` exists in the same directory. (Please read below for how to edit)
2. Run the program.
3. Enjoy

## Configure preconfiguration file

First you need to have an editor, such as [microsoft/vscode: Visual Studio Code (github.com)](https://github.com/microsoft/vscode) or even Notepad

1. Download the source code https://codeload.github.com/Mapleawaa/Python-Library-Auto-Installer/zip/refs/heads/main

2. Use your editor to open `installer.json` in the folder

3. The contents of the folder are as follows

    ```
    {
        "ScriptTitle": "",
        "ScriptUser": "",
        "DownFile": ["", ""]
    }
    ```

4. You need to edit in sequence

    ```
    {
        "ScriptTitle": "Script name",
        "ScriptUser": "Author",
        "DownFile": ["Installed module 1", "Installed module 2", "Installed module 3"]
    }
   
   
    ```

5. Save in the same directory as EXE

6. Remember to save, remember to save, remember to save! !



## Experience video

https://space.bilibili.com/3546587699612129

It should have dropped (no)

## License

### GNU GENERAL PUBLIC LICENSE V3

GPL-V3
