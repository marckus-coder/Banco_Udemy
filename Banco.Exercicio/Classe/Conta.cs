namespace Banco.Exercicio.Classe
{
    public class Conta
    {
        public Conta(int _conta, string _nome)
        {
            this._conta = _conta;
            this._nome = _nome;

        }
        public int _conta { get; set; }
        public string _nome { get; set; }

        private double _valorInicial;

        public double _saldo;
        public string resposta {get; set;}

        public Conta(int Conta, string Nome, double ValorInicial, double Saldo)
        {
            _conta = Conta;
            _nome = Nome;
            _valorInicial = ValorInicial;
            _saldo = Saldo;
        }

        public double ValorInicial
        {
            get { return _valorInicial; }
            set
            {
                if (value == 0)
                {
                    _valorInicial = 0.00;
                }
            }
        }
        public void Depositar(double _valorInicial){
            if (resposta == "n"){
                _valorInicial = 0.00;
            }
        }
    }
}