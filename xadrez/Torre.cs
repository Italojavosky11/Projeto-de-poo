public class Torre : Peça
{
    public Torre(string cor, int x, int y) : base(cor,x,y){
        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "Torre xadrez.png");
            MessageBox.Show("Tentando carregar: " + path);
            peao.Image = Image.FromFile(path);

            }

            catch (Exception ex){
                MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
                
            }
            
            try{
                string path = Path.Combine(Application.StartupPath, "imagens", "Torre branco.png");
                MessageBox.Show("Tentando carregar: " + path);
                torre.Image = Image.FromFile(path);

            }

            catch (Exception ex){
                MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
            }

    }
    public override bool VerificarMovimento()
    {
        // Implementar a lógica para verificar se o movimento do peão é válido
        return true; // Exemplo simples, substitua com lógica real
    }
}