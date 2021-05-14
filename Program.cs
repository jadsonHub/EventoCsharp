using System;

namespace ProjetoEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Paula";
            p1.Idade = 22;
            p1.Endereco = "Av 123";
            Pessoa p2 = new Pessoa();
            p2.Nome = "Paulo";
            p2.Idade = 25;
            p2.Endereco = "Av 321";
            Pessoa p3 = new Pessoa();
            p3.Nome = "Joana";
            p3.Idade = 27;
            p3.Endereco = "Av 3111";
            Evento ev1 = new Evento();
            ev1.Nome = "Aula prática em lab";
            ev1.Gratuito = true;
            ev1.Local = "CIMATEC";
            if(ev1.InserePessoa(p1)){
                Console.WriteLine(p1.Nome+" foi inserido com sucesso!");
            }
            if(ev1.InserePessoa(p2)){
                Console.WriteLine(p2.Nome+" foi inserido com sucesso!");
            }

            if(ev1.InserePessoa(p3)){
                Console.WriteLine(p3.Nome+" foi inserido com sucesso!");
            }else{
                Console.WriteLine("Não foi possivel inserir"+p3.Nome+" no evento, pois já está lotado.");
            }
            Console.WriteLine("Participantes do evento: ");
            foreach(Pessoa p in ev1.Participantes){
                Console.WriteLine(p.Nome);
            }
        }
    }
}
