namespace DesafioPOO.Models
{
    //classe smartphone herdada.
    public class Nokia : Smartphone
    {
        //Construtor herdado.
        public Nokia(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {

        }
        //Método sobrescrito.
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia...\n");
        }
    }
}