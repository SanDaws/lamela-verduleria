namespace lamela_verduleria;

class Program
{
    public static Dictionary<string,int[]> inventory =new Dictionary<string, int[]>();
    


    static void Menu(){
        char option ='0';
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
        option= Convert.ToChar(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            Console.WriteLine("Respuesta vacia");
            Menu();
        }

        switch (option)
        {
            case'1'://create
            Crud.Create(inventory);
            break;
            case'2'://read
            Crud.Read(inventory);
            break;
            case'3'://update
            Crud.Update(inventory);
            break;
            case'4'://delete
            Crud.Delete(inventory);
            break;
            case's'://exit
            Operations.ConsoClean();
            Operations.Title("Saliendo del programa");
            Environment.Exit(0);
            break;
            
            default:
            Console.WriteLine("opcion invalida");
            Menu();
            break;
        }

        


    }

    static void Main(string[] args)    {
        inventory.Add("",[]);
        Menu();



    }

    
}

