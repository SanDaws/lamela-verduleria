using System;
using System.Collections.Generic;

namespace lamela_verduleria
{
    public class Operations
    {
//recives every titile and put it in format
    public static void Title(string text,char chor){
        int widith= Console.WindowWidth;
        int wid=widith- text.Length ;
        string lines= new string(chor,widith);
        Console.Write(lines+"\n"+text+"\n"+lines);

    }
    public static void ConsoClean(){
        Console.Clear();
    }
    public static double calculate(int price, int cant){
        double resul=0;
        resul= price * cant;
        return resul;
    }
    public static void ReturnMenu(){
        ConsoClean();
        Title("Volviendo al Menú",'░');
        ConsoleKeyInfo response=Console.ReadKey();
        Program.Menu();

    }
    public static bool Contin(){
        Console.WriteLine("Oprima enter para continuar, M para volver al menu inical");
        ConsoleKeyInfo response=Console.ReadKey();
        if(response.Key== ConsoleKey.Enter){
            return true;
        }else if(response.Key == ConsoleKey.M){
            ReturnMenu();
            return false;
        }
        return true;


    }

    
    }
}