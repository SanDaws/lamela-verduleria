using System;
using System.Collections.Generic;

namespace lamela_verduleria
{
    public class Operations
    {
    public static void Menu(string text){
        int widith= Console.WindowWidth;
        int wid=(widith/2) - text.Length ;
        string lines= new string('#',widith);
        string line2= $"#";
        Console.Write(lines+"\n"+text+"\n"+lines);
        

    }
    
    }
}