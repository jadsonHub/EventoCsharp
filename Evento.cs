using System.Collections.Generic;

namespace ProjetoEventos
{
    public class Evento
    {
        public string Nome { get; set; }
        public string Local { get; set; }
        private float valor;
        public bool Gratuito { get; set; }
        public ICollection<Pessoa> Participantes { get; }

        public float Valor{
            get{
                return valor;
            }
        }
        public Evento(){
            Participantes = new List<Pessoa>();
        }

        public bool InserePessoa(Pessoa p){
            if(Participantes.Count < 2){
                Participantes.Add(p);
                return true;
            }
            return false;
        }
    
        public void InsereValor(float valor1 = 0){
            if(Gratuito){
                valor = 0f;
            }else{
                valor = valor1;    
            }
        }

    }
}