using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Discord;

namespace DiscordBotControl {
    public partial class MessageInfo : Form {
        private List<IEmbed> _embeds;
        private List<IAttachment> _attachments;
        public MessageInfo(IMessage message) {
            InitializeComponent();

            textBox1.Text = message.Content;
            author.Text = $@"Author: {message.Author.Username}#{message.Author.Discriminator}";
            creationDate.Text = $@"Creation date: {message.Timestamp}";
            lastEditDate.Text = $@"Last edit date: {message.EditedTimestamp}";

            _embeds = new List<IEmbed>(message.Embeds);
            foreach (var embed in message.Embeds) {
                listBox1.Items.Add(embed.Title + " | " + embed.Description);
            }

            _attachments = new List<IAttachment>(message.Attachments);
            foreach (var attachment in message.Attachments) {
                listBox2.Items.Add(attachment.Filename);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            var embed = _embeds[listBox1.SelectedIndex];
            var embedInfo = new EmbedInfo(embed);
            embedInfo.Show();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) {
            var attachment = _attachments[listBox2.SelectedIndex];
            var attachmentInfo = new AttachmentInfo(attachment);
            attachmentInfo.Show();
        }
    }
}