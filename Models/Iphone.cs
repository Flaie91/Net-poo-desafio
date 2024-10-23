using System.ComponentModel;

namespace Net_poo_desafio.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            numero = "85825-5555";
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            
            Console.WriteLine($"Instalando {nomeApp} no Iphone...");
        }
    }
}