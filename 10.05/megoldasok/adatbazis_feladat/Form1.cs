using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adatbazis_feladat
{
    public partial class Form1 : Form
    {
        MenuStrip MM = new MenuStrip();
        string[] MenuFeliratok = { "Javítások-összes", "Javítások-lapozással", "Szűrés", "Új szerelő", "Áremelés", "Exportálás", "Kilépés" };
        ToolStripMenuItem[] FomenuPontok = new ToolStripMenuItem[7];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Font = new Font("Garamond", 16f);
            Size = new Size(950, 400);
            MM.BackColor = Color.FromArgb(30, 144, 255);
            MM.ForeColor = Color.FromArgb(155, 55, 155);
            MM.Text = "Ez itt a főmenü";
            MM.Font = new Font("Garamond", 18f);
            MM.Dock = DockStyle.Top;
            FomenuPontok = new ToolStripMenuItem[7];
            for (int i = 0; i < 7; i++)
            {
                FomenuPontok[i] = new ToolStripMenuItem()
                {
                    Text = MenuFeliratok[i],
                    ForeColor = Color.White,
                    BackColor = Color.Black
                };
                FomenuPontok[i].Click += FomenuPont_Click;
                MM.Items.Add(FomenuPontok[i]);
            }
            FomenuPontok[0].Enabled = false;

            this.MainMenuStrip = MM;
            Controls.Add(MM);

        }
        private void FomenuPont_Click(object sender, EventArgs e)
        {
            var aktualis = sender as ToolStripMenuItem;
            //leállítás
            if (aktualis.Text == "Kilépés")
            {
                Application.Exit();
            }
        }
        private void Fomenu_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
