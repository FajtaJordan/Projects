using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rekurzio_gui;

namespace rekurzio_gui
{
    public partial class Form1 : Form
    {
        TextBox Beker;
        RichTextBox kiiras;
        Button Ok;
        ToolTip TT = new ToolTip();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            Beker = new TextBox()
            {
                Parent = this,
                Location = new Point(20, 20),
                Size = new Size(100, 20),
                Text = ""
            };
            TT.SetToolTip(Beker, "Add meg hány fokot szeretnél!");
            kiiras = new RichTextBox()
            {
                Parent = this,
                Location = new Point(20, 60),
                Size = new Size(100, 20),
                Text= ""
            };
            Ok  = new Button()
            {
                Parent = this,
                Location = new Point(20, 100),
                Size = new Size(100, 20),
                Text = "oké"
            };

        }
        
        private void AdatokBeolvasasa() 
        { 
        }
    }
}
