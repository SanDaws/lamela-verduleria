namespace lamela_verduleria;

class Program
{
    static void Menu(){
        Operations.Title("tienda Lamela");
        Console.Write(@"
        opciones:
        1:Agregar nuevo producto
        2:Buscar producto
        3:Editar producto
        4:Eliminar producto
        s:Salir
        ");
        try
        {
        char option= Convert.ToChar(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Respuesta vacia");
            Menu();
        }


    }

    static void Main(string[] args)    {
        Menu();



    }

    
}

