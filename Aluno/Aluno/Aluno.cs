using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    // Criando classe aluno
    class Aluno
    {
        // Criando nome,matricula e telefone.

        public String nome_aluno;
        public String num_matricula;
        public String num_telefone;

        // Iniciando os construtores com dados.
        public Aluno(String nome, String matricula, String telefone)
        {
            nome_aluno = nome;
            num_matricula = matricula;
            num_telefone = telefone;
        }

        // Iniciando construtor vazio.
        public Aluno()
        {

        }

        // Inicia a solicitação de dados.

        // setters
        public void setDados(String nome, String matricula, String telefone)
        {
            nome_aluno = nome;
            num_matricula = matricula;
            num_telefone = telefone;
        }
        public void setNome(String nome)
        {
            nome_aluno = nome;
        }
        public void setMatricula(String matricula)
        {
            num_matricula = matricula;
        }
        public void setTelefone(String telefone)
        {
            num_telefone = telefone;
        }

        // Getters
        public String getNome()
        {
            return (nome_aluno);
        }
        public String getMatricula()
        {
            return (num_matricula);
        }
        public String getTelefone()
        {
            return (num_telefone);
        }

        // Imprimindo leitura do teclado.
        public void printNome()
        {
            Console.WriteLine("Digite o número de matricula:  " + num_matricula);
        }
        public void printMatricula()
        {
            Console.WriteLine("Digite o nome do Aluno: " + nome_aluno);
        }
        public void printTelefone()
        {
            Console.WriteLine("Digite o número do telefone: " + num_telefone);        
        }


    }
}
