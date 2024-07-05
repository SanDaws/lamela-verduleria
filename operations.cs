using System;
using System.Collections.Generic;

namespace lamela_verduleria
{
    public class Operations
    {
//recives every titile and put it in format
    public static void Title(string text){
        int widith= Console.WindowWidth;
        int wid=(widith/2) - text.Length ;
        string lines= new string('#',widith);
        Console.Write(lines+"\n"+text+"\n"+lines);

    }
    public static void ConsoClean(){
        Console.Clear();
    }

    
    }
}