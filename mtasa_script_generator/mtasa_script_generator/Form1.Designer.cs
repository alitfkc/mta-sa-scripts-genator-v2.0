using System.Drawing;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace mtasa_script_generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            txd_edit = new TextBox();
            label1 = new Label();
            txd_button = new Button();
            dff_button = new Button();
            dff_edit = new TextBox();
            dff_label = new Label();
            line_btn = new Button();
            veh_radio_btn = new RadioButton();
            ped_radio_btn = new RadioButton();
            object_radio_btn = new RadioButton();
            weapon_radio_btn = new RadioButton();
            save_btn = new Button();
            line_btn_2 = new Button();
            id_edit = new TextBox();
            label2 = new Label();
            label3 = new Label();
            acl_edit = new TextBox();
            label4 = new Label();
            data_edit = new TextBox();
            create_btn = new Button();
            acl_mode_chck = new CheckBox();
            data_mode_chck = new CheckBox();
            title = new Label();
            logo_img = new PictureBox();
            dc_img = new PictureBox();
            github_img = new PictureBox();
            txd_select = new OpenFileDialog();
            dff_select = new OpenFileDialog();
            save_loc = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)logo_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dc_img).BeginInit();
            ((System.ComponentModel.ISupportInitialize)github_img).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.BlueViolet;
            button1.Location = new Point(524, -6);
            button1.Name = "button1";
            button1.Size = new Size(32, 34);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sitka Small", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.BlueViolet;
            button2.Location = new Point(495, -6);
            button2.Name = "button2";
            button2.Size = new Size(32, 34);
            button2.TabIndex = 1;
            button2.Text = "—";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // txd_edit
            // 
            txd_edit.BackColor = Color.FromArgb(40, 40, 40);
            txd_edit.BorderStyle = BorderStyle.None;
            txd_edit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txd_edit.ForeColor = Color.White;
            txd_edit.Location = new Point(22, 61);
            txd_edit.Name = "txd_edit";
            txd_edit.Size = new Size(119, 19);
            txd_edit.TabIndex = 2;
            txd_edit.TextChanged += txd_edit_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 45);
            label1.Name = "label1";
            label1.Size = new Size(29, 13);
            label1.TabIndex = 3;
            label1.Text = "TXD";
            // 
            // txd_button
            // 
            txd_button.BackColor = Color.BlueViolet;
            txd_button.BackgroundImageLayout = ImageLayout.Center;
            txd_button.FlatAppearance.BorderSize = 0;
            txd_button.FlatStyle = FlatStyle.Flat;
            txd_button.Location = new Point(156, 63);
            txd_button.Name = "txd_button";
            txd_button.Size = new Size(110, 19);
            txd_button.TabIndex = 4;
            txd_button.Text = "Select TXD File";
            txd_button.UseVisualStyleBackColor = false;
            txd_button.Click += txd_button_Click;
            // 
            // dff_button
            // 
            dff_button.BackColor = Color.BlueViolet;
            dff_button.BackgroundImageLayout = ImageLayout.Center;
            dff_button.FlatAppearance.BorderSize = 0;
            dff_button.FlatStyle = FlatStyle.Flat;
            dff_button.Location = new Point(156, 114);
            dff_button.Name = "dff_button";
            dff_button.Size = new Size(110, 19);
            dff_button.TabIndex = 6;
            dff_button.Text = "Select DFF File";
            dff_button.UseVisualStyleBackColor = false;
            dff_button.Click += dff_button_Click;
            // 
            // dff_edit
            // 
            dff_edit.BackColor = Color.FromArgb(40, 40, 40);
            dff_edit.BorderStyle = BorderStyle.None;
            dff_edit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dff_edit.ForeColor = Color.White;
            dff_edit.Location = new Point(22, 114);
            dff_edit.Name = "dff_edit";
            dff_edit.Size = new Size(119, 19);
            dff_edit.TabIndex = 5;
            dff_edit.TextChanged += dff_edit_TextChanged;
            // 
            // dff_label
            // 
            dff_label.AutoSize = true;
            dff_label.Location = new Point(60, 98);
            dff_label.Name = "dff_label";
            dff_label.Size = new Size(27, 13);
            dff_label.TabIndex = 7;
            dff_label.Text = "DFF";
            // 
            // line_btn
            // 
            line_btn.BackColor = Color.BlueViolet;
            line_btn.BackgroundImageLayout = ImageLayout.Center;
            line_btn.FlatAppearance.BorderSize = 0;
            line_btn.FlatStyle = FlatStyle.Flat;
            line_btn.Location = new Point(22, 163);
            line_btn.Name = "line_btn";
            line_btn.Size = new Size(244, 4);
            line_btn.TabIndex = 8;
            line_btn.UseVisualStyleBackColor = false;
            // 
            // veh_radio_btn
            // 
            veh_radio_btn.AutoSize = true;
            veh_radio_btn.Checked = true;
            veh_radio_btn.Location = new Point(22, 185);
            veh_radio_btn.Name = "veh_radio_btn";
            veh_radio_btn.Size = new Size(60, 17);
            veh_radio_btn.TabIndex = 9;
            veh_radio_btn.TabStop = true;
            veh_radio_btn.Text = "Vehicle";
            veh_radio_btn.UseVisualStyleBackColor = true;
            veh_radio_btn.CheckedChanged += veh_radio_btn_CheckedChanged;
            // 
            // ped_radio_btn
            // 
            ped_radio_btn.AutoSize = true;
            ped_radio_btn.Location = new Point(22, 226);
            ped_radio_btn.Name = "ped_radio_btn";
            ped_radio_btn.Size = new Size(44, 17);
            ped_radio_btn.TabIndex = 10;
            ped_radio_btn.Text = "Ped";
            ped_radio_btn.UseVisualStyleBackColor = true;
            ped_radio_btn.CheckedChanged += ped_radio_btn_CheckedChanged;
            // 
            // object_radio_btn
            // 
            object_radio_btn.AutoSize = true;
            object_radio_btn.Location = new Point(106, 185);
            object_radio_btn.Name = "object_radio_btn";
            object_radio_btn.Size = new Size(56, 17);
            object_radio_btn.TabIndex = 11;
            object_radio_btn.Text = "Object";
            object_radio_btn.UseVisualStyleBackColor = true;
            object_radio_btn.CheckedChanged += object_radio_btn_CheckedChanged;
            // 
            // weapon_radio_btn
            // 
            weapon_radio_btn.AutoSize = true;
            weapon_radio_btn.Location = new Point(106, 226);
            weapon_radio_btn.Name = "weapon_radio_btn";
            weapon_radio_btn.Size = new Size(66, 17);
            weapon_radio_btn.TabIndex = 12;
            weapon_radio_btn.Text = "Weapon";
            weapon_radio_btn.UseVisualStyleBackColor = true;
            weapon_radio_btn.CheckedChanged += weapon_radio_btn_CheckedChanged;
            // 
            // save_btn
            // 
            save_btn.BackColor = Color.BlueViolet;
            save_btn.BackgroundImageLayout = ImageLayout.Center;
            save_btn.FlatAppearance.BorderSize = 0;
            save_btn.FlatStyle = FlatStyle.Flat;
            save_btn.Location = new Point(177, 201);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(89, 19);
            save_btn.TabIndex = 13;
            save_btn.Text = "Save Location";
            save_btn.UseVisualStyleBackColor = false;
            save_btn.Click += save_btn_Click;
            // 
            // line_btn_2
            // 
            line_btn_2.BackColor = Color.BlueViolet;
            line_btn_2.BackgroundImageLayout = ImageLayout.Center;
            line_btn_2.FlatAppearance.BorderSize = 0;
            line_btn_2.FlatStyle = FlatStyle.Flat;
            line_btn_2.Location = new Point(289, 32);
            line_btn_2.Name = "line_btn_2";
            line_btn_2.Size = new Size(4, 116);
            line_btn_2.TabIndex = 14;
            line_btn_2.UseVisualStyleBackColor = false;
            // 
            // id_edit
            // 
            id_edit.BackColor = Color.FromArgb(40, 40, 40);
            id_edit.BorderStyle = BorderStyle.None;
            id_edit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            id_edit.ForeColor = Color.White;
            id_edit.Location = new Point(318, 48);
            id_edit.Name = "id_edit";
            id_edit.Size = new Size(114, 19);
            id_edit.TabIndex = 15;
            id_edit.TextChanged += id_edit_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(438, 51);
            label2.Name = "label2";
            label2.Size = new Size(18, 13);
            label2.TabIndex = 16;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(318, 84);
            label3.Name = "label3";
            label3.Size = new Size(87, 13);
            label3.TabIndex = 17;
            label3.Text = "Write ACL Group";
            // 
            // acl_edit
            // 
            acl_edit.BackColor = Color.FromArgb(40, 40, 40);
            acl_edit.BorderStyle = BorderStyle.None;
            acl_edit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            acl_edit.ForeColor = Color.White;
            acl_edit.Location = new Point(318, 112);
            acl_edit.Name = "acl_edit";
            acl_edit.Size = new Size(114, 19);
            acl_edit.TabIndex = 18;
            acl_edit.TextChanged += acl_edit_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(318, 154);
            label4.Name = "label4";
            label4.Size = new Size(89, 13);
            label4.TabIndex = 19;
            label4.Text = "Write Data Name";
            // 
            // data_edit
            // 
            data_edit.BackColor = Color.FromArgb(40, 40, 40);
            data_edit.BorderStyle = BorderStyle.None;
            data_edit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            data_edit.ForeColor = Color.White;
            data_edit.Location = new Point(318, 182);
            data_edit.Name = "data_edit";
            data_edit.Size = new Size(114, 19);
            data_edit.TabIndex = 20;
            data_edit.TextChanged += data_edit_TextChanged;
            // 
            // create_btn
            // 
            create_btn.BackColor = Color.BlueViolet;
            create_btn.BackgroundImageLayout = ImageLayout.Center;
            create_btn.FlatAppearance.BorderSize = 0;
            create_btn.FlatStyle = FlatStyle.Flat;
            create_btn.Location = new Point(318, 224);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(209, 19);
            create_btn.TabIndex = 21;
            create_btn.Text = "Create";
            create_btn.UseVisualStyleBackColor = false;
            create_btn.Click += create_btn_Click;
            // 
            // acl_mode_chck
            // 
            acl_mode_chck.AutoSize = true;
            acl_mode_chck.Location = new Point(438, 114);
            acl_mode_chck.Name = "acl_mode_chck";
            acl_mode_chck.Size = new Size(102, 17);
            acl_mode_chck.TabIndex = 22;
            acl_mode_chck.Text = "Only ACL Group";
            acl_mode_chck.UseVisualStyleBackColor = true;
            acl_mode_chck.CheckedChanged += acl_mode_chck_CheckedChanged;
            // 
            // data_mode_chck
            // 
            data_mode_chck.AutoSize = true;
            data_mode_chck.Location = new Point(438, 184);
            data_mode_chck.Name = "data_mode_chck";
            data_mode_chck.Size = new Size(104, 17);
            data_mode_chck.TabIndex = 23;
            data_mode_chck.Text = "Only Data Name";
            data_mode_chck.UseVisualStyleBackColor = true;
            data_mode_chck.CheckedChanged += data_mode_chck_CheckedChanged;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.BlueViolet;
            title.Location = new Point(191, 3);
            title.Name = "title";
            title.Size = new Size(266, 25);
            title.TabIndex = 24;
            title.Text = "Meta Scripts | MTA:SA Script Creator";
            title.TextAlign = ContentAlignment.TopCenter;
            // 
            // logo_img
            // 
            logo_img.ErrorImage = null;
            logo_img.Image = (Image)resources.GetObject("logo_img.Image");
            logo_img.InitialImage = null;
            logo_img.Location = new Point(12, 4);
            logo_img.Name = "logo_img";
            logo_img.Size = new Size(38, 32);
            logo_img.SizeMode = PictureBoxSizeMode.CenterImage;
            logo_img.TabIndex = 27;
            logo_img.TabStop = false;
            logo_img.Click += logo_img_Click;
            // 
            // dc_img
            // 
            dc_img.BackColor = Color.FromArgb(64, 64, 64);
            dc_img.ErrorImage = null;
            dc_img.Image = (Image)resources.GetObject("dc_img.Image");
            dc_img.InitialImage = null;
            dc_img.Location = new Point(100, 4);
            dc_img.Name = "dc_img";
            dc_img.Size = new Size(38, 32);
            dc_img.SizeMode = PictureBoxSizeMode.CenterImage;
            dc_img.TabIndex = 28;
            dc_img.TabStop = false;
            dc_img.Click += dc_img_Click;
            // 
            // github_img
            // 
            github_img.ErrorImage = null;
            github_img.Image = (Image)resources.GetObject("github_img.Image");
            github_img.InitialImage = null;
            github_img.Location = new Point(56, 4);
            github_img.Name = "github_img";
            github_img.Size = new Size(38, 32);
            github_img.SizeMode = PictureBoxSizeMode.CenterImage;
            github_img.TabIndex = 25;
            github_img.TabStop = false;
            github_img.Click += github_img_Click;
            // 
            // txd_select
            // 
            txd_select.FileName = "t";
            txd_select.Filter = "TXD File|*.txd";
            txd_select.FileOk += txd_select_FileOk;
            // 
            // dff_select
            // 
            dff_select.FileName = "dff_select";
            dff_select.Filter = "DFF Files|*.dff";
            dff_select.FileOk += dff_select_FileOk;
            // 
            // save_loc
            // 
            save_loc.Description = "Select Save Location";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(551, 255);
            Controls.Add(dc_img);
            Controls.Add(logo_img);
            Controls.Add(github_img);
            Controls.Add(title);
            Controls.Add(data_mode_chck);
            Controls.Add(acl_mode_chck);
            Controls.Add(create_btn);
            Controls.Add(data_edit);
            Controls.Add(label4);
            Controls.Add(acl_edit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(id_edit);
            Controls.Add(line_btn_2);
            Controls.Add(save_btn);
            Controls.Add(weapon_radio_btn);
            Controls.Add(object_radio_btn);
            Controls.Add(ped_radio_btn);
            Controls.Add(veh_radio_btn);
            Controls.Add(line_btn);
            Controls.Add(dff_label);
            Controls.Add(dff_button);
            Controls.Add(dff_edit);
            Controls.Add(txd_button);
            Controls.Add(label1);
            Controls.Add(txd_edit);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "v";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)dc_img).EndInit();
            ((System.ComponentModel.ISupportInitialize)github_img).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox txd_edit;
        private Label label1;
        private Button txd_button;
        private Button dff_button;
        private TextBox dff_edit;
        private Label dff_label;
        private Button line_btn;
        private RadioButton veh_radio_btn;
        private RadioButton ped_radio_btn;
        private RadioButton object_radio_btn;
        private RadioButton weapon_radio_btn;
        private Button save_btn;
        private Button line_btn_2;
        private TextBox id_edit;
        private Label label2;
        private Label label3;
        private TextBox acl_edit;
        private Label label4;
        private TextBox data_edit;
        private Button create_btn;
        private CheckBox acl_mode_chck;
        private CheckBox data_mode_chck;
        private Label title;
        private PictureBox github_img;
        private PictureBox logo_img;
        private PictureBox dc_img;
        private OpenFileDialog txd_select;
        private OpenFileDialog dff_select;
        private FolderBrowserDialog save_loc;
    }
}