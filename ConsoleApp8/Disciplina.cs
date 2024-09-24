using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Disciplina
    {
        public string Nome {  get; set; }

        public Aluno Aluno1 { get; set; } = new Aluno();
        public void AdicionarAluno(string nome, int idade, double nota)
        {
            Aluno1.Nome = nome;
            Aluno1.Idade = idade;
            Aluno1.Notas = nota;

        }
    }
}




/*
 
Classe Disciplina
    Nome
    Lista de alunos matriculados 
    
 */