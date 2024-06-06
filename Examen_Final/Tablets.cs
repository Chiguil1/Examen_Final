namespace Examen_Final
{
    public class Tablets : Dispositivos
    {
        public string Tamaniopantalla {  get; set; }
        public string Soporte { get; set; }

        public Tablets()
        {
            Tamaniopantalla = string.Empty;
            Soporte = string.Empty;
        }
    }
}
