using System.Diagnostics.Metrics;
using System.Drawing;
using System.Net.Sockets;
using System.Security.AccessControl;

Start:
Console.Clear();
Console.WriteLine("Do you want to Scan common ports or scan a port Manually.");
Console.WriteLine("Scan Common Ports [1]");
Console.WriteLine("Scan Ports Manually[2]");
string gt = Console.ReadLine();

if(gt == "1")
{
    goto CommonAce;
}


if (gt == "2")
{
    goto Manually;
}

else
{
    Console.WriteLine("Invalid Input?");
    Console.ReadLine();
    goto Start;
}

Manually:

Console.WriteLine("IP:");
string ip2 = Console.ReadLine();

Console.WriteLine("Port to Scan:");
string portstr = Console.ReadLine();
int port = Int32.Parse(portstr);

using (TcpClient Scan = new TcpClient())
{
    try
    {
        Scan.Connect(ip2, port);
        Console.WriteLine($"[{port}] | OPEN", Color.Green);
    }
    catch
    {
        Console.WriteLine($"[{port}] | CLOSED", Color.Red);
    }
}

Console.ReadLine();
goto Start;


CommonAce:

Console.WriteLine("IP To Scan:");
string ip = Console.ReadLine();
Console.WriteLine("This may take some time DO NOT spam enter");
Console.WriteLine("Press Enter To Scan Common Ports...");
Console.ReadLine();



int a = 8080;
int b = 443;
int c = 80;
int d = 20;
int e = 21;
int f = 22;
int g = 25;
int h = 53;
int i = 123;
int j = 179;
int k = 500;
int l = 3389;





using (TcpClient Scan = new TcpClient())
{
        try
        {
            Scan.Connect(ip, a);
            Console.WriteLine($"[{a}] | OPEN", Color.Green);
        }
        catch
        {
            Console.WriteLine($"[{a}] | CLOSED", Color.Red);
        }
        try
        {
            Scan.Connect(ip, b);
            Console.WriteLine($"[{b}] | OPEN", Color.Green);
        }
        catch
        {
            Console.WriteLine($"[{b}] | CLOSED", Color.Red);
        }

    try
    {
        Scan.Connect(ip, c);
        Console.WriteLine($"[{c}] | OPEN", Color.Green);
    }
    catch
    {
        Console.WriteLine($"[{c}] | CLOSED", Color.Red);
    }
    
    try
    {
        Scan.Connect(ip, d);
        Console.WriteLine($"[{d}] | OPEN", Color.Green);
    }
    catch
    {
        Console.WriteLine($"[{d}] | CLOSED", Color.Red);
    }

    try
    {
        Scan.Connect(ip, e);
        Console.WriteLine($"[{e}] | OPEN", Color.Green);
    }
    catch
    {
        Console.WriteLine($"[{e}] | CLOSED", Color.Red);
    }

    try
    {
        Scan.Connect(ip, f);
        Console.WriteLine($"[{f}] | OPEN", Color.Green);
    }
    catch
    {
        Console.WriteLine($"[{f}] | CLOSED", Color.Red);
    }

    try
    {
        Scan.Connect(ip, g);
        Console.WriteLine($"[{g}] | OPEN", Color.Green);
    }
    catch
    {
        Console.WriteLine($"[{g}] | CLOSED", Color.Red);
    }

    try
    {
        Scan.Connect(ip, h);
        Console.WriteLine($"[{h}] | OPEN", Color.Green);
    }
    catch
    {
        Console.WriteLine($"[{h}] | CLOSED", Color.Red);
    }
    try
    {
        Scan.Connect(ip, i);
        Console.WriteLine($"[{i}] | OPEN", Color.Green);
    }
    catch
    {
        Console.WriteLine($"[{i}] | CLOSED", Color.Red);
    }
    try
    {
        Scan.Connect(ip, j);
        Console.WriteLine($"[{j}] | OPEN", Color.Green);
    }
    catch
    {
        Console.WriteLine($"[{j}] | CLOSED", Color.Red);
    }
    try
    {
        Scan.Connect(ip, k);
        Console.WriteLine($"[{k}] | OPEN", Color.Green);
    }
    catch
    {
        Console.WriteLine($"[{k}] | CLOSED", Color.Red);
    }

    try
    {
        Scan.Connect(ip, l);
        Console.WriteLine($"[{l}] | OPEN", Color.Green);
    }
    catch
    {
        Console.WriteLine($"[{l}] | CLOSED", Color.Red);
    }





    Console.WriteLine("All Common Ports Scanned.");
    Console.ReadLine();

    goto Start;


}
