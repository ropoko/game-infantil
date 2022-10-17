namespace GameInfantil.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            TextBoxInfo.Text = $"ACIDENTES DOMÉSTICOS\r\n\r\nOs acidentes domésticos causados por queimaduras, " +
                $"são as principais causas de procura aos serviços de saúde. Ocasionados durante o preparo dos alimentos " +
                $"ou até mesmo, pelo manuseio de panelas. \r\nAs principais vítimas desses acidentes são crianças e " +
                $"adolescentes.\r\n\r\n \r\n\r\n \r\n\r\n*Crianças devem ficar longe do fogão, de preferência fora da " +
                $"cozinha quando o fogão estiver sendo utilizado. Os pais devem ficar atentos às atividades dos filhos." +
                $"*Os cabos das panelas devem ser virados para a parte de dentro do fogão e, se for ferver ou fritar algum alimento, " +
                $"é preferível usar as bocas do fundo do fogão. Isso diminui o risco de a criança esbarrar nas panelas." +
                $"\r\n\r\n*As tomadas devem ser tapadas, os fios desencapados devem ser protegidos, e os famosos “gatos” evitados," +
                $" pois podem ser a causa de incêndios e curtos-circuitos. Além de evitar fios soltos pela casa ligados em tomadas." +
                $"\r\n\r\n*Materiais inflamáveis devem ser mantidos à distância das crianças ou, de preferência, evitados em casa pelos pais. " +
                $"É preferível trocar o álcool líquido pelo mesmo produto em gel, pois este é menos inflamável." +
                $"\r\n\r\n*As crianças devem ser orientadas durante as brincadeiras. Por exemplo, não devem soltar pipas perto de " +
                $"fios de alta tensão porque, além de causar queimaduras muito graves, pode levar a pessoa à morte. " +
                $"Os campos abertos e sem postes são os locais adequados para isso.\r\nManter a torneira do gás fechada quando o " +
                $"fogão não estiver sendo utilizado e, de preferência, colocar a botija de gás do lado de fora da casa." +
                $"\r\n\r\n\r\n\r\nEm caso de acidentes\r\n\r\n*Caso seu filho se queime, não passe nada no local afetado. " +
                $"Pomadas, pasta de dentes, manteiga, clara de ovos ou outras receitas caseiras podem prejudicar mais ainda a ferida." +
                $"\r\n\r\n*Lave a região por 10 minutos em água corrente e busque atendimento médico.\r\n\r\n*Se a chama atingir as roupas, " +
                $"a vítima deve deitar no chão e rolar. Quem estiver por perto deve cobri-la com um lençol ou pano molhado e levá-la " +
                $"imediatamente ao hospital.\r\n\r\n*Não estoure as bolhas, pois há risco de infecção.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();

            var main = new MainForm();
            main.Show();
        }
    }
}
