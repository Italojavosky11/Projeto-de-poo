using System;

public class Rei : Peça{
    public Rei(string cor, int x, int y) : base(cor,x ,y){

        try{
                string path = Path.Combine(Application.StartupPath, "imagens", "Rei branco.png");
                MessageBox.Show("Tentando carregar: " + path);
                rei.Image = Image.FromFile(path);

            }

            catch (Exception ex){
                MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
            }

         try{
            string path = Path.Combine(Application.StartupPath, "imagens", "Rei xadrez.png");
            MessageBox.Show("Tentando carregar: " + path);
            peao.Image = Image.FromFile(path);

            }

            catch (Exception ex){
                MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
            }
    }
    public override bool VerificarMovimento()
    {
        throw new NotImplementedException(); // lógica de movimentação do rei
    }
}