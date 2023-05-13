using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;

namespace DiscordBotControl {
    public partial class MemberInfo : Form {
        public MemberInfo(IGuild guild) {
            InitializeComponent();
            _ = Load(guild);
        }

        private async Task Load(IGuild guild) {
            var users = await guild.GetUsersAsync();
            foreach (var user in users) {
                if (user.IsBot) 
                    listBox1.Items.Add($"{user.Username}#{user.Discriminator} (Bot)");
                else
                    listBox1.Items.Add($"{user.Username}#{user.Discriminator} (User)");
            }
            label2.Text =
                $@"Online: {users.Count(x => x.Status == UserStatus.Online || x.Status == UserStatus.DoNotDisturb || x.Status == UserStatus.AFK || x.Status == UserStatus.Idle)}";
            label3.Text =
                $@"Offline: {users.Count(x => x.Status == UserStatus.Offline || x.Status == UserStatus.Invisible)}";
            label4.Text =
                $@"Online bots: {users.Count(x => x.IsBot && (x.Status == UserStatus.Online || x.Status == UserStatus.DoNotDisturb || x.Status == UserStatus.AFK || x.Status == UserStatus.Idle))}";
            label5.Text =
                $@"Offline bots: {users.Count(x => x.IsBot && (x.Status == UserStatus.Offline || x.Status == UserStatus.Invisible))}";
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }
    }
}