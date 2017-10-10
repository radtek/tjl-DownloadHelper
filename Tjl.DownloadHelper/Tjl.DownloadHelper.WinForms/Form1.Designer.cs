namespace Tjl.DownloadHelper.WinForms
{
   partial class Form1
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.txtUrlSource = new System.Windows.Forms.TextBox();
         this.lblUrlSource = new System.Windows.Forms.Label();
         this.btnDo = new System.Windows.Forms.Button();
         this.txtAdditionalInfo = new System.Windows.Forms.TextBox();
         this.txtFilePathTarget = new System.Windows.Forms.TextBox();
         this.txtMediaDirRelativeWithoutYoutubeId = new System.Windows.Forms.TextBox();
         this.txtDownloadTool = new System.Windows.Forms.TextBox();
         this.lblDownloadTool = new System.Windows.Forms.Label();
         this.lblMediaDirRelativeWithoutYoutubeId = new System.Windows.Forms.Label();
         this.txtMediaFormat = new System.Windows.Forms.TextBox();
         this.lblMediaFormat = new System.Windows.Forms.Label();
         this.txtMediaFilePublisher = new System.Windows.Forms.TextBox();
         this.lblMediaFilePublisher = new System.Windows.Forms.Label();
         this.txtMediaLength = new System.Windows.Forms.TextBox();
         this.lblMediaLength = new System.Windows.Forms.Label();
         this.txtOriginalPublisher = new System.Windows.Forms.TextBox();
         this.lblOriginaPublisher = new System.Windows.Forms.Label();
         this.lblAdditionalInfo = new System.Windows.Forms.Label();
         this.btnCopyMediaLinkToClipboard = new System.Windows.Forms.Button();
         this.txtMediaFolderBase = new System.Windows.Forms.TextBox();
         this.lblMediaFolderBase = new System.Windows.Forms.Label();
         this.lblMediaLink = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // txtUrlSource
         // 
         this.txtUrlSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtUrlSource.Location = new System.Drawing.Point(115, 12);
         this.txtUrlSource.Name = "txtUrlSource";
         this.txtUrlSource.Size = new System.Drawing.Size(745, 20);
         this.txtUrlSource.TabIndex = 0;
         // 
         // lblUrlSource
         // 
         this.lblUrlSource.AutoSize = true;
         this.lblUrlSource.Location = new System.Drawing.Point(39, 15);
         this.lblUrlSource.Name = "lblUrlSource";
         this.lblUrlSource.Size = new System.Drawing.Size(70, 13);
         this.lblUrlSource.TabIndex = 1;
         this.lblUrlSource.Text = "YouTube Url:";
         // 
         // btnDo
         // 
         this.btnDo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnDo.Location = new System.Drawing.Point(785, 581);
         this.btnDo.Name = "btnDo";
         this.btnDo.Size = new System.Drawing.Size(75, 23);
         this.btnDo.TabIndex = 3;
         this.btnDo.Text = "Create";
         this.btnDo.UseVisualStyleBackColor = true;
         this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
         // 
         // txtAdditionalInfo
         // 
         this.txtAdditionalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtAdditionalInfo.Location = new System.Drawing.Point(115, 198);
         this.txtAdditionalInfo.Multiline = true;
         this.txtAdditionalInfo.Name = "txtAdditionalInfo";
         this.txtAdditionalInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtAdditionalInfo.Size = new System.Drawing.Size(746, 322);
         this.txtAdditionalInfo.TabIndex = 4;
         this.txtAdditionalInfo.WordWrap = false;
         // 
         // txtFilePathTarget
         // 
         this.txtFilePathTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtFilePathTarget.Location = new System.Drawing.Point(115, 552);
         this.txtFilePathTarget.Name = "txtFilePathTarget";
         this.txtFilePathTarget.ReadOnly = true;
         this.txtFilePathTarget.Size = new System.Drawing.Size(717, 20);
         this.txtFilePathTarget.TabIndex = 5;
         // 
         // txtMediaDirRelativeWithoutYoutubeId
         // 
         this.txtMediaDirRelativeWithoutYoutubeId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtMediaDirRelativeWithoutYoutubeId.Location = new System.Drawing.Point(115, 38);
         this.txtMediaDirRelativeWithoutYoutubeId.Name = "txtMediaDirRelativeWithoutYoutubeId";
         this.txtMediaDirRelativeWithoutYoutubeId.Size = new System.Drawing.Size(745, 20);
         this.txtMediaDirRelativeWithoutYoutubeId.TabIndex = 6;
         // 
         // txtDownloadTool
         // 
         this.txtDownloadTool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtDownloadTool.Location = new System.Drawing.Point(115, 63);
         this.txtDownloadTool.Name = "txtDownloadTool";
         this.txtDownloadTool.Size = new System.Drawing.Size(745, 20);
         this.txtDownloadTool.TabIndex = 6;
         // 
         // lblDownloadTool
         // 
         this.lblDownloadTool.AutoSize = true;
         this.lblDownloadTool.Location = new System.Drawing.Point(27, 66);
         this.lblDownloadTool.Name = "lblDownloadTool";
         this.lblDownloadTool.Size = new System.Drawing.Size(82, 13);
         this.lblDownloadTool.TabIndex = 1;
         this.lblDownloadTool.Text = "Download Tool:";
         // 
         // lblMediaDirRelativeWithoutYoutubeId
         // 
         this.lblMediaDirRelativeWithoutYoutubeId.AutoSize = true;
         this.lblMediaDirRelativeWithoutYoutubeId.Location = new System.Drawing.Point(48, 41);
         this.lblMediaDirRelativeWithoutYoutubeId.Name = "lblMediaDirRelativeWithoutYoutubeId";
         this.lblMediaDirRelativeWithoutYoutubeId.Size = new System.Drawing.Size(61, 13);
         this.lblMediaDirRelativeWithoutYoutubeId.TabIndex = 1;
         this.lblMediaDirRelativeWithoutYoutubeId.Text = "Item Name:";
         // 
         // txtMediaFormat
         // 
         this.txtMediaFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtMediaFormat.Location = new System.Drawing.Point(115, 94);
         this.txtMediaFormat.Name = "txtMediaFormat";
         this.txtMediaFormat.Size = new System.Drawing.Size(745, 20);
         this.txtMediaFormat.TabIndex = 6;
         // 
         // lblMediaFormat
         // 
         this.lblMediaFormat.AutoSize = true;
         this.lblMediaFormat.Location = new System.Drawing.Point(35, 96);
         this.lblMediaFormat.Name = "lblMediaFormat";
         this.lblMediaFormat.Size = new System.Drawing.Size(74, 13);
         this.lblMediaFormat.TabIndex = 7;
         this.lblMediaFormat.Text = "Media Format:";
         // 
         // txtMediaFilePublisher
         // 
         this.txtMediaFilePublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtMediaFilePublisher.Location = new System.Drawing.Point(116, 120);
         this.txtMediaFilePublisher.Name = "txtMediaFilePublisher";
         this.txtMediaFilePublisher.Size = new System.Drawing.Size(745, 20);
         this.txtMediaFilePublisher.TabIndex = 8;
         // 
         // lblMediaFilePublisher
         // 
         this.lblMediaFilePublisher.AutoSize = true;
         this.lblMediaFilePublisher.Location = new System.Drawing.Point(9, 122);
         this.lblMediaFilePublisher.Name = "lblMediaFilePublisher";
         this.lblMediaFilePublisher.Size = new System.Drawing.Size(100, 13);
         this.lblMediaFilePublisher.TabIndex = 7;
         this.lblMediaFilePublisher.Text = "YouTube Publisher:";
         // 
         // txtMediaLength
         // 
         this.txtMediaLength.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtMediaLength.Location = new System.Drawing.Point(115, 146);
         this.txtMediaLength.Name = "txtMediaLength";
         this.txtMediaLength.Size = new System.Drawing.Size(746, 20);
         this.txtMediaLength.TabIndex = 8;
         // 
         // lblMediaLength
         // 
         this.lblMediaLength.AutoSize = true;
         this.lblMediaLength.Location = new System.Drawing.Point(34, 149);
         this.lblMediaLength.Name = "lblMediaLength";
         this.lblMediaLength.Size = new System.Drawing.Size(75, 13);
         this.lblMediaLength.TabIndex = 9;
         this.lblMediaLength.Text = "Media Length:";
         // 
         // txtOriginalPublisher
         // 
         this.txtOriginalPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtOriginalPublisher.Location = new System.Drawing.Point(115, 172);
         this.txtOriginalPublisher.Name = "txtOriginalPublisher";
         this.txtOriginalPublisher.Size = new System.Drawing.Size(745, 20);
         this.txtOriginalPublisher.TabIndex = 10;
         // 
         // lblOriginaPublisher
         // 
         this.lblOriginaPublisher.AutoSize = true;
         this.lblOriginaPublisher.Location = new System.Drawing.Point(18, 175);
         this.lblOriginaPublisher.Name = "lblOriginaPublisher";
         this.lblOriginaPublisher.Size = new System.Drawing.Size(91, 13);
         this.lblOriginaPublisher.TabIndex = 11;
         this.lblOriginaPublisher.Text = "Original Publisher:";
         // 
         // lblAdditionalInfo
         // 
         this.lblAdditionalInfo.AutoSize = true;
         this.lblAdditionalInfo.Location = new System.Drawing.Point(32, 201);
         this.lblAdditionalInfo.Name = "lblAdditionalInfo";
         this.lblAdditionalInfo.Size = new System.Drawing.Size(77, 13);
         this.lblAdditionalInfo.TabIndex = 12;
         this.lblAdditionalInfo.Text = "Additional Info:";
         // 
         // btnCopyMediaLinkToClipboard
         // 
         this.btnCopyMediaLinkToClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
         this.btnCopyMediaLinkToClipboard.Image = global::Tjl.DownloadHelper.WinForms.Properties.Resources.copy;
         this.btnCopyMediaLinkToClipboard.Location = new System.Drawing.Point(838, 552);
         this.btnCopyMediaLinkToClipboard.Name = "btnCopyMediaLinkToClipboard";
         this.btnCopyMediaLinkToClipboard.Size = new System.Drawing.Size(21, 20);
         this.btnCopyMediaLinkToClipboard.TabIndex = 13;
         this.btnCopyMediaLinkToClipboard.UseVisualStyleBackColor = true;
         this.btnCopyMediaLinkToClipboard.Click += new System.EventHandler(this.btnCopyMediaLinkToClipboard_Click);
         // 
         // txtMediaFolderBase
         // 
         this.txtMediaFolderBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.txtMediaFolderBase.Location = new System.Drawing.Point(115, 526);
         this.txtMediaFolderBase.Name = "txtMediaFolderBase";
         this.txtMediaFolderBase.Size = new System.Drawing.Size(745, 20);
         this.txtMediaFolderBase.TabIndex = 14;
         // 
         // lblMediaFolderBase
         // 
         this.lblMediaFolderBase.AutoSize = true;
         this.lblMediaFolderBase.Location = new System.Drawing.Point(13, 529);
         this.lblMediaFolderBase.Name = "lblMediaFolderBase";
         this.lblMediaFolderBase.Size = new System.Drawing.Size(97, 13);
         this.lblMediaFolderBase.TabIndex = 15;
         this.lblMediaFolderBase.Text = "Media Folder Root:";
         // 
         // lblMediaLink
         // 
         this.lblMediaLink.AutoSize = true;
         this.lblMediaLink.Location = new System.Drawing.Point(47, 555);
         this.lblMediaLink.Name = "lblMediaLink";
         this.lblMediaLink.Size = new System.Drawing.Size(62, 13);
         this.lblMediaLink.TabIndex = 16;
         this.lblMediaLink.Text = "Media Link:";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(872, 610);
         this.Controls.Add(this.lblMediaLink);
         this.Controls.Add(this.lblMediaFolderBase);
         this.Controls.Add(this.txtMediaFolderBase);
         this.Controls.Add(this.btnCopyMediaLinkToClipboard);
         this.Controls.Add(this.lblAdditionalInfo);
         this.Controls.Add(this.lblOriginaPublisher);
         this.Controls.Add(this.txtOriginalPublisher);
         this.Controls.Add(this.lblMediaLength);
         this.Controls.Add(this.txtMediaLength);
         this.Controls.Add(this.txtMediaFilePublisher);
         this.Controls.Add(this.lblMediaFilePublisher);
         this.Controls.Add(this.lblMediaFormat);
         this.Controls.Add(this.txtDownloadTool);
         this.Controls.Add(this.txtMediaFormat);
         this.Controls.Add(this.txtMediaDirRelativeWithoutYoutubeId);
         this.Controls.Add(this.txtFilePathTarget);
         this.Controls.Add(this.txtAdditionalInfo);
         this.Controls.Add(this.btnDo);
         this.Controls.Add(this.lblMediaDirRelativeWithoutYoutubeId);
         this.Controls.Add(this.lblDownloadTool);
         this.Controls.Add(this.lblUrlSource);
         this.Controls.Add(this.txtUrlSource);
         this.Name = "Form1";
         this.Text = "Form1";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox txtUrlSource;
      private System.Windows.Forms.Label lblUrlSource;
      private System.Windows.Forms.Button btnDo;
      private System.Windows.Forms.TextBox txtAdditionalInfo;
      private System.Windows.Forms.TextBox txtFilePathTarget;
      private System.Windows.Forms.TextBox txtMediaDirRelativeWithoutYoutubeId;
      private System.Windows.Forms.TextBox txtDownloadTool;
      private System.Windows.Forms.Label lblDownloadTool;
      private System.Windows.Forms.Label lblMediaDirRelativeWithoutYoutubeId;
      private System.Windows.Forms.TextBox txtMediaFormat;
      private System.Windows.Forms.Label lblMediaFormat;
      private System.Windows.Forms.TextBox txtMediaFilePublisher;
      private System.Windows.Forms.Label lblMediaFilePublisher;
      private System.Windows.Forms.TextBox txtMediaLength;
      private System.Windows.Forms.Label lblMediaLength;
      private System.Windows.Forms.TextBox txtOriginalPublisher;
      private System.Windows.Forms.Label lblOriginaPublisher;
      private System.Windows.Forms.Label lblAdditionalInfo;
      private System.Windows.Forms.Button btnCopyMediaLinkToClipboard;
      private System.Windows.Forms.TextBox txtMediaFolderBase;
      private System.Windows.Forms.Label lblMediaFolderBase;
      private System.Windows.Forms.Label lblMediaLink;
   }
}

