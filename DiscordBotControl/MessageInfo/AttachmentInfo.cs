using System;
using System.Windows.Forms;
using Discord;

namespace DiscordBotControl {
    public partial class AttachmentInfo : Form {
        private IAttachment _attachment;
        
        public AttachmentInfo(IAttachment attachment) {
            InitializeComponent();

            label1.Text = attachment.Filename;
            linkLabel1.Text = attachment.Url;
            linkLabel1.Links.Add(0, attachment.Url.Length, attachment.Url);
            label2.Text = $@"Size: {attachment.Size / 1024}kB";
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}