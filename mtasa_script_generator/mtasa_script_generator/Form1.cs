using System.Drawing;
using System.Diagnostics;
using System.Security.Policy;

namespace mtasa_script_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void txd_edit_TextChanged(object sender, EventArgs e)
        {
            settings.txd_file = txd_edit.Text;
        }

        private void veh_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
            settings.create_type = 1;

        }

        private void ped_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
            settings.create_type = 2;
        }

        private void object_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
            settings.create_type = 3;
        }

        private void weapon_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
            settings.create_type = 4;
        }

        private void acl_mode_chck_CheckedChanged(object sender, EventArgs e)
        {

            settings.acl_mode = acl_mode_chck.Checked;

        }

        private void data_mode_chck_CheckedChanged(object sender, EventArgs e)
        {
            settings.data_mode = data_mode_chck.Checked;
        }

        private void dff_edit_TextChanged(object sender, EventArgs e)
        {
            settings.dff_file = dff_edit.Text;
        }

        private void logo_img_Click(object sender, EventArgs e)
        {

            Process.Start(new ProcessStartInfo
            {
                FileName = "http://metascripts.org/",
                UseShellExecute = true
            });
        }

        private void github_img_Click(object sender, EventArgs e)
        {

            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/alitfkc",
                UseShellExecute = true
            });

        }

        private void dc_img_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://discord.gg/e4f9uUbzys",
                UseShellExecute = true
            });
        }

        private void id_edit_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(id_edit.Text, out int result))
            {
                settings.id = result;
            }
            else
            {
                id_edit.Text = "";
            }
        }

        private void acl_edit_TextChanged(object sender, EventArgs e)
        {
            settings.acl_name = acl_edit.Text;
        }

        private void data_edit_TextChanged(object sender, EventArgs e)
        {
            settings.data_name = data_edit.Text;
        }

        private void txd_button_Click(object sender, EventArgs e)
        {
            txd_select.ShowDialog();
        }

        private void txd_select_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            settings.txd_file = txd_select.FileName;
            txd_edit.Text = txd_select.FileName;
        }

        private void dff_button_Click(object sender, EventArgs e)
        {
            dff_select.ShowDialog();
        }

        private void dff_select_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            settings.dff_file = dff_select.FileName;
            dff_edit.Text = dff_select.FileName;
        }

        private void create_btn_Click(object sender, EventArgs e)
        {

            Program.genarate();
        }

        private void save_loc_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            settings.save_location = save_loc.SelectedPath;
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            save_loc.ShowDialog();
        }
    }
}