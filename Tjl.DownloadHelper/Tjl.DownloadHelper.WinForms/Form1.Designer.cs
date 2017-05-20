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
         this.txtSourceMediaId = new System.Windows.Forms.TextBox();
         this.btnDo = new System.Windows.Forms.Button();
         this.txtAdditionalInfo = new System.Windows.Forms.TextBox();
         this.txtFilePathTarget = new System.Windows.Forms.TextBox();
         this.txtMediaDirRelativeWithoutYoutubeId = new System.Windows.Forms.TextBox();
         this.txtDownloadTool = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // txtUrlSource
         // 
         this.txtUrlSource.Location = new System.Drawing.Point(151, 12);
         this.txtUrlSource.Name = "txtUrlSource";
         this.txtUrlSource.Size = new System.Drawing.Size(425, 20);
         this.txtUrlSource.TabIndex = 0;
         // 
         // lblUrlSource
         // 
         this.lblUrlSource.AutoSize = true;
         this.lblUrlSource.Location = new System.Drawing.Point(75, 15);
         this.lblUrlSource.Name = "lblUrlSource";
         this.lblUrlSource.Size = new System.Drawing.Size(70, 13);
         this.lblUrlSource.TabIndex = 1;
         this.lblUrlSource.Text = "YouTube Url:";
         // 
         // txtSourceMediaId
         // 
         this.txtSourceMediaId.Location = new System.Drawing.Point(653, 12);
         this.txtSourceMediaId.Name = "txtSourceMediaId";
         this.txtSourceMediaId.Size = new System.Drawing.Size(100, 20);
         this.txtSourceMediaId.TabIndex = 2;
         // 
         // btnDo
         // 
         this.btnDo.Location = new System.Drawing.Point(678, 603);
         this.btnDo.Name = "btnDo";
         this.btnDo.Size = new System.Drawing.Size(75, 23);
         this.btnDo.TabIndex = 3;
         this.btnDo.Text = "Do!";
         this.btnDo.UseVisualStyleBackColor = true;
         this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
         // 
         // txtAdditionalInfo
         // 
         this.txtAdditionalInfo.Location = new System.Drawing.Point(151, 118);
         this.txtAdditionalInfo.Multiline = true;
         this.txtAdditionalInfo.Name = "txtAdditionalInfo";
         this.txtAdditionalInfo.ScrollBars = System.Windows.Forms.ScrollBars.Both;
         this.txtAdditionalInfo.Size = new System.Drawing.Size(602, 455);
         this.txtAdditionalInfo.TabIndex = 4;
         this.txtAdditionalInfo.WordWrap = false;
         // 
         // txtFilePathTarget
         // 
         this.txtFilePathTarget.Location = new System.Drawing.Point(151, 579);
         this.txtFilePathTarget.Name = "txtFilePathTarget";
         this.txtFilePathTarget.Size = new System.Drawing.Size(601, 20);
         this.txtFilePathTarget.TabIndex = 5;
         // 
         // txtMediaDirRelativeWithoutYoutubeId
         // 
         this.txtMediaDirRelativeWithoutYoutubeId.Location = new System.Drawing.Point(151, 67);
         this.txtMediaDirRelativeWithoutYoutubeId.Name = "txtMediaDirRelativeWithoutYoutubeId";
         this.txtMediaDirRelativeWithoutYoutubeId.Size = new System.Drawing.Size(425, 20);
         this.txtMediaDirRelativeWithoutYoutubeId.TabIndex = 6;
         // 
         // txtDownloadTool
         // 
         this.txtDownloadTool.Location = new System.Drawing.Point(151, 41);
         this.txtDownloadTool.Name = "txtDownloadTool";
         this.txtDownloadTool.Size = new System.Drawing.Size(425, 20);
         this.txtDownloadTool.TabIndex = 6;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(764, 638);
         this.Controls.Add(this.txtDownloadTool);
         this.Controls.Add(this.txtMediaDirRelativeWithoutYoutubeId);
         this.Controls.Add(this.txtFilePathTarget);
         this.Controls.Add(this.txtAdditionalInfo);
         this.Controls.Add(this.btnDo);
         this.Controls.Add(this.txtSourceMediaId);
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
      private System.Windows.Forms.TextBox txtSourceMediaId;
      private System.Windows.Forms.Button btnDo;
      private System.Windows.Forms.TextBox txtAdditionalInfo;
      private System.Windows.Forms.TextBox txtFilePathTarget;
      private System.Windows.Forms.TextBox txtMediaDirRelativeWithoutYoutubeId;
      private System.Windows.Forms.TextBox txtDownloadTool;
   }
}

