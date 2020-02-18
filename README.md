# Database Backup Creator
A C# GUI program to create scheduled daily backups using the Microsoft SQL server agent.

## Before Use
This program must be used on a local Microsoft SQL Server.

You must have the SQL Server Agent on your SQL Server to use this program - [Server Agent](https://docs.microsoft.com/en-us/sql/ssms/agent/sql-server-agent?view=sql-server-ver15)


## How to Compile
If you want to compile the project, clone the repository and open the visual studio solution file 'Db Backup Job Creator.sln'

## Using Without Compiling
If you want there is a pre-compiled (.exe) version in the repository already.
You can clone the repository and find the executable in the path below.
```
/Db backup creator/bin/debug/DB backup Job Creator.exe
```
## How to Use
Open the executable Db Backup Job Creator.exe

1. Enter your sa password to your server.
2. Click the List Databases button.
3. Select the database from the drop down menu.
4. Select the path for the root directory.
**Note that the program will create its own root directory folders so you don't need to make a folder for it.**
5. Type a backup/job name.
6. (Optional) Select a time to schedule the backup time. The time is in military hours. If left at 0 it will backup at midnight.
7. Click create jobs. When the jobs execute the backup files will be stored in their associated weekday folder (Monday, Tuesday...etc).
8. The create backup file button instantly creates a backup file of the database selected and stores it in the path .
```
DB Backup Creator\Backups\Example.bak
```
9. If for some reason the jobs fail to create or the backup fails to be created, the program will log the failed executed query in the path
```
DB Backup Creatoe\Error Logs\MM-DD-YYYY HH-MM-SS.txt
```

## Using with an NAS
When you want to store your backup files to an NAS you will have to manually input the path of the backups with the ip address of your NAS.
A mapped drive path such as 'Z:\' will not work properly.

Incorrent NAS Path
```
Z:\DB Server\Folder
```

Correct NAS Path
```
\\111.111.111\Folder
```

## Author
Shane Spangenberg
