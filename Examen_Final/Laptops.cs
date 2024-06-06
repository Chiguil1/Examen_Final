namespace Examen_Final
{
    public class Laptops : Dispositivos
    {
        public string Ram {  get; set; }
        public string Almacenamiento { get; set; }

        public Laptops()
        {
            Ram = string.Empty;
            Almacenamiento = string.Empty;
        }
    }
}
