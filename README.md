# dictionarydemo
Multivaluedictionary Demo


Instructions to run the projects.



Windows/Mac - Please download VSCode or any other text editor from the link

https://code.visualstudio.com/


Please download .NETCORE 3.0 SDK from the following link 

https://dotnet.microsoft.com/download


Scripts can be installed from the follwoung link - Poweshell/bash

https://dotnet.microsoft.com/download/dotnet/scripts


1. Please verify if .NET core is installed correctly by running the following command

dotnet --version 

3.1.409

2. Clone the repo.
3. Run the dotnet commands to clean and build - dotnet clean and dotnet build.
4. Run the command dotnet run to run the program
5. We can run the following commands
6. REMOVEALL is something I could not finish because of time crunch.
7. I made slight modification to commands. Instead of ADD foo bar, please type in add and it will ask you to enter key value pairs, please enter values only when prompted.
8. For add, once you press enter it will ask us for a message to enter key value pair. You can keep entering other commands like keys, members, allmembers one after


Please refer the sample output I am seeing 

```Please enter an option from below: 
ADD
KEYS
MEMBERS
KEYEXISTS
VALUEEXISTS
REMOVE
REMOVEALL
CLEAR
ALLMEMBERS
ITEMS
add
Please enter key value pair
foo bar
ADDED
add
Please enter key value pair
foo baz
ADDED
add bar bang
Unknown option chosen.  Please enter valid option:
add
Please enter key value pair
bar bang
ADDED
items
1) foo: bar
2) foo: baz
3) bar: bang
allmembers
1) bar
2) baz
3) bang
keys
1) foo
2) bar

Ctrl + C will quit the program.

```



