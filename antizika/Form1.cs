using System.Security.Cryptography;

namespace antizika
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CalcularHash_Click(object sender, EventArgs e)
        {
            //Abrir Windows Explorer (File Dialog)
            using (OpenFileDialog dialogoAbrirArquivo = new OpenFileDialog())
            {
                dialogoAbrirArquivo.Filter = "Todos os arquivos (*.*|*.*";

                if(dialogoAbrirArquivo.ShowDialog() == DialogResult.OK)
                {
                    //Armazena o caminho do arquivo
                    string caminhoArquivo = dialogoAbrirArquivo.FileName;

                    //Calcular a hash
                    string hashSHA256 = CalcularHashSHA256(caminhoArquivo);
                    Clipboard.SetText(hashSHA256);
                    MessageBox.Show("Hash colado na area de transferencia");

                }
            }
        }

        //Calcular Hash SHA256

        private string CalcularHashSHA256(string caminhoArquivo)
        {
            using(FileStream fs = File.OpenRead(caminhoArquivo))//Abre o arquivo
            using(SHA256 sha256= SHA256.Create())
            {
                //Computa o hash do arquivo e converter os bytes para string
                byte[] hashBytes = sha256.ComputeHash(fs);
                return BitConverter.ToString(hashBytes).Replace("-","").ToLower();
            }
        }

    }
}
