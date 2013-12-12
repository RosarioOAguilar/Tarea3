
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace Singin
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
					
			InitializeComponent();
		}
		void Button1Click(object sender, EventArgs e)
		{
			string usuario = this.txtUsuario.Text;
			string pass = this.txtContrasena.Text;
			
			if(usuario == "rosario" && pass == "aguilar"){
				MessageBox.Show("Bienvenido al Sistema");
			}else{
					MessageBox.Show("Error en los Datos");
				}
			}
		}
	}

