/*
 * Created by SharpDevelop.
 * User: RosarioO
 * Date: 22/10/2013
 * Time: 08:09 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Singin
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtContrasena = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Usuario";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(57, 68);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(100, 20);
			this.txtUsuario.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(38, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Contrasena";
			// 
			// txtContrasena
			// 
			this.txtContrasena.Location = new System.Drawing.Point(57, 160);
			this.txtContrasena.Name = "txtContrasena";
			this.txtContrasena.PasswordChar = '*';
			this.txtContrasena.Size = new System.Drawing.Size(100, 20);
			this.txtContrasena.TabIndex = 3;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(147, 217);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(125, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Iniciar Sesion";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtContrasena);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Singin";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtContrasena;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label1;
	}
}
