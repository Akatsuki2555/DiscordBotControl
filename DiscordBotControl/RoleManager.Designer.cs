using System.ComponentModel;

namespace DiscordBotControl {
    partial class RoleManager {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.permViewChannels = new System.Windows.Forms.CheckBox();
            this.permManageChannels = new System.Windows.Forms.CheckBox();
            this.permManageRoles = new System.Windows.Forms.CheckBox();
            this.permAuditLog = new System.Windows.Forms.CheckBox();
            this.permAdministrator = new System.Windows.Forms.CheckBox();
            this.permWebhooks = new System.Windows.Forms.CheckBox();
            this.permManageServer = new System.Windows.Forms.CheckBox();
            this.permCreateInvite = new System.Windows.Forms.CheckBox();
            this.permChangeNickname = new System.Windows.Forms.CheckBox();
            this.permManageNicknames = new System.Windows.Forms.CheckBox();
            this.permKickMembers = new System.Windows.Forms.CheckBox();
            this.permBanMembers = new System.Windows.Forms.CheckBox();
            this.permSendMessages = new System.Windows.Forms.CheckBox();
            this.permSendMessagesThreads = new System.Windows.Forms.CheckBox();
            this.permCreatePublicThreads = new System.Windows.Forms.CheckBox();
            this.permCreatePrivateThreads = new System.Windows.Forms.CheckBox();
            this.permEmbedLinks = new System.Windows.Forms.CheckBox();
            this.permAttachFiles = new System.Windows.Forms.CheckBox();
            this.permReadMessageHistory = new System.Windows.Forms.CheckBox();
            this.permAddReactions = new System.Windows.Forms.CheckBox();
            this.permUseExternalEmojis = new System.Windows.Forms.CheckBox();
            this.permUseExternalStickers = new System.Windows.Forms.CheckBox();
            this.permEveryone = new System.Windows.Forms.CheckBox();
            this.permManageMessages = new System.Windows.Forms.CheckBox();
            this.permManageThreads = new System.Windows.Forms.CheckBox();
            this.permSendTTSMessages = new System.Windows.Forms.CheckBox();
            this.permUseApplicationCommands = new System.Windows.Forms.CheckBox();
            this.permSendVoiceMessages = new System.Windows.Forms.CheckBox();
            this.permConnect = new System.Windows.Forms.CheckBox();
            this.permSpeak = new System.Windows.Forms.CheckBox();
            this.permVideo = new System.Windows.Forms.CheckBox();
            this.permUseActivities = new System.Windows.Forms.CheckBox();
            this.permVoiceActivity = new System.Windows.Forms.CheckBox();
            this.permPrioritySpeaker = new System.Windows.Forms.CheckBox();
            this.permMuteMembers = new System.Windows.Forms.CheckBox();
            this.permDeafenMembers = new System.Windows.Forms.CheckBox();
            this.permMoveMembers = new System.Windows.Forms.CheckBox();
            this.permManageEvents = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(157, 329);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 20);
            this.textBox1.TabIndex = 1;
            // 
            // permViewChannels
            // 
            this.permViewChannels.Location = new System.Drawing.Point(175, 60);
            this.permViewChannels.Name = "permViewChannels";
            this.permViewChannels.Size = new System.Drawing.Size(123, 16);
            this.permViewChannels.TabIndex = 2;
            this.permViewChannels.Text = "View Channels";
            this.permViewChannels.UseVisualStyleBackColor = true;
            // 
            // permManageChannels
            // 
            this.permManageChannels.Location = new System.Drawing.Point(175, 82);
            this.permManageChannels.Name = "permManageChannels";
            this.permManageChannels.Size = new System.Drawing.Size(123, 16);
            this.permManageChannels.TabIndex = 3;
            this.permManageChannels.Text = "Manage Channels";
            this.permManageChannels.UseVisualStyleBackColor = true;
            // 
            // permManageRoles
            // 
            this.permManageRoles.Location = new System.Drawing.Point(175, 104);
            this.permManageRoles.Name = "permManageRoles";
            this.permManageRoles.Size = new System.Drawing.Size(123, 16);
            this.permManageRoles.TabIndex = 4;
            this.permManageRoles.Text = "Manage Roles";
            this.permManageRoles.UseVisualStyleBackColor = true;
            // 
            // permAuditLog
            // 
            this.permAuditLog.Location = new System.Drawing.Point(175, 126);
            this.permAuditLog.Name = "permAuditLog";
            this.permAuditLog.Size = new System.Drawing.Size(123, 16);
            this.permAuditLog.TabIndex = 5;
            this.permAuditLog.Text = "View Audit Log";
            this.permAuditLog.UseVisualStyleBackColor = true;
            // 
            // permAdministrator
            // 
            this.permAdministrator.Location = new System.Drawing.Point(175, 38);
            this.permAdministrator.Name = "permAdministrator";
            this.permAdministrator.Size = new System.Drawing.Size(123, 16);
            this.permAdministrator.TabIndex = 6;
            this.permAdministrator.Text = "Administrator";
            this.permAdministrator.UseVisualStyleBackColor = true;
            // 
            // permWebhooks
            // 
            this.permWebhooks.Location = new System.Drawing.Point(175, 148);
            this.permWebhooks.Name = "permWebhooks";
            this.permWebhooks.Size = new System.Drawing.Size(123, 16);
            this.permWebhooks.TabIndex = 7;
            this.permWebhooks.Text = "Manage Webhooks";
            this.permWebhooks.UseVisualStyleBackColor = true;
            // 
            // permManageServer
            // 
            this.permManageServer.Location = new System.Drawing.Point(175, 170);
            this.permManageServer.Name = "permManageServer";
            this.permManageServer.Size = new System.Drawing.Size(123, 16);
            this.permManageServer.TabIndex = 8;
            this.permManageServer.Text = "Manage Server";
            this.permManageServer.UseVisualStyleBackColor = true;
            // 
            // permCreateInvite
            // 
            this.permCreateInvite.Location = new System.Drawing.Point(175, 192);
            this.permCreateInvite.Name = "permCreateInvite";
            this.permCreateInvite.Size = new System.Drawing.Size(123, 16);
            this.permCreateInvite.TabIndex = 9;
            this.permCreateInvite.Text = "Create Invite";
            this.permCreateInvite.UseVisualStyleBackColor = true;
            // 
            // permChangeNickname
            // 
            this.permChangeNickname.Location = new System.Drawing.Point(175, 214);
            this.permChangeNickname.Name = "permChangeNickname";
            this.permChangeNickname.Size = new System.Drawing.Size(123, 16);
            this.permChangeNickname.TabIndex = 10;
            this.permChangeNickname.Text = "Change Nickname";
            this.permChangeNickname.UseVisualStyleBackColor = true;
            // 
            // permManageNicknames
            // 
            this.permManageNicknames.Location = new System.Drawing.Point(175, 236);
            this.permManageNicknames.Name = "permManageNicknames";
            this.permManageNicknames.Size = new System.Drawing.Size(123, 16);
            this.permManageNicknames.TabIndex = 11;
            this.permManageNicknames.Text = "Manage Nicknames";
            this.permManageNicknames.UseVisualStyleBackColor = true;
            // 
            // permKickMembers
            // 
            this.permKickMembers.Location = new System.Drawing.Point(175, 258);
            this.permKickMembers.Name = "permKickMembers";
            this.permKickMembers.Size = new System.Drawing.Size(123, 16);
            this.permKickMembers.TabIndex = 12;
            this.permKickMembers.Text = "Kick Members";
            this.permKickMembers.UseVisualStyleBackColor = true;
            // 
            // permBanMembers
            // 
            this.permBanMembers.Location = new System.Drawing.Point(175, 280);
            this.permBanMembers.Name = "permBanMembers";
            this.permBanMembers.Size = new System.Drawing.Size(123, 16);
            this.permBanMembers.TabIndex = 13;
            this.permBanMembers.Text = "Ban Members";
            this.permBanMembers.UseVisualStyleBackColor = true;
            // 
            // permSendMessages
            // 
            this.permSendMessages.Location = new System.Drawing.Point(175, 324);
            this.permSendMessages.Name = "permSendMessages";
            this.permSendMessages.Size = new System.Drawing.Size(123, 16);
            this.permSendMessages.TabIndex = 15;
            this.permSendMessages.Text = "Send Messages";
            this.permSendMessages.UseVisualStyleBackColor = true;
            // 
            // permSendMessagesThreads
            // 
            this.permSendMessagesThreads.Location = new System.Drawing.Point(304, 38);
            this.permSendMessagesThreads.Name = "permSendMessagesThreads";
            this.permSendMessagesThreads.Size = new System.Drawing.Size(157, 16);
            this.permSendMessagesThreads.TabIndex = 16;
            this.permSendMessagesThreads.Text = "Send Messages in Threads";
            this.permSendMessagesThreads.UseVisualStyleBackColor = true;
            // 
            // permCreatePublicThreads
            // 
            this.permCreatePublicThreads.Location = new System.Drawing.Point(304, 60);
            this.permCreatePublicThreads.Name = "permCreatePublicThreads";
            this.permCreatePublicThreads.Size = new System.Drawing.Size(137, 16);
            this.permCreatePublicThreads.TabIndex = 17;
            this.permCreatePublicThreads.Text = "Create Public Threads";
            this.permCreatePublicThreads.UseVisualStyleBackColor = true;
            // 
            // permCreatePrivateThreads
            // 
            this.permCreatePrivateThreads.Location = new System.Drawing.Point(304, 82);
            this.permCreatePrivateThreads.Name = "permCreatePrivateThreads";
            this.permCreatePrivateThreads.Size = new System.Drawing.Size(137, 16);
            this.permCreatePrivateThreads.TabIndex = 18;
            this.permCreatePrivateThreads.Text = "Create Private Threads";
            this.permCreatePrivateThreads.UseVisualStyleBackColor = true;
            // 
            // permEmbedLinks
            // 
            this.permEmbedLinks.Location = new System.Drawing.Point(304, 104);
            this.permEmbedLinks.Name = "permEmbedLinks";
            this.permEmbedLinks.Size = new System.Drawing.Size(137, 16);
            this.permEmbedLinks.TabIndex = 19;
            this.permEmbedLinks.Text = "Embed Links";
            this.permEmbedLinks.UseVisualStyleBackColor = true;
            // 
            // permAttachFiles
            // 
            this.permAttachFiles.Location = new System.Drawing.Point(304, 126);
            this.permAttachFiles.Name = "permAttachFiles";
            this.permAttachFiles.Size = new System.Drawing.Size(137, 16);
            this.permAttachFiles.TabIndex = 20;
            this.permAttachFiles.Text = "Attach Files";
            this.permAttachFiles.UseVisualStyleBackColor = true;
            // 
            // permReadMessageHistory
            // 
            this.permReadMessageHistory.Location = new System.Drawing.Point(304, 148);
            this.permReadMessageHistory.Name = "permReadMessageHistory";
            this.permReadMessageHistory.Size = new System.Drawing.Size(137, 16);
            this.permReadMessageHistory.TabIndex = 21;
            this.permReadMessageHistory.Text = "Read Message History";
            this.permReadMessageHistory.UseVisualStyleBackColor = true;
            // 
            // permAddReactions
            // 
            this.permAddReactions.Location = new System.Drawing.Point(304, 170);
            this.permAddReactions.Name = "permAddReactions";
            this.permAddReactions.Size = new System.Drawing.Size(137, 16);
            this.permAddReactions.TabIndex = 22;
            this.permAddReactions.Text = "Add Reactions";
            this.permAddReactions.UseVisualStyleBackColor = true;
            // 
            // permUseExternalEmojis
            // 
            this.permUseExternalEmojis.Location = new System.Drawing.Point(304, 192);
            this.permUseExternalEmojis.Name = "permUseExternalEmojis";
            this.permUseExternalEmojis.Size = new System.Drawing.Size(137, 16);
            this.permUseExternalEmojis.TabIndex = 23;
            this.permUseExternalEmojis.Text = "Use External Emojis";
            this.permUseExternalEmojis.UseVisualStyleBackColor = true;
            // 
            // permUseExternalStickers
            // 
            this.permUseExternalStickers.Location = new System.Drawing.Point(304, 214);
            this.permUseExternalStickers.Name = "permUseExternalStickers";
            this.permUseExternalStickers.Size = new System.Drawing.Size(137, 16);
            this.permUseExternalStickers.TabIndex = 24;
            this.permUseExternalStickers.Text = "Use External Stickers";
            this.permUseExternalStickers.UseVisualStyleBackColor = true;
            // 
            // permEveryone
            // 
            this.permEveryone.Location = new System.Drawing.Point(304, 236);
            this.permEveryone.Name = "permEveryone";
            this.permEveryone.Size = new System.Drawing.Size(137, 16);
            this.permEveryone.TabIndex = 25;
            this.permEveryone.Text = "Mention @everyone";
            this.permEveryone.UseVisualStyleBackColor = true;
            // 
            // permManageMessages
            // 
            this.permManageMessages.Location = new System.Drawing.Point(304, 258);
            this.permManageMessages.Name = "permManageMessages";
            this.permManageMessages.Size = new System.Drawing.Size(137, 16);
            this.permManageMessages.TabIndex = 26;
            this.permManageMessages.Text = "Manage Messages";
            this.permManageMessages.UseVisualStyleBackColor = true;
            // 
            // permManageThreads
            // 
            this.permManageThreads.Location = new System.Drawing.Point(304, 280);
            this.permManageThreads.Name = "permManageThreads";
            this.permManageThreads.Size = new System.Drawing.Size(137, 16);
            this.permManageThreads.TabIndex = 27;
            this.permManageThreads.Text = "Manage Threads";
            this.permManageThreads.UseVisualStyleBackColor = true;
            // 
            // permSendTTSMessages
            // 
            this.permSendTTSMessages.Location = new System.Drawing.Point(304, 302);
            this.permSendTTSMessages.Name = "permSendTTSMessages";
            this.permSendTTSMessages.Size = new System.Drawing.Size(137, 16);
            this.permSendTTSMessages.TabIndex = 28;
            this.permSendTTSMessages.Text = "Send TTS messages";
            this.permSendTTSMessages.UseVisualStyleBackColor = true;
            // 
            // permUseApplicationCommands
            // 
            this.permUseApplicationCommands.Location = new System.Drawing.Point(304, 324);
            this.permUseApplicationCommands.Name = "permUseApplicationCommands";
            this.permUseApplicationCommands.Size = new System.Drawing.Size(137, 16);
            this.permUseApplicationCommands.TabIndex = 29;
            this.permUseApplicationCommands.Text = "Use App Commands";
            this.permUseApplicationCommands.UseVisualStyleBackColor = true;
            // 
            // permSendVoiceMessages
            // 
            this.permSendVoiceMessages.Location = new System.Drawing.Point(468, 38);
            this.permSendVoiceMessages.Name = "permSendVoiceMessages";
            this.permSendVoiceMessages.Size = new System.Drawing.Size(137, 16);
            this.permSendVoiceMessages.TabIndex = 30;
            this.permSendVoiceMessages.Text = "Send Voice Messages";
            this.permSendVoiceMessages.UseVisualStyleBackColor = true;
            // 
            // permConnect
            // 
            this.permConnect.Location = new System.Drawing.Point(468, 60);
            this.permConnect.Name = "permConnect";
            this.permConnect.Size = new System.Drawing.Size(137, 16);
            this.permConnect.TabIndex = 31;
            this.permConnect.Text = "Connect";
            this.permConnect.UseVisualStyleBackColor = true;
            // 
            // permSpeak
            // 
            this.permSpeak.Location = new System.Drawing.Point(468, 82);
            this.permSpeak.Name = "permSpeak";
            this.permSpeak.Size = new System.Drawing.Size(137, 16);
            this.permSpeak.TabIndex = 32;
            this.permSpeak.Text = "Speak";
            this.permSpeak.UseVisualStyleBackColor = true;
            // 
            // permVideo
            // 
            this.permVideo.Location = new System.Drawing.Point(468, 104);
            this.permVideo.Name = "permVideo";
            this.permVideo.Size = new System.Drawing.Size(137, 16);
            this.permVideo.TabIndex = 33;
            this.permVideo.Text = "Video";
            this.permVideo.UseVisualStyleBackColor = true;
            // 
            // permUseActivities
            // 
            this.permUseActivities.Location = new System.Drawing.Point(468, 126);
            this.permUseActivities.Name = "permUseActivities";
            this.permUseActivities.Size = new System.Drawing.Size(137, 16);
            this.permUseActivities.TabIndex = 34;
            this.permUseActivities.Text = "Use Activities";
            this.permUseActivities.UseVisualStyleBackColor = true;
            // 
            // permVoiceActivity
            // 
            this.permVoiceActivity.Location = new System.Drawing.Point(468, 148);
            this.permVoiceActivity.Name = "permVoiceActivity";
            this.permVoiceActivity.Size = new System.Drawing.Size(137, 16);
            this.permVoiceActivity.TabIndex = 37;
            this.permVoiceActivity.Text = "Use Voice Activity";
            this.permVoiceActivity.UseVisualStyleBackColor = true;
            // 
            // permPrioritySpeaker
            // 
            this.permPrioritySpeaker.Location = new System.Drawing.Point(468, 170);
            this.permPrioritySpeaker.Name = "permPrioritySpeaker";
            this.permPrioritySpeaker.Size = new System.Drawing.Size(137, 16);
            this.permPrioritySpeaker.TabIndex = 38;
            this.permPrioritySpeaker.Text = "Priority Speaker";
            this.permPrioritySpeaker.UseVisualStyleBackColor = true;
            // 
            // permMuteMembers
            // 
            this.permMuteMembers.Location = new System.Drawing.Point(468, 192);
            this.permMuteMembers.Name = "permMuteMembers";
            this.permMuteMembers.Size = new System.Drawing.Size(137, 16);
            this.permMuteMembers.TabIndex = 39;
            this.permMuteMembers.Text = "Mute Members";
            this.permMuteMembers.UseVisualStyleBackColor = true;
            // 
            // permDeafenMembers
            // 
            this.permDeafenMembers.Location = new System.Drawing.Point(468, 214);
            this.permDeafenMembers.Name = "permDeafenMembers";
            this.permDeafenMembers.Size = new System.Drawing.Size(137, 16);
            this.permDeafenMembers.TabIndex = 40;
            this.permDeafenMembers.Text = "Deafen Members";
            this.permDeafenMembers.UseVisualStyleBackColor = true;
            // 
            // permMoveMembers
            // 
            this.permMoveMembers.Location = new System.Drawing.Point(468, 236);
            this.permMoveMembers.Name = "permMoveMembers";
            this.permMoveMembers.Size = new System.Drawing.Size(137, 16);
            this.permMoveMembers.TabIndex = 41;
            this.permMoveMembers.Text = "Move Members";
            this.permMoveMembers.UseVisualStyleBackColor = true;
            // 
            // permManageEvents
            // 
            this.permManageEvents.Location = new System.Drawing.Point(175, 302);
            this.permManageEvents.Name = "permManageEvents";
            this.permManageEvents.Size = new System.Drawing.Size(123, 16);
            this.permManageEvents.TabIndex = 42;
            this.permManageEvents.Text = "Manage Events";
            this.permManageEvents.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoleManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 344);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.permManageEvents);
            this.Controls.Add(this.permMoveMembers);
            this.Controls.Add(this.permDeafenMembers);
            this.Controls.Add(this.permMuteMembers);
            this.Controls.Add(this.permPrioritySpeaker);
            this.Controls.Add(this.permVoiceActivity);
            this.Controls.Add(this.permUseActivities);
            this.Controls.Add(this.permVideo);
            this.Controls.Add(this.permSpeak);
            this.Controls.Add(this.permConnect);
            this.Controls.Add(this.permSendVoiceMessages);
            this.Controls.Add(this.permUseApplicationCommands);
            this.Controls.Add(this.permSendTTSMessages);
            this.Controls.Add(this.permManageThreads);
            this.Controls.Add(this.permManageMessages);
            this.Controls.Add(this.permEveryone);
            this.Controls.Add(this.permUseExternalStickers);
            this.Controls.Add(this.permUseExternalEmojis);
            this.Controls.Add(this.permAddReactions);
            this.Controls.Add(this.permReadMessageHistory);
            this.Controls.Add(this.permAttachFiles);
            this.Controls.Add(this.permEmbedLinks);
            this.Controls.Add(this.permCreatePrivateThreads);
            this.Controls.Add(this.permCreatePublicThreads);
            this.Controls.Add(this.permSendMessagesThreads);
            this.Controls.Add(this.permSendMessages);
            this.Controls.Add(this.permBanMembers);
            this.Controls.Add(this.permKickMembers);
            this.Controls.Add(this.permManageNicknames);
            this.Controls.Add(this.permChangeNickname);
            this.Controls.Add(this.permCreateInvite);
            this.Controls.Add(this.permManageServer);
            this.Controls.Add(this.permWebhooks);
            this.Controls.Add(this.permAdministrator);
            this.Controls.Add(this.permAuditLog);
            this.Controls.Add(this.permManageRoles);
            this.Controls.Add(this.permManageChannels);
            this.Controls.Add(this.permViewChannels);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "RoleManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Role Manager";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.CheckBox permUseExternalStickers;
        private System.Windows.Forms.CheckBox permEveryone;
        private System.Windows.Forms.CheckBox permManageMessages;
        private System.Windows.Forms.CheckBox permManageThreads;
        private System.Windows.Forms.CheckBox permSendTTSMessages;
        private System.Windows.Forms.CheckBox permUseApplicationCommands;
        private System.Windows.Forms.CheckBox permSendVoiceMessages;
        private System.Windows.Forms.CheckBox permConnect;
        private System.Windows.Forms.CheckBox permSpeak;
        private System.Windows.Forms.CheckBox permVideo;
        private System.Windows.Forms.CheckBox permUseActivities;
        private System.Windows.Forms.CheckBox permVoiceActivity;
        private System.Windows.Forms.CheckBox permPrioritySpeaker;
        private System.Windows.Forms.CheckBox permMuteMembers;
        private System.Windows.Forms.CheckBox permUseExternalEmojis;
        private System.Windows.Forms.CheckBox permDeafenMembers;
        private System.Windows.Forms.CheckBox permMoveMembers;

        private System.Windows.Forms.CheckBox permCreatePrivateThreads;
        private System.Windows.Forms.CheckBox permEmbedLinks;
        private System.Windows.Forms.CheckBox permAttachFiles;
        private System.Windows.Forms.CheckBox permReadMessageHistory;
        private System.Windows.Forms.CheckBox permAddReactions;

        private System.Windows.Forms.CheckBox permCreatePublicThreads;
        private System.Windows.Forms.CheckBox permManageEvents;

        private System.Windows.Forms.CheckBox permCreateInvite;
        private System.Windows.Forms.CheckBox permChangeNickname;
        private System.Windows.Forms.CheckBox permManageNicknames;
        private System.Windows.Forms.CheckBox permKickMembers;
        private System.Windows.Forms.CheckBox permBanMembers;
        private System.Windows.Forms.CheckBox permSendMessages;
        private System.Windows.Forms.CheckBox permSendMessagesThreads;

        private System.Windows.Forms.CheckBox permAuditLog;
        private System.Windows.Forms.CheckBox permAdministrator;
        private System.Windows.Forms.CheckBox permWebhooks;
        private System.Windows.Forms.CheckBox permManageServer;

        private System.Windows.Forms.CheckBox permViewChannels;
        private System.Windows.Forms.CheckBox permManageChannels;
        private System.Windows.Forms.CheckBox permManageRoles;

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}