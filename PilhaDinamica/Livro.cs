namespace PilhaDinamica
{
    internal class Livro
    {
        string titulo;
        Livro anterior;

        public Livro(string titulo)
        {
            this.titulo = titulo;
            this.anterior = null;
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public void setAnterior(Livro anterior)
        {
            this.anterior = anterior;
        }

        public Livro getAnterior()
        {
            return this.anterior;
        }

        public override string? ToString()
        {
            return $"Título: {this.titulo}\n";
        }
    }
}
