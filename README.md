[![MIT License](http://img.shields.io/badge/license-MIT-blue.svg?style=flat)](https://github.com/Hamumayo55/Sukuramukun/blob/master/LICENSE)  

# 猫猫Python 库自动安装程序

[![product_name](https://raw.githubusercontent.com/Mapleawaa/Python-Library-Auto-Installer/Dev/enlogo.png)

# Python 库自动安装程序

**[English](README-EN.MD)|[中文(简体)](README.MD)**

本项目为完全不懂Python但是想要使用Python开发的项目的用户的开发者准备

也是我为了更快速的给同学电脑装开发环境的最轻松的方法

（这个程序使用.NET开发，适配大多数用户的电脑而无需安装多余的框架）

可以一键安装所有需要安装的支持库，减轻售后负担。

本程序为高中生初学者开发，有不足请Issues或者自行修改

## 如何使用    

1. 确保预配置文件 `installer.json` 存在于同一目录下。（如何编辑请往下看）
2. 运行程序。
3. Enjoy

## 配置预配置文件

首先你需要有一个编辑器，例如[microsoft/vscode: Visual Studio Code (github.com)](https://github.com/microsoft/vscode) 甚至是记事本

1. 下载源代码https://codeload.github.com/Mapleawaa/Python-Library-Auto-Installer/zip/refs/heads/main

2. 使用你的编辑器打开文件夹内的 `installer.json` 

3. 文件夹内的内容为如下内容

   ```
   {
       "ScriptTitle": "",
       "ScriptUser": "",
       "DownFile": ["", ""]
   }
   ```

4. 你需要依次编辑

   ```
   {
       "ScriptTitle": "脚本名称",
       "ScriptUser": "作者",
       "DownFile": ["安装的模块1","安装的模块2","安装的模块3"]
   }
   
   
   ```

5. 保存在和EXE同一目录下

6. 记得保存记得保存记得保存！！



## 体验视频

https://space.bilibili.com/3546587699612129

应该咕咕咕掉了（不是

## 许可证

### GNU GENERAL PUBLIC LICENSE V3

GPL-V3
