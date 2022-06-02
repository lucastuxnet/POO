using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caHeranca
{
    class Gerente : Empregado // Gerente herda de Empregado
    {
        // Atributos
        private String secretaria;

        // metodos
        public Gerente() : base()
        {

        }

        public Gerente(String _nome, String _secao, double _salario, String _secretaria) : base(_nome, _secao, _salario) // Ordem eh importante
        {
            secretaria = _secretaria;
        }

        public String getSecretaria()
        {
            return (secretaria);
        }

        public void setSecretaria(String _secretaria)
        {
            secretaria = _secretaria;
        }
        public override void aumentaSalario(double percentagem)
        {
            double novaPercentagem = percentagem + 15.0;
            base.aumentaSalario(novaPercentagem);
        }

    }
}
