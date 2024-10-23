namespace Net_poo_desafio.Models
{
    
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            numero = "85825-5255";
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            nomeApp = "WhatApp";
            Console.WriteLine($"Instalando {nomeApp} no Nokia...");
        }
    }
}