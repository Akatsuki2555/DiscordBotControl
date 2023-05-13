using System;
using System.Diagnostics;
using System.Windows.Forms;
using Discord;

namespace DiscordBotControl {
    public partial class InviteCreatedWindow : Form {
        private IInviteMetadata _metadata;
        
        public InviteCreatedWindow(IInviteMetadata inviteMetadata) {
            _metadata = inviteMetadata;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Process.Start(_metadata.Url);
            Close();
        }
    }
}