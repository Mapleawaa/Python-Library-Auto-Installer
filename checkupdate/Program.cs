using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Principal;
using System.Threading;
using Newtonsoft.Json;

/*     这是中文版本
    作者@Github_Mapleawaa
    仓库地址https://github.com/Mapleawaa/Python-Library-Auto-Installer
    作者博客地址Mepuru.info
    双语版已更新
    使用请务必遵守GPL3.0协议
    感谢Star和Issue*/
class Program
{
    static void Main()
    {
        if (!File.Exists("installer.json"))
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" 猫猫找不到预配置文件  请确保它存在于同一目录下喵");
            Console.WriteLine("");
            Console.WriteLine(" 按下任意键退出");
            Console.ReadKey();
            return;
        }

        var config = JsonConvert.DeserializeObject<Config>(File.ReadAllText("installer.json"));
        Console.WriteLine("");
        Console.WriteLine($" ᨐ ∫ 安装信息: {config.ScriptTitle}");
        Console.WriteLine($"作者: {config.ScriptUser}");
        Console.WriteLine($"猫猫将要安装的库: {string.Join("喵, ", config.DownFile)}喵~");
        Console.WriteLine(" ");

        Console.WriteLine("ฅ/ᐠ ‧w‧ ᐟ\\ฅ 猫猫正在检查的你pip是否已安装...");
        if (!CheckPipInstaller())
        {
            Console.WriteLine("/ᐠ ._. ᐟ\\ﾉ 猫猫没有找到PIP 并丢给你一个教程 去看看吧~");
            System.Diagnostics.Process.Start("https://www.runoob.com/w3cnote/python-pip-install-usage.html");
            Console.ReadLine();
            return;
        }
        Thread.Sleep(2000);
        Console.WriteLine("pip已安装正确了喵");
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine($" ");
        Thread.Sleep(200);
        Console.WriteLine("/ᐠ=ᆽ≠ ᐟ \\∫");
        Console.WriteLine($" ");
        Thread.Sleep(2000);
        Console.WriteLine("/ᐠ. ퟑ.ᐟ\\");
        Console.WriteLine($" ");
        Thread.Sleep(2000);
        Console.WriteLine("—ฅ/ᐠ. w .ᐟ\\ฅ —");
        Console.WriteLine($" ");
        Thread.Sleep(1000);
        /*只是不知道写点什么了 看点猫猫吧qwq*/
        Console.Clear();
        Console.Write(" /ᐠ｡‸｡ᐟ| 猫猫问你：要不要继续安装？(y/n): ");
        string choice = Console.ReadLine();
        Console.Clear();
        if (choice.ToLower() != "y")
        {
            Console.WriteLine("程序已经退出 感谢使用喵~  Thanks♪(･ω･)ﾉ");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("正在安装指定的的Python库...");
        foreach (var library in config.DownFile)
        {
            InstallLibrary(library);
        }
        Console.WriteLine("ฅ^•ﻌ•^ฅ 猫猫帮你把所有库已成功安装成功啦喵 ");
        Console.WriteLine("\\按下任意键退出程序喵 ");
        Console.ReadKey();
    }

    static bool CheckPipInstaller()
    {
        try
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "python",
                Arguments = "-m pip --version",//检查当前pip版本 进行判定
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            });
            return true;
        }
        catch
        {
            return false;
        }
    }

    static void InstallPip()
    {
        Process.Start(new ProcessStartInfo
        {
            FileName = "python",
            Arguments = "-m ensurepip --upgrade",
            UseShellExecute = false,
            RedirectStandardOutput = true,
            CreateNoWindow = true
        }).WaitForExit();
    }

    static void InstallLibrary(string library)
    {
        Console.WriteLine($"◟[˳_˳]ʌ˽ʌ   猫猫正在帮你安装  {library} 喵");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
        Process.Start(new ProcessStartInfo
        {
            FileName = "python",
            Arguments = $"-m pip install {library}",
            UseShellExecute = false,
            RedirectStandardOutput = true,
            CreateNoWindow = true
        }).WaitForExit();
        Console.Clear();
    }
}

class Config
{
    public string ScriptUser { get; set; } //定义JSON文件内容
    public string[] DownFile { get; set; }
    public object ScriptTitle { get; internal set; }
}
