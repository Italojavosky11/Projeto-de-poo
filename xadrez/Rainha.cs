using System;
public class Rainha : Peça 
{
    public Rainha(string cor, int x, int y) : base(cor, x , y) {
         try{
                string path = Path.Combine(Application.StartupPath, "imagens", "Rainha branco.png");
                MessageBox.Show("Tentando carregar: " + path);
                rainha.Image = Image.FromFile(path);

            }

            catch (Exception ex){
                MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
            }
    }

    public override bool VerificarMovimento()
    {
        throw new NotImplementedException(); // lógica de movimentação da rainha
    }
}