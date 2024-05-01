namespace PilhaDinamica
{
    internal class PilhaLivro
    {
        Livro topo;

        public PilhaLivro()
        {
            this.topo = null;
        }

        public void Push(Livro aux)
        {
            if (Vazia())
            {
                this.topo = aux;
            }
            else
            {
                aux.setAnterior(topo);
                topo = aux;
            }
        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Pilha vazia");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                topo = topo.getAnterior();
            }
        }

        bool Vazia()
        {
            if (topo == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            Livro aux = topo;
            if (Vazia())
            {
                Console.WriteLine("Impossível imprimir, pilha vazia");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getAnterior();
                } while (aux != null);
                Console.WriteLine("Fim da impressão.");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}
