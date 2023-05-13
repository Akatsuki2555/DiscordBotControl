using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Discord;

namespace DiscordBotControl {
    public partial class RoleManager : Form {
        List<IRole> _roles;

        public RoleManager(IGuild guild) {
            InitializeComponent();
            _roles = guild.Roles.ToList();

            foreach (var role in _roles) {
                listBox1.Items.Add(role.Name);
            }

            //select first item
            listBox1.SelectedIndex = 0;
            RefreshPermissionCheckboxes();
        }

        private void RefreshPermissionCheckboxes() {
            var role = _roles[listBox1.SelectedIndex];
            textBox1.Text = role.Name;
            permAdministrator.Checked = role.Permissions.Administrator;
            permViewChannels.Checked = role.Permissions.ViewChannel;
            permManageChannels.Checked = role.Permissions.ManageChannels;
            permManageEvents.Checked = role.Permissions.ManageEvents;
            permManageNicknames.Checked = role.Permissions.ManageNicknames;
            permManageRoles.Checked = role.Permissions.ManageRoles;
            permManageThreads.Checked = role.Permissions.ManageThreads;
            permManageServer.Checked = role.Permissions.ManageGuild;
            permAuditLog.Checked = role.Permissions.ViewAuditLog;
            permWebhooks.Checked = role.Permissions.ManageWebhooks;
            permCreateInvite.Checked = role.Permissions.CreateInstantInvite;
            permChangeNickname.Checked = role.Permissions.ChangeNickname;
            permKickMembers.Checked = role.Permissions.KickMembers;
            permBanMembers.Checked = role.Permissions.BanMembers;
            permSendMessages.Checked = role.Permissions.SendMessages;
            permSendMessagesThreads.Checked = role.Permissions.SendMessagesInThreads;
            permCreatePublicThreads.Checked = role.Permissions.CreatePublicThreads;
            permCreatePrivateThreads.Checked = role.Permissions.CreatePrivateThreads;
            permEmbedLinks.Checked = role.Permissions.EmbedLinks;
            permAttachFiles.Checked = role.Permissions.AttachFiles;
            permReadMessageHistory.Checked = role.Permissions.ReadMessageHistory;
            permAddReactions.Checked = role.Permissions.AddReactions;
            permUseExternalEmojis.Checked = role.Permissions.UseExternalEmojis;
            permUseExternalStickers.Checked = role.Permissions.UseExternalStickers;
            permEveryone.Checked = role.Permissions.MentionEveryone;
            permSendTTSMessages.Checked = role.Permissions.SendTTSMessages;
            permUseApplicationCommands.Checked = role.Permissions.UseApplicationCommands;
            permConnect.Checked = role.Permissions.Connect;
            permSpeak.Checked = role.Permissions.Speak;
            permVideo.Checked = role.Permissions.Stream;
            permUseActivities.Checked = role.Permissions.StartEmbeddedActivities;
            permVoiceActivity.Checked = role.Permissions.UseVAD;
            permPrioritySpeaker.Checked = role.Permissions.PrioritySpeaker;
            permMuteMembers.Checked = role.Permissions.MuteMembers;
            permDeafenMembers.Checked = role.Permissions.DeafenMembers;
            permMoveMembers.Checked = role.Permissions.MoveMembers;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            RefreshPermissionCheckboxes();
        }

        private void button1_Click(object sender, EventArgs e) {
            //save the changed checkboxes
            var role = _roles[listBox1.SelectedIndex];
            _ = role.ModifyAsync(x => {
                x.Name = textBox1.Text;
                x.Permissions = x.Permissions.Value.Modify(
                    createInstantInvite: permCreateInvite.Checked,
                    kickMembers: permKickMembers.Checked,
                    banMembers: permBanMembers.Checked,
                    administrator: permAdministrator.Checked,
                    manageChannels: permManageChannels.Checked,
                    manageGuild: permManageServer.Checked,
                    addReactions: permAddReactions.Checked,
                    viewAuditLog: permAuditLog.Checked,
                    prioritySpeaker: permPrioritySpeaker.Checked,
                    stream: permVideo.Checked,
                    viewChannel: permViewChannels.Checked,
                    sendMessages: permSendMessages.Checked,
                    sendTTSMessages: permSendTTSMessages.Checked,
                    manageMessages: permManageEvents.Checked,
                    embedLinks: permEmbedLinks.Checked,
                    attachFiles: permAttachFiles.Checked,
                    readMessageHistory: permReadMessageHistory.Checked,
                    mentionEveryone: permEveryone.Checked,
                    useExternalEmojis: permUseExternalEmojis.Checked,
                    connect: permConnect.Checked,
                    speak: permSpeak.Checked,
                    muteMembers: permMuteMembers.Checked,
                    deafenMembers: permDeafenMembers.Checked,
                    moveMembers: permMoveMembers.Checked,
                    useVoiceActivation: permVoiceActivity.Checked,
                    changeNickname: permChangeNickname.Checked,
                    manageNicknames: permManageNicknames.Checked,
                    manageRoles: permManageRoles.Checked,
                    manageWebhooks: permWebhooks.Checked,
                    manageThreads: permManageThreads.Checked,
                    createPublicThreads: permCreatePublicThreads.Checked,
                    createPrivateThreads: permCreatePrivateThreads.Checked,
                    useExternalStickers: permUseExternalStickers.Checked,
                    useApplicationCommands: permUseApplicationCommands.Checked,
                    startEmbeddedActivities: permUseActivities.Checked,
                    sendMessagesInThreads: permSendMessagesThreads.Checked
                );
            });
        }
    }
}