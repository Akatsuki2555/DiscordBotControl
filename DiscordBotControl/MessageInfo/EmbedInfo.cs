using System;
using System.Windows.Forms;
using Discord;

namespace DiscordBotControl {
    public partial class EmbedInfo : Form {
        public EmbedInfo(IEmbed embed) {
            InitializeComponent();

            label1.Text = embed.Title;
            label2.Text = embed.Description;
            if (embed.Footer.HasValue) {
                label3.Text = embed.Footer.Value.Text;
            }
            else {
                label3.Text = @"No footer";
            }

            if (embed.Author.HasValue) {
                label4.Text = embed.Author.Value.Name;
            }
            else {
                label4.Text = @"No author";
            }

            foreach (var field in embed.Fields) {
                listBox1.Items.Add($@"{field.Name} : {field.Value} | inline: {field.Inline}");
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}