using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;


Tittle();
Menu();

void Tittle()
{
    Console.WriteLine("||||||||||");
    Console.WriteLine("|TODO APP|");
    Console.WriteLine("||||||||||");
};

void Menu()
{
    Console.WriteLine("\nSelecione a opção que deseja:");
    Console.WriteLine("1- Create a note");
    Console.WriteLine("2- Delete a note");
    Console.WriteLine("3- Modify a note");
    Console.WriteLine("4- Mark as done");
    string option = Console.ReadLine()!;
    int optionNum = int.Parse(option);

    switch (optionNum)
    {
        case 1: Create();
            break;
        case 2: Delete();
            break;
        case 3:  Modify();
            break;
        case 4: Mark();
            break;
        default: Console.WriteLine("Nenhuma opção foi selecionada.");
            break;
    }
};

void Create()
{
    Console.WriteLine("Escreva sua nota:");
    string note = Console.ReadLine()!;
};

void Delete()
{
    Console.WriteLine("Selecione uma nota para deletar: ");
    Console.WriteLine();
};

void Modify()
{
    
};

void Mark()
{
    
};