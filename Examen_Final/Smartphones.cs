namespace Examen_Final
{
    public class Smartphones : Dispositivos
    {
        public string Sistemaoperativo { get; set; }
        public string Numcamaras { get; set; }

        public Smartphones()
        {
            Sistemaoperativo = string.Empty;
            Numcamaras = string.Empty;
        }
    }
}
