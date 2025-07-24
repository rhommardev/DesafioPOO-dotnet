namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
//propriedades
        public string Numero { get; set; }
        //        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        //construtor
        public Smartphone(string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }
//metodo para ligar 
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
//metodo para receber ligação
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }
//metodo para instalar aplicativo
        public abstract void InstalarAplicativo(string nomeApp);
    }
}