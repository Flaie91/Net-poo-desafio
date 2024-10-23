namespace Net_poo_desafio.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            numero = "85825-5255";
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando App no Nokia...");
        }
    }
}