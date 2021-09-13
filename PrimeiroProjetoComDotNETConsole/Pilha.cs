using System;

namespace Desafio_de_projeto_da_DIO
{
    public class Pilha
    {
        Posicao primeiro;

        public void Empilha(object item){
            primeiro = new Posicao(primeiro, item);
        }

        public object Desempilha(){
            if (primeiro == null)
            {
                throw new InvalidOperationException("A pilha está vazia");
            }

            object resultado = primeiro.item;
            primeiro = primeiro.prox;
            return resultado;
        }

        class Posicao{
            public Posicao prox;

            public object item;

            public Posicao(Posicao prox, object item){
                this.prox = prox;
                this.item = item;
            }
        }
    }
}