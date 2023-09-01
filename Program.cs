using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Disciplina disciplina1 = new Disciplina("POO II", 30);

        Aluno aluno1 = new Aluno("Nélio Espíndula Junior", true, disciplina1);

        aluno1.AtribuirNota1(4.5);
        aluno1.AtribuirNota2(3.0);
        aluno1.CalcularMedia();

        for (int i = 0; i < 9; i++)
        {
            aluno1.AtribuirFalta();
        }

        aluno1.VerificarStatus(disciplina1);

    }
}