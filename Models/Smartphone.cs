namespace Net_poo_desafio.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected String Modelo { get;}
        protected String IMEI { get;}
        protected int Memoria { get;}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;    
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}