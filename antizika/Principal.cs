namespace antizika
{
    public partial class Form1 : Form
    {
        //Conex�o com banco de dados
        private readonly string _conexao = antizika.Properties.Settings.Default.Conexao;


        public Form1()
        {
            InitializeComponent();
        }
    }
}
