namespace DesafioPOO.Models
{
    //classe smartphone herdada.
    public class Iphone : Smartphone
    {
        //Construtor herdado.
           public Iphone(string numero, string imei, string modelo, int memoria) : base(numero, imei, modelo, memoria)
        {

        }
        //Método sobrescrito.
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Iphone...\n");
        }
    }
}