
namespace Punto_de_venta.Mantenimientos
{
    partial class Mantenimiento_Perfiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mantenimiento_Perfiles));
            this.cmbModPrin = new System.Windows.Forms.ComboBox();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.cmbPerfiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGurardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbModPrin
            // 
            this.cmbModPrin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModPrin.FormattingEnabled = true;
            this.cmbModPrin.Location = new System.Drawing.Point(197, 165);
            this.cmbModPrin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbModPrin.Name = "cmbModPrin";
            this.cmbModPrin.Size = new System.Drawing.Size(316, 24);
            this.cmbModPrin.TabIndex = 0;
            this.cmbModPrin.SelectedIndexChanged += new System.EventHandler(this.cmbModPrin_SelectedIndexChanged);
            // 
            // cmbModulo
            // 
            this.cmbModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(197, 222);
            this.cmbModulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(316, 24);
            this.cmbModulo.TabIndex = 1;
            // 
            // cmbPerfiles
            // 
            this.cmbPerfiles.FormattingEnabled = true;
            this.cmbPerfiles.Location = new System.Drawing.Point(197, 95);
            this.cmbPerfiles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbPerfiles.Name = "cmbPerfiles";
            this.cmbPerfiles.Size = new System.Drawing.Size(316, 24);
            this.cmbPerfiles.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Modulo principal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modulo";
            // 
            // btnGurardar
            // 
            this.btnGurardar.Location = new System.Drawing.Point(197, 310);
            this.btnGurardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGurardar.Name = "btnGurardar";
            this.btnGurardar.Size = new System.Drawing.Size(100, 28);
            this.btnGurardar.TabIndex = 6;
            this.btnGurardar.Text = "Guardar";
            this.btnGurardar.UseVisualStyleBackColor = true;
            this.btnGurardar.Click += new System.EventHandler(this.btnGurardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(331, 310);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Mantenimiento_Perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 366);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGurardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPerfiles);
            this.Controls.Add(this.cmbModulo);
            this.Controls.Add(this.cmbModPrin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mantenimiento_Perfiles";
            this.Text = "Perfil Módulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbModPrin;
        private System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.ComboBox cmbPerfiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGurardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}