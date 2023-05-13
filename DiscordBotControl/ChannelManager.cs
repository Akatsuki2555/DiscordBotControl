using System.Windows.Forms;
using Discord.WebSocket;

namespace DiscordBotControl {
    public partial class ChannelManager : Form {
        public ChannelManager(SocketGuild socketGuild) {
            InitializeComponent();
        }
    }
}