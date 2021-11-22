namespace Tacotron_Transcription_Auditor
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
            this.progbar = new System.Windows.Forms.ProgressBar();
            this.transcription_box = new System.Windows.Forms.RichTextBox();
            this.audio_dir_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataset_path = new System.Windows.Forms.TextBox();
            this.filename_label = new System.Windows.Forms.Label();
            this.progress_label = new System.Windows.Forms.Label();
            this.play_button = new System.Windows.Forms.Button();
            this.transcription_delete_button = new System.Windows.Forms.Button();
            this.previous_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.load_ds_button = new System.Windows.Forms.Button();
            this.save_dataset_button = new System.Windows.Forms.Button();
            this.autoplay_check = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.audited_save_loc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progbar
            // 
            this.progbar.Location = new System.Drawing.Point(11, 486);
            this.progbar.Name = "progbar";
            this.progbar.Size = new System.Drawing.Size(483, 23);
            this.progbar.TabIndex = 0;
            this.progbar.Value = 68;
            // 
            // transcription_box
            // 
            this.transcription_box.Enabled = false;
            this.transcription_box.Location = new System.Drawing.Point(12, 149);
            this.transcription_box.Name = "transcription_box";
            this.transcription_box.Size = new System.Drawing.Size(483, 302);
            this.transcription_box.TabIndex = 1;
            this.transcription_box.Text = "Transcription Line Goes Here";
            // 
            // audio_dir_path
            // 
            this.audio_dir_path.Location = new System.Drawing.Point(12, 25);
            this.audio_dir_path.Name = "audio_dir_path";
            this.audio_dir_path.Size = new System.Drawing.Size(482, 20);
            this.audio_dir_path.TabIndex = 2;
            this.audio_dir_path.Text = "C:/path/to/dataset/audio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Audio Directory Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dataset Path";
            // 
            // dataset_path
            // 
            this.dataset_path.Location = new System.Drawing.Point(12, 68);
            this.dataset_path.Name = "dataset_path";
            this.dataset_path.Size = new System.Drawing.Size(482, 20);
            this.dataset_path.TabIndex = 4;
            this.dataset_path.Text = "C:/path/to/dataset/file.txt";
            // 
            // filename_label
            // 
            this.filename_label.AutoSize = true;
            this.filename_label.Location = new System.Drawing.Point(15, 458);
            this.filename_label.Name = "filename_label";
            this.filename_label.Size = new System.Drawing.Size(75, 13);
            this.filename_label.TabIndex = 6;
            this.filename_label.Text = "file_name.wav";
            this.filename_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progress_label
            // 
            this.progress_label.AutoSize = true;
            this.progress_label.Location = new System.Drawing.Point(220, 458);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(80, 13);
            this.progress_label.TabIndex = 7;
            this.progress_label.Text = "Progess: X of Y";
            this.progress_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.progress_label.Click += new System.EventHandler(this.label4_Click);
            // 
            // play_button
            // 
            this.play_button.Enabled = false;
            this.play_button.Location = new System.Drawing.Point(5, 516);
            this.play_button.Name = "play_button";
            this.play_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.play_button.Size = new System.Drawing.Size(156, 95);
            this.play_button.TabIndex = 10;
            this.play_button.Text = "Play\r\n(End)";
            this.play_button.UseVisualStyleBackColor = true;
            this.play_button.Click += new System.EventHandler(this.play_button_Click);
            // 
            // transcription_delete_button
            // 
            this.transcription_delete_button.Enabled = false;
            this.transcription_delete_button.Location = new System.Drawing.Point(167, 516);
            this.transcription_delete_button.Name = "transcription_delete_button";
            this.transcription_delete_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.transcription_delete_button.Size = new System.Drawing.Size(79, 95);
            this.transcription_delete_button.TabIndex = 12;
            this.transcription_delete_button.Text = "Remove Transcription\r\n(Delete)";
            this.transcription_delete_button.UseVisualStyleBackColor = true;
            this.transcription_delete_button.Click += new System.EventHandler(this.transcription_delete_button_Click);
            // 
            // previous_button
            // 
            this.previous_button.Enabled = false;
            this.previous_button.Location = new System.Drawing.Point(252, 516);
            this.previous_button.Name = "previous_button";
            this.previous_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.previous_button.Size = new System.Drawing.Size(79, 95);
            this.previous_button.TabIndex = 13;
            this.previous_button.Text = "Previous Audio\r\n(Pg Up)";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.previous_button_Click);
            // 
            // next_button
            // 
            this.next_button.Enabled = false;
            this.next_button.Location = new System.Drawing.Point(337, 516);
            this.next_button.Name = "next_button";
            this.next_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.next_button.Size = new System.Drawing.Size(79, 95);
            this.next_button.TabIndex = 14;
            this.next_button.Text = "Next Audio\r\n(Pg Down)";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // load_ds_button
            // 
            this.load_ds_button.Location = new System.Drawing.Point(423, 516);
            this.load_ds_button.Name = "load_ds_button";
            this.load_ds_button.Size = new System.Drawing.Size(75, 37);
            this.load_ds_button.TabIndex = 15;
            this.load_ds_button.Text = "Load DS";
            this.load_ds_button.UseVisualStyleBackColor = true;
            this.load_ds_button.Click += new System.EventHandler(this.load_ds_button_Click);
            // 
            // save_dataset_button
            // 
            this.save_dataset_button.Enabled = false;
            this.save_dataset_button.Location = new System.Drawing.Point(423, 559);
            this.save_dataset_button.Name = "save_dataset_button";
            this.save_dataset_button.Size = new System.Drawing.Size(75, 52);
            this.save_dataset_button.TabIndex = 16;
            this.save_dataset_button.Text = "Save Dataset";
            this.save_dataset_button.UseVisualStyleBackColor = true;
            this.save_dataset_button.Click += new System.EventHandler(this.save_dataset_button_Click);
            // 
            // autoplay_check
            // 
            this.autoplay_check.AutoSize = true;
            this.autoplay_check.Location = new System.Drawing.Point(12, 133);
            this.autoplay_check.Name = "autoplay_check";
            this.autoplay_check.Size = new System.Drawing.Size(149, 17);
            this.autoplay_check.TabIndex = 17;
            this.autoplay_check.Text = "Autoplay On Audio Switch";
            this.autoplay_check.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Save Location";
            // 
            // audited_save_loc
            // 
            this.audited_save_loc.Location = new System.Drawing.Point(14, 107);
            this.audited_save_loc.Name = "audited_save_loc";
            this.audited_save_loc.Size = new System.Drawing.Size(482, 20);
            this.audited_save_loc.TabIndex = 19;
            this.audited_save_loc.Text = "C:/path/to/dataset/file_audited_dataset.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 623);
            this.Controls.Add(this.audited_save_loc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.autoplay_check);
            this.Controls.Add(this.save_dataset_button);
            this.Controls.Add(this.load_ds_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.transcription_delete_button);
            this.Controls.Add(this.play_button);
            this.Controls.Add(this.progress_label);
            this.Controls.Add(this.filename_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataset_path);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.audio_dir_path);
            this.Controls.Add(this.transcription_box);
            this.Controls.Add(this.progbar);
            this.Name = "Form1";
            this.Text = "Tacotron Transcription Processor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progbar;
        private System.Windows.Forms.RichTextBox transcription_box;
        private System.Windows.Forms.TextBox audio_dir_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dataset_path;
        private System.Windows.Forms.Label filename_label;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.Button play_button;
        private System.Windows.Forms.Button transcription_delete_button;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.Button load_ds_button;
        private System.Windows.Forms.Button save_dataset_button;
        private System.Windows.Forms.CheckBox autoplay_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox audited_save_loc;
    }
}

