using System.ComponentModel;

namespace Net_poo_desafio.Models
{
    
    public class Iphone(string numero, string modelo, string imei, int memoria) : Smartphone(numero, modelo, imei, memoria)
    {
        public string GetModelo()
        {
            return Modelo;
        }

        public string GetImei()
        {
            return IMEI;
        }

        public int GetMemoria()
        {
            return Memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            
            Console.WriteLine($"Instalando {nomeApp} no Iphone...");
        }
    }
}