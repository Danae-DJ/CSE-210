// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Video tutorial: https://www.youtube.com/watch?v=axHut2e84fc&t=153s 

//how to create a new file of C#... 
//1. New terminal
//2. In new terminal in ruta write: 
// (example:PS C:\Users\danae\OneDrive\Documents\Programming with Classes\CSE-210> dotnet new console -o app (app is a example of name of file)
//3. enter => it was create new file with name, .cs, .csproj and obj file
//4. In terminal write:
// PS C:\Users\danae\OneDrive\Documents\Programming with Classes\CSE-210> cd app (to selection the new file)
//5. enter => was selection the new file
//6. In terminal write
// PS C:\Users\danae\OneDrive\Documents\Programming with Classes\CSE-210\app> dotnet run
//7. Enter => the new file was run and now there is a bin file into new file.



//Variables (text, numbers, etc)
//texts
string libro = "El programador fantasma";
string telf = "123-344-3467";
//numbers
int entero = 100;
float numDecimal = 1.967857F;//use F in the final of decimal number
//Buleanos/bool
bool autorizado = true;
bool seleccionado = false;


// List of numbers
int[] numbers = {23, 34, 45, 56, 67, 78, 89 };
Cosole.WriteLine(numbers[0]); //0 is the first place in the list
