using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            this.BackColor = Color.FromArgb(rand.Next(200), rand.Next(200), rand.Next(200));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // 최신 .NET 환경에서 웹사이트를 여는 가장 안전한 방법입니다.
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "https://github.com/0601sunny-spec/C-",
                    UseShellExecute = true // 시스템 기본 브라우저를 사용하도록 설정
                });
            }
            catch (Exception ex)
            {
                // 만약 또 오류가 난다면 어떤 오류인지 메시지 박스로 보여줍니다.
                MessageBox.Show("오류 발생: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\user AFE\Downloads\20251214_014127 (1).jpg");
        }
    }
}
