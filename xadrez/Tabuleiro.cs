public class Tabuleiro
{
    public Peça[,] Pecas { get; private set; }

    public Tabuleiro()
    {
        Pecas = new Peça[8, 8];
        InicializarTabuleiro();
    }

    private void InicializarTabuleiro()
    {
        // Inicializar as peças no tabuleiro
        Pecas[0, 0] = new Torre(cor.Preto, 0, 0);
        // Adicione outras peças...
    }
}