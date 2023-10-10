using System.Diagnostics;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        private Process process;
        public Form1()
        {
            InitializeComponent();
            process = new Process();

        }

        private void button2Click(object sender, EventArgs e)
        {
            num1.Value = 0;
            num2.Value = 0;
            symbLine.Text = "";
            panel1.Visible = !panel1.Visible;
        }

        private void button6Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3Click(object sender, EventArgs e)
        {
            path.Text = "";
            nameToCount.Text = "";
            panel2.Visible = !panel2.Visible;
        }

        private void button5Click(object sender, EventArgs e)
        {
            process.StartInfo.FileName = @"C:\Users\User\source\repos\WinFormsApp11\FindAndCountFileName\bin\Release\net6.0\FindAndCountFileName.exe";
            var filePath = path.Text;
            var fileName = nameToCount.Text;
            process.StartInfo.Arguments = $"{filePath} {fileName}";
            process.Start();
            Hide();
            process.WaitForExit();
            Show();

        }

        private void button4Click(object sender, EventArgs e)
        {
            process.StartInfo.FileName = @"C:\Users\User\source\repos\WinFormsApp11\ConsoleApp1\bin\Release\net6.0\ConsoleMath.exe";
            process.StartInfo.Arguments = $"{num1.Value} {num2.Value} {symbLine.Text}";
            process.Start();
            Hide();
            process.WaitForExit();
            Show();
        }

        private void button1Click(object sender, EventArgs e)
        {
            process.StartInfo.FileName = @"C:\Users\User\source\repos\GameProject\GameProject\bin\Release\netcoreapp3.1\GameProject.exe";
            process.Start();
            process.WaitForExit();
            var pId = process.ExitCode;
            MessageBox.Show($"process close id: {pId}");
        }
    }

}