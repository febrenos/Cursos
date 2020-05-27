using System;

namespace Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Mateus Braz","516.638.538-19");
            Aluno aluno2 = new Aluno("Ronaldinho", "707.70.70.70-70", "Futebolistico");
            Console.WriteLine("Nome: " + aluno1.Nome);
            Console.WriteLine("CPF: " + aluno1.CPF);
            Console.WriteLine("Curso: " + aluno1.Curso);

            Console.WriteLine("Nome: " + aluno2.Nome);
            Console.WriteLine("CPF: " + aluno2.CPF);
            Console.WriteLine("Curso: " + aluno2.Curso);

            Console.Write("Entre com o Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Entre com o CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Entre com o Curso: ");
            string curso = Console.ReadLine();
            Console.Write("Entre com a nota: ");
            int nota = int.Parse(Console.ReadLine());
            Console.Write("Entre com o bimestre: ");
            int bimestre = int.Parse(Console.ReadLine());
            Aluno aluno3 = new Aluno(nome,cpf,curso);
            aluno3.setNotas(bimestre,nota);

            Console.WriteLine("Nome: " + aluno3.Nome);
            Console.WriteLine("CPF: " + aluno3.CPF);
            Console.WriteLine("Curso: " + aluno3.Curso);
            Console.WriteLine("Notas: ");
            foreach(int nota in aluno3.getNotas()){
                Write(nota + " ");
            }
            Console.WriteLine();

           
        }
    }
}
