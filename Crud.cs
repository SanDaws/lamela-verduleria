namespace lamela_verduleria
{
    
    
    class Crud
    {
        public static void Create(Dictionary<string,int[]> product){
            Operations.ConsoClean();
            Operations.Title("Agregar nuevo producto");
        }
        public static void Read(Dictionary<string,int[]> product){
            Operations.ConsoClean();
            Operations.Title("Buscar producto");
        }

        public static void Update(Dictionary<string,int[]> product){
            Operations.ConsoClean();
            Operations.Title("Editar producto");
        }

        public static void Delete(Dictionary<string,int[]> product){
            Operations.ConsoClean();
            Operations.Title("Eliminar producto");
        }



    }
}