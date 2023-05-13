using System;
using System.Windows.Forms;

namespace DiscordBotControl {
    public partial class TokenEntry : Form {
        public event EventHandler<string> EnteredEvent; 

        public TokenEntry() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            EnteredEvent?.Invoke(this, textBox1.Text);
            Close();
        }
    }
}