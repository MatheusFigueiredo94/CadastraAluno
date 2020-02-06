using CadastraNotaAluno.Entidade;
using CadastraNotaAluno.Negocios;
using System;
using System.IO;
using System.Xml;

namespace CadastraNotaAluno
{
    public static class Principal
    {
        public static void OnStart()
        {
            buscaTrabalhosPasta();

        }

        public static void buscaTrabalhosPasta()
        {
            try
            {

                string[] dirs = Directory.GetFiles(@"C:\Projeto\", "*.xml");

                foreach (string dir in dirs)
                {

                    processaTrabalho(dir);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Falha no método buscaTrabalhosPasta(): {0}", e.ToString());
            }

        }

        public static void processaTrabalho(string dir)
        {

            XmlDocument doc = new XmlDocument();
            doc.Load(dir);

            XmlNode nodeAluno = doc.DocumentElement.SelectSingleNode("/aluno");
            string nomeAluno = nodeAluno.Attributes["nome"]?.InnerText;
            DateTime dataNascimento = Convert.ToDateTime(nodeAluno.Attributes["dataNascimento"]?.InnerText);
            string sexo = nodeAluno.Attributes["sexo"]?.InnerText;


            Aluno aluno = new Aluno(nomeAluno, dataNascimento, sexo);

            AlunoNegocios alunoNegocio = new AlunoNegocios();
            alunoNegocio.Cadastrar(aluno);
            
        }

    }
}
