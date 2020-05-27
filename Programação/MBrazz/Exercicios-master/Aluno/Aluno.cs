using System;

namespace Aluno
{
    public class Aluno{
        // Propriedades
       public string Nome {get;set;}
       public string Curso {get;set;}
       public string CPF {get;set;}
       public int[] Notas;
        
        // Construtor
        public Aluno(string Nome, string CPF){
            this.Nome = Nome;
            this.CPF = CPF;
        }

         public Aluno(string Nome, string CPF, string Curso){
            this.Nome = Nome;
            this.CPF = CPF;
            this.Curso = Curso;
        }
        // Metodos de Acesso
        public int[] getNotas(){return notas;}

        public void setNotas(int bi, int nota){
            int i = bi - 1;
            if ((i < 0) || (i > 3)){
                // Condição de Erro;
                throw new ArgumentOutOfRangeException($"{nameof(value)} must 1 and 4 ");
            } else if (nota < 0 )
        }

    }
}