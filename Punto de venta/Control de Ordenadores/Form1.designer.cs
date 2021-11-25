using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
//using Microsoft.VisualBasic.CompilerServices;

namespace Punto_de_venta.Control_de_Ordenadores
{
    //[DesignerGenerated()]
    public partial class Form1 : Form
    {

        // Form reemplaza a Dispose para limpiar la lista de componentes.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components is object)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Requerido por el Diseñador de Windows Forms
        private System.ComponentModel.IContainer components;

        // NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
        // Se puede modificar usando el Diseñador de Windows Forms.  
        // No lo modifique con el editor de código.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.TextBoxPUERTO1 = new System.Windows.Forms.TextBox();
            this.NumH1 = new System.Windows.Forms.NumericUpDown();
            this.NumM1 = new System.Windows.Forms.NumericUpDown();
            this._ButtonBLOQUEO = new System.Windows.Forms.Button();
            this._ButtonAPAGAR = new System.Windows.Forms.Button();
            this._ButtonINICIAR = new System.Windows.Forms.Button();
            this._TextBoxMENSAJES1 = new System.Windows.Forms.TextBox();
            this._ButtonAÑADIR = new System.Windows.Forms.Button();
            this._ButtonCERRAR = new System.Windows.Forms.Button();
            this._ButtonREINICIAR = new System.Windows.Forms.Button();
            this._ComboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLimite = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumH1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumM1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxPUERTO1
            // 
            this.TextBoxPUERTO1.BackColor = System.Drawing.Color.White;
            this.TextBoxPUERTO1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPUERTO1.ForeColor = System.Drawing.Color.Black;
            this.TextBoxPUERTO1.Location = new System.Drawing.Point(87, 165);
            this.TextBoxPUERTO1.Name = "TextBoxPUERTO1";
            this.TextBoxPUERTO1.Size = new System.Drawing.Size(184, 26);
            this.TextBoxPUERTO1.TabIndex = 5;
            this.TextBoxPUERTO1.Text = "55555";
            this.TextBoxPUERTO1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumH1
            // 
            this.NumH1.BackColor = System.Drawing.Color.White;
            this.NumH1.ForeColor = System.Drawing.Color.Black;
            this.NumH1.Location = new System.Drawing.Point(87, 202);
            this.NumH1.Name = "NumH1";
            this.NumH1.Size = new System.Drawing.Size(60, 26);
            this.NumH1.TabIndex = 7;
            this.NumH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumM1
            // 
            this.NumM1.BackColor = System.Drawing.Color.White;
            this.NumM1.ForeColor = System.Drawing.Color.Black;
            this.NumM1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumM1.Location = new System.Drawing.Point(211, 202);
            this.NumM1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumM1.Name = "NumM1";
            this.NumM1.Size = new System.Drawing.Size(60, 26);
            this.NumM1.TabIndex = 8;
            this.NumM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumM1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // _ButtonBLOQUEO
            // 
            this._ButtonBLOQUEO.BackColor = System.Drawing.Color.White;
            this._ButtonBLOQUEO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ButtonBLOQUEO.ForeColor = System.Drawing.Color.Gray;
            this._ButtonBLOQUEO.Location = new System.Drawing.Point(29, 445);
            this._ButtonBLOQUEO.Name = "_ButtonBLOQUEO";
            this._ButtonBLOQUEO.Size = new System.Drawing.Size(242, 40);
            this._ButtonBLOQUEO.TabIndex = 10;
            this._ButtonBLOQUEO.Text = "Bloqueo";
            this._ButtonBLOQUEO.UseVisualStyleBackColor = false;
            this._ButtonBLOQUEO.Click += new System.EventHandler(this.ButtonBLOQUEO_Click);
            // 
            // _ButtonAPAGAR
            // 
            this._ButtonAPAGAR.BackColor = System.Drawing.Color.White;
            this._ButtonAPAGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ButtonAPAGAR.ForeColor = System.Drawing.Color.Gray;
            this._ButtonAPAGAR.Location = new System.Drawing.Point(29, 583);
            this._ButtonAPAGAR.Name = "_ButtonAPAGAR";
            this._ButtonAPAGAR.Size = new System.Drawing.Size(242, 40);
            this._ButtonAPAGAR.TabIndex = 11;
            this._ButtonAPAGAR.Text = "Apagar Remoto";
            this._ButtonAPAGAR.UseVisualStyleBackColor = false;
            this._ButtonAPAGAR.Click += new System.EventHandler(this.ButtonAPAGAR_Click);
            // 
            // _ButtonINICIAR
            // 
            this._ButtonINICIAR.BackColor = System.Drawing.Color.White;
            this._ButtonINICIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ButtonINICIAR.ForeColor = System.Drawing.Color.Gray;
            this._ButtonINICIAR.Location = new System.Drawing.Point(29, 254);
            this._ButtonINICIAR.Name = "_ButtonINICIAR";
            this._ButtonINICIAR.Size = new System.Drawing.Size(242, 40);
            this._ButtonINICIAR.TabIndex = 12;
            this._ButtonINICIAR.Text = "Iniciar";
            this._ButtonINICIAR.UseVisualStyleBackColor = false;
            this._ButtonINICIAR.Click += new System.EventHandler(this.ButtonINICIAR_Click);
            // 
            // _TextBoxMENSAJES1
            // 
            this._TextBoxMENSAJES1.BackColor = System.Drawing.Color.White;
            this._TextBoxMENSAJES1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._TextBoxMENSAJES1.ForeColor = System.Drawing.Color.Black;
            this._TextBoxMENSAJES1.Location = new System.Drawing.Point(29, 346);
            this._TextBoxMENSAJES1.Multiline = true;
            this._TextBoxMENSAJES1.Name = "_TextBoxMENSAJES1";
            this._TextBoxMENSAJES1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._TextBoxMENSAJES1.Size = new System.Drawing.Size(242, 93);
            this._TextBoxMENSAJES1.TabIndex = 13;
            this._TextBoxMENSAJES1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxMENSAJES_KeyDown);
            // 
            // _ButtonAÑADIR
            // 
            this._ButtonAÑADIR.BackColor = System.Drawing.Color.White;
            this._ButtonAÑADIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ButtonAÑADIR.ForeColor = System.Drawing.Color.Gray;
            this._ButtonAÑADIR.Location = new System.Drawing.Point(29, 300);
            this._ButtonAÑADIR.Name = "_ButtonAÑADIR";
            this._ButtonAÑADIR.Size = new System.Drawing.Size(242, 40);
            this._ButtonAÑADIR.TabIndex = 24;
            this._ButtonAÑADIR.Text = "Añadir T.";
            this._ButtonAÑADIR.UseVisualStyleBackColor = false;
            this._ButtonAÑADIR.Click += new System.EventHandler(this.ButtonAÑADIR_Click);
            // 
            // _ButtonCERRAR
            // 
            this._ButtonCERRAR.BackColor = System.Drawing.Color.White;
            this._ButtonCERRAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ButtonCERRAR.ForeColor = System.Drawing.Color.Gray;
            this._ButtonCERRAR.Location = new System.Drawing.Point(29, 491);
            this._ButtonCERRAR.Name = "_ButtonCERRAR";
            this._ButtonCERRAR.Size = new System.Drawing.Size(242, 40);
            this._ButtonCERRAR.TabIndex = 25;
            this._ButtonCERRAR.Text = "Cerrar";
            this._ButtonCERRAR.UseVisualStyleBackColor = false;
            this._ButtonCERRAR.Click += new System.EventHandler(this.ButtonCERRAR_Click);
            // 
            // _ButtonREINICIAR
            // 
            this._ButtonREINICIAR.BackColor = System.Drawing.Color.White;
            this._ButtonREINICIAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._ButtonREINICIAR.ForeColor = System.Drawing.Color.Gray;
            this._ButtonREINICIAR.Location = new System.Drawing.Point(29, 537);
            this._ButtonREINICIAR.Name = "_ButtonREINICIAR";
            this._ButtonREINICIAR.Size = new System.Drawing.Size(242, 40);
            this._ButtonREINICIAR.TabIndex = 26;
            this._ButtonREINICIAR.Text = "Reiniciar Remoto";
            this._ButtonREINICIAR.UseVisualStyleBackColor = false;
            this._ButtonREINICIAR.Click += new System.EventHandler(this.ButtonREINICIAR_Click);
            // 
            // _ComboBox1
            // 
            this._ComboBox1.BackColor = System.Drawing.Color.Gainsboro;
            this._ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._ComboBox1.ForeColor = System.Drawing.Color.Black;
            this._ComboBox1.FormattingEnabled = true;
            this._ComboBox1.Items.AddRange(new object[] {
            "W7",
            "XP"});
            this._ComboBox1.Location = new System.Drawing.Point(29, 695);
            this._ComboBox1.Name = "_ComboBox1";
            this._ComboBox1.Size = new System.Drawing.Size(140, 28);
            this._ComboBox1.TabIndex = 27;
            this._ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(71)))));
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1193, 59);
            this.panel2.TabIndex = 34;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1046, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 26);
            this.textBox1.TabIndex = 44;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(959, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "Buscar :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(306, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(356, 36);
            this.label9.TabIndex = 30;
            this.label9.Text = "Control de Ordenadores";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(368, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(811, 553);
            this.flowLayoutPanel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ordenador Seleccionado";
            // 
            // textIP
            // 
            this.textIP.BackColor = System.Drawing.Color.White;
            this.textIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIP.ForeColor = System.Drawing.Color.Black;
            this.textIP.Location = new System.Drawing.Point(87, 104);
            this.textIP.Name = "textIP";
            this.textIP.ReadOnly = true;
            this.textIP.Size = new System.Drawing.Size(184, 26);
            this.textIP.TabIndex = 37;
            this.textIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Hrs.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "Mins.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Puerto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 41;
            this.label5.Text = "IP";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::Punto_de_venta.Properties.Resources.moneda;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(297, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 43);
            this.button2.TabIndex = 46;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "T. Limite";
            // 
            // txtLimite
            // 
            this.txtLimite.BackColor = System.Drawing.Color.White;
            this.txtLimite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLimite.ForeColor = System.Drawing.Color.Black;
            this.txtLimite.Location = new System.Drawing.Point(87, 136);
            this.txtLimite.Name = "txtLimite";
            this.txtLimite.ReadOnly = true;
            this.txtLimite.Size = new System.Drawing.Size(184, 26);
            this.txtLimite.TabIndex = 48;
            this.txtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::Punto_de_venta.Properties.Resources.escritura;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(297, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 45;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1191, 657);
            this.Controls.Add(this.txtLimite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this._ComboBox1);
            this.Controls.Add(this._ButtonREINICIAR);
            this.Controls.Add(this._ButtonCERRAR);
            this.Controls.Add(this._ButtonAÑADIR);
            this.Controls.Add(this._TextBoxMENSAJES1);
            this.Controls.Add(this._ButtonINICIAR);
            this.Controls.Add(this._ButtonAPAGAR);
            this.Controls.Add(this._ButtonBLOQUEO);
            this.Controls.Add(this.NumM1);
            this.Controls.Add(this.NumH1);
            this.Controls.Add(this.TextBoxPUERTO1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumH1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumM1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        internal TextBox TextBoxPUERTO1;
        internal NumericUpDown NumH1;
        internal NumericUpDown NumM1;
        private Button _ButtonBLOQUEO;

        internal Button ButtonBLOQUEO
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonBLOQUEO;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonBLOQUEO != null)
                {
                    _ButtonBLOQUEO.Click -= ButtonBLOQUEO_Click;
                }

                _ButtonBLOQUEO = value;
                if (_ButtonBLOQUEO != null)
                {
                    _ButtonBLOQUEO.Click += ButtonBLOQUEO_Click;
                }
            }
        }

        private Button _ButtonAPAGAR;

        internal Button ButtonAPAGAR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonAPAGAR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonAPAGAR != null)
                {
                    _ButtonAPAGAR.Click -= ButtonAPAGAR_Click;
                }

                _ButtonAPAGAR = value;
                if (_ButtonAPAGAR != null)
                {
                    _ButtonAPAGAR.Click += ButtonAPAGAR_Click;
                }
            }
        }

        private Button _ButtonINICIAR;

        internal Button ButtonINICIAR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonINICIAR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonINICIAR != null)
                {
                    _ButtonINICIAR.Click -= ButtonINICIAR_Click;
                }

                _ButtonINICIAR = value;
                if (_ButtonINICIAR != null)
                {
                    _ButtonINICIAR.Click += ButtonINICIAR_Click;
                }
            }
        }

        private TextBox _TextBoxMENSAJES1;

        internal TextBox TextBoxMENSAJES1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TextBoxMENSAJES1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TextBoxMENSAJES1 != null)
                {
                    _TextBoxMENSAJES1.KeyDown -= TextBoxMENSAJES_KeyDown;
                }

                _TextBoxMENSAJES1 = value;
                if (_TextBoxMENSAJES1 != null)
                {
                    _TextBoxMENSAJES1.KeyDown += TextBoxMENSAJES_KeyDown;
                }
            }
        }

        private Button _ButtonAÑADIR;

        internal Button ButtonAÑADIR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonAÑADIR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonAÑADIR != null)
                {
                    _ButtonAÑADIR.Click -= ButtonAÑADIR_Click;
                }

                _ButtonAÑADIR = value;
                if (_ButtonAÑADIR != null)
                {
                    _ButtonAÑADIR.Click += ButtonAÑADIR_Click;
                }
            }
        }

        private Button _ButtonCERRAR;

        internal Button ButtonCERRAR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonCERRAR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonCERRAR != null)
                {
                    _ButtonCERRAR.Click -= ButtonCERRAR_Click;
                }

                _ButtonCERRAR = value;
                if (_ButtonCERRAR != null)
                {
                    _ButtonCERRAR.Click += ButtonCERRAR_Click;
                }
            }
        }

        private Button _ButtonREINICIAR;

        internal Button ButtonREINICIAR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ButtonREINICIAR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ButtonREINICIAR != null)
                {
                    _ButtonREINICIAR.Click -= ButtonREINICIAR_Click;
                }

                _ButtonREINICIAR = value;
                if (_ButtonREINICIAR != null)
                {
                    _ButtonREINICIAR.Click += ButtonREINICIAR_Click;
                }
            }
        }

        private ComboBox _ComboBox1;
        private Panel panel2;
        private Label label9;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        internal TextBox textIP;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label6;
        internal TextBox txtLimite;

        internal ComboBox ComboBox1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ComboBox1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ComboBox1 != null)
                {
                    _ComboBox1.SelectedIndexChanged -= ComboBox1_SelectedIndexChanged;
                }

                _ComboBox1 = value;
                if (_ComboBox1 != null)
                {
                    _ComboBox1.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
                }
            }
        }
    }
}