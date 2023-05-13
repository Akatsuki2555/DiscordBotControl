using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using Discord.WebSocket;

namespace DiscordBotControl {
    public partial class Form1 : Form {
        private readonly DiscordSocketClient _client;
        private IEnumerable<IMessage> _messages = new List<IMessage>();

        public Form1() {
            _client = new DiscordSocketClient();
            _client.Ready += ClientOnReady;
            _client.JoinedGuild += delegate {
                RefreshGuildsList();
                return Task.CompletedTask;
            };
            _client.LeftGuild += delegate {
                RefreshGuildsList();
                return Task.CompletedTask;
            };
            _client.ChannelCreated += delegate {
                RefreshChannelList();
                return Task.CompletedTask;
            };
            _client.ChannelDestroyed += delegate {
                RefreshChannelList();
                return Task.CompletedTask;
            };
            _client.ChannelUpdated += delegate {
                RefreshChannelList();
                return Task.CompletedTask;
            };
            _client.UserJoined += delegate {
                _ = RefreshMemberList();
                return Task.CompletedTask;
            };
            _client.UserLeft += delegate {
                _ = RefreshMemberList();
                return Task.CompletedTask;
            };
            _client.MessageReceived += delegate(SocketMessage message) {
                if (listBox1.SelectedIndex == -1 || listBox2.SelectedIndex == -1) return Task.CompletedTask;
                if (listBox1.SelectedIndex > _client.Guilds.Count || listBox2.SelectedIndex >
                    _client.Guilds.ToList()[listBox1.SelectedIndex].TextChannels.Count) return Task.CompletedTask;
                var guild = _client.Guilds.ToList()[listBox1.SelectedIndex];
                var channel = guild.TextChannels.ToList()[listBox2.SelectedIndex];
                if (message.Channel.Id != channel.Id) return Task.CompletedTask;
                _ = RefreshMessageList();
                return Task.CompletedTask;
            };
            InitializeComponent();
            if (!File.Exists("token.txt")) return;
            _client.LoginAsync(TokenType.Bot, File.ReadAllText("token.txt"));
            _client.StartAsync();
        }

        private void Form1_Load(object sender, EventArgs e) {
            if (File.Exists("token.txt")) return;
            toolStripStatusLabel1.Text = @"Waiting for token to be entered";
            TokenEntry tokenEntry = new TokenEntry();
            tokenEntry.EnteredEvent += TokenEntryOnEnteredEvent;
            tokenEntry.Show();
        }

        private void TokenEntryOnEnteredEvent(object sender, string e) {
            toolStripStatusLabel1.Text = @"Logging in...";
            File.WriteAllText("token.txt", e);
            _client.LoginAsync(TokenType.Bot, e);
            _client.StartAsync();
        }

        private Task ClientOnReady() {
            toolStripStatusLabel1.Text = @"Idle";
            RefreshGuildsList();
            return Task.CompletedTask;
        }

        private void RefreshGuildsList() {
            listBox1.Items.Clear();
            foreach (var guild in _client.Guilds) {
                listBox1.Items.Add(guild.Name);
            }

            label1.Text = $@"Guilds: {_client.Guilds.Count}";
        }

        private void RefreshChannelList() {
            if (listBox1.SelectedIndex == -1) return;
            if (listBox1.SelectedIndex > _client.Guilds.Count) return;
            var guild = _client.Guilds.ToList()[listBox1.SelectedIndex];
            listBox2.Items.Clear();
            foreach (var channel in guild.TextChannels) {
                if (channel.GetChannelType() == ChannelType.PublicThread)
                    listBox2.Items.Add($"[PublicThread] {channel.Name}");
                else if (channel.GetChannelType() == ChannelType.PrivateThread)
                    listBox2.Items.Add($"[PrivateThread] {channel.Name}");
                else if (channel.GetChannelType() == ChannelType.Voice)
                    listBox2.Items.Add($"[Voice] {channel.Name}");
                else
                    listBox2.Items.Add(channel.Name);
            }

            label2.Text = $@"{guild.Name} | Channels: {guild.TextChannels.Count}";
        }

        private async Task RefreshMessageList() {
            if (listBox1.SelectedIndex == -1) return;
            if (listBox1.SelectedIndex > _client.Guilds.Count) return;
            if (listBox2.SelectedIndex == -1) return;
            if (listBox2.SelectedIndex > _client.Guilds.ToList()[listBox1.SelectedIndex].TextChannels.Count) return;
            label3.Text = @"Loading messages...";
            var guild = _client.Guilds.ToList()[listBox1.SelectedIndex];
            var channel = guild.TextChannels.ToList()[listBox2.SelectedIndex];
            listBox3.Items.Clear();
            _messages = await channel.GetMessagesAsync().FlattenAsync();
            var enumerable = _messages as IMessage[] ?? _messages.ToArray();
            foreach (var message in enumerable.Reverse()) {
                if (message.Content.Length != 0) {
                    listBox3.Items.Add(
                        $"{message.Author.Username}#{message.Author.DiscriminatorValue:N0}: {message.Content}");
                    continue;
                }

                // check if there are embeds
                if (message.Embeds.Count > 0) {
                    listBox3.Items.Add(
                        $"{message.Author.Username}#{message.Author.DiscriminatorValue:N0}: [Embed] {message.Embeds.First().Title} | {message.Embeds.First().Description}");
                }
                // also check attachments
                else if (message.Attachments.Count > 0) {
                    listBox3.Items.Add(
                        $"{message.Author.Username}#{message.Author.DiscriminatorValue:N0}: [Attachment] {message.Attachments.First().Filename}");
                }
                else {
                    listBox3.Items.Add(
                        $@"{message.Author.Username}#{message.Author.DiscriminatorValue:N0}: [Empty]");
                }
            }

            // scroll to the bottom
            listBox3.TopIndex = listBox3.Items.Count - 1;
            label3.Text = $@"{channel.Name} | Messages: {enumerable.Length}";
        }

        private async Task RefreshMemberList() {
            if (listBox1.SelectedIndex == -1) return;
            label4.Text = @"Loading members...";
            var guild = _client.Guilds.ToList()[listBox1.SelectedIndex];
            listBox4.Items.Clear();
            foreach (var member in await guild.GetUsersAsync().FlattenAsync()) {
                listBox4.Items.Add(member.IsBot ? $"[BOT] {member.Username}" : member.Username);
            }

            label4.Text = $@"Members: {guild.MemberCount}";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            RefreshChannelList();
            _ = RefreshMemberList();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {
            _ = RefreshMessageList();
        }

        private async Task CreateInviteAndOpen(SocketTextChannel channel) {
            toolStripStatusLabel1.Text = @"Creating invite...";
            var invite = await channel.CreateInviteAsync(
                maxUses: 1, maxAge: 60);
            toolStripStatusLabel1.Text = @"Idle";

            var win = new InviteCreatedWindow(invite);
            win.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            ContextMenu ctx = new ContextMenu();
            // add a button "Member Info"
            var guild = _client.Guilds.ToList()[listBox1.SelectedIndex];
            var selfMember = guild.GetUser(_client.CurrentUser.Id);
            if (selfMember.GuildPermissions.CreateInstantInvite && listBox2.SelectedIndex != -1) {
                ctx.MenuItems.Add("Invite me to the server", delegate {
                    var channel = guild.TextChannels.ToList()[listBox2.SelectedIndex];
                    _ = CreateInviteAndOpen(channel);
                });
            }

            ctx.MenuItems.Add(new MenuItem("More Member Information", (o, args) => {
                if (listBox1.SelectedIndex == -1) return;
                MemberInfo memberInfo = new MemberInfo(guild);
                memberInfo.Show();
            }));
            if (selfMember.GuildPermissions.ManageRoles) {
                ctx.MenuItems.Add(new MenuItem("Manage Roles", (o, args) => {
                    if (listBox1.SelectedIndex == -1) return;
                    RoleManager manageRoles = new RoleManager(guild);
                    manageRoles.Show();
                }));
            }

            if (selfMember.GuildPermissions.ManageChannels) {
                ctx.MenuItems.Add(new MenuItem("Manage Channels", (o, args) => {
                    if (listBox1.SelectedIndex == -1) return;
                    ChannelManager manageChannels = new ChannelManager(guild);
                    manageChannels.Show();
                }));
            }

            ctx.Show(button2, button2.PointToClient(Cursor.Position));
        }

        private void listBox3_DoubleClick(object sender, EventArgs e) {
            if (listBox3.SelectedIndex > _messages.Count()) return;
            var message = _messages.Reverse().ToList()[listBox3.SelectedIndex];
            MessageInfo messageInfo = new MessageInfo(message);
            messageInfo.Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            var channel = _client.Guilds.ToList()[listBox1.SelectedIndex].TextChannels.ToList()[listBox2.SelectedIndex];
            _ = channel.SendMessageAsync(textBox1.Text);
            textBox1.Text = "";
        }
    }
}