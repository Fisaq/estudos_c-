using System;
using System.Collections.Generic;

namespace portalAcademico
{

    public class Disciplina
    {
        private string nome;
        private List<Aluno> alunosMatriculados;
        private string curso;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public List<Aluno> AlunosMatriculados
        {
            get { return alunosMatriculados; }
            set { alunosMatriculados = value; }
        }

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public void ExibirInformacoesDisciplina()
        {

            Console.WriteLine("\n\n------ SOBRE A DISCIPLINA ----\n");
            Console.WriteLine($"\nDisciplina: {Nome}");
            Console.WriteLine($"Curso: {Curso}");

            Console.WriteLine("\n\n------ ALUNOS MATRICULADOS ----\n");

            foreach (Aluno aluno in AlunosMatriculados)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
