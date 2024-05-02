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

        public void Search()
        {
            Livro aux = topo;
            string searchTitle;
            Console.Write("Digite o livro que você quer procurar: ");
            searchTitle = Console.ReadLine();
            do
            {
                if (Vazia())
                {
                    Console.WriteLine("Não tem como procurar numa pilha vazia!!!");
                    Console.WriteLine("Pressione qualquer tecla para continuar...");
                    Console.ReadKey();
                }
                else
                {
                    if (aux.getTitulo() == searchTitle)
                    {
                        Console.WriteLine($"O livro {aux.getTitulo()} foi encontrado");
                    }
                    else
                    {
                        Console.WriteLine("O livro desejado não está na pilha");
                    }
                    aux = aux.getAnterior();
                }
            } while (aux != null);
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
