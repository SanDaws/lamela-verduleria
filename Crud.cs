namespace lamela_verduleria
{
    
    
    class Crud
    {
        public static void Create(Dictionary<string,int[]> products){
            Operations.ConsoClean();
            Operations.Title("Agregar nuevo producto",'#');
            Console.Write("nombre del producto");
            string? productName =Console.ReadLine();
            Console.Write("nombre del producto");
            int price= int.Parse(Console.ReadLine());
            
            Console.Write("nombre del producto");
            int unit= int.Parse(Console.ReadLine());

            products.Add(productName,[price,unit]);

            //desicion to repeat or return to menue
            bool decision= Operations.Contin();
            if (decision==true){
                Create(products);
            }

        }
        public static void Read(Dictionary<string,int[]> products){
            Operations.ConsoClean();
            Operations.Title("Buscar producto",'═');
            foreach (var item in products)
            {
                Console.WriteLine("{0,5}......................................{1,8:c0} {2} {3,5:c0}",item.Key,item.Value[0],item.Value[1],Operations.calculate(item.Value[0],item.Value[1]));
                
            }
            //desicion to repeat or return to menue
            bool decision= Operations.Contin();
            if (decision==true){
                Read(products);
            }
        }

        public static void Update(Dictionary<string,int[]> products){
            Operations.ConsoClean();
            Operations.Title("Editar producto",'#');

            //llok for a product
            Console.Write("nombre del producto a buscar");
            string productName=Console.ReadLine();
            if (products.ContainsKey(productName)==false){//condition for the product doesn't exist
                Console.WriteLine("Producto no encontrado");     
                Update(products);
            }
            //start for changing
            Console.WriteLine("Dejar vacio si mantiene");
            //new product name
            Console.Write("Nuevo nombre del producto");
            string newProductName= Console.ReadLine();
            //new price
            Console.Write("Nuevo precio del producto");
            string newPrice=Console.ReadLine();
            int newp;
            if (string.IsNullOrEmpty(newPrice)){// if it's empty
                newp=(int)products[productName].GetValue(0);
            }else{
                newp= int.Parse(newPrice);
            }
            //new capacity
            Console.Write("Nueva cantidad de unidades del producto");
            string newCapacity=Console.ReadLine();
            int newc;
            if (string.IsNullOrEmpty(newCapacity)){//if it's empty
               newc=(int)products[productName].GetValue(1) ;
                               
            }else{
                newc=int.Parse(newCapacity);
            }

            //if need to change the name

            if (string.IsNullOrEmpty(newProductName)==false){
                
                
            }else{
               
            }

            



            //desicion to repeat or return to menue
            bool decision= Operations.Contin();
            if (decision==true){
                Update(products);
            }
        }

        public static void Delete(Dictionary<string,int[]> products){
            Operations.ConsoClean();
            Operations.Title("Eliminar producto",'#');
            
            Console.Write("nombre del producto a eliminar");
            string productName=Console.ReadLine();
            if (products.ContainsKey(productName)==false){
                Console.WriteLine("Producto no encontrado");     
                Delete(products);
            }

            products.Remove(productName);
            Console.WriteLine("producto {0}, eliminado satisfactoriamente",productName);


            //desicion to repeat or return to menue
            bool decision= Operations.Contin();
            if (decision==true){
                Delete(products);
            }
        }



    }
}