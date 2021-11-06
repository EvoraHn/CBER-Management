
namespace Punto_de_venta.Control_de_Ordenadores
{
    partial class Admin_Pcs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgPCs = new System.Windows.Forms.DataGridView();
            this.textIP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNuevoGuardar = new System.Windows.Forms.Button();
            this.textFila = new System.Windows.Forms.TextBox();
            this.textCol = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditarCancelar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.estadoCheck = new System.Windows.Forms.CheckBox();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPCs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPCs
            // 
            this.dgPCs.AllowUserToAddRows = false;
            this.dgPCs.AllowUserToOrderColumns = true;
            this.dgPCs.AllowUserToResizeColumns = false;
            this.dgPCs.AllowUserToResizeRows = false;
            this.dgPCs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPCs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPCs.BackgroundColor = System.Drawing.Color.White;
            this.dgPCs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPCs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPCs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgPCs.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgPCs.Location = new System.Drawing.Point(402, 11);
            this.dgPCs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgPCs.Name = "dgPCs";
            this.dgPCs.ReadOnly = true;
            this.dgPCs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgPCs.RowHeadersVisible = false;
            this.dgPCs.RowHeadersWidth = 31;
            this.dgPCs.RowTemplate.Height = 24;
            this.dgPCs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPCs.Size = new System.Drawing.Size(575, 428);
            this.dgPCs.TabIndex = 17;
            this.dgPCs.SelectionChanged += new System.EventHandler(this.dgPCs_SelectionChanged);
            // 
            // textIP
            // 
            this.textIP.BackColor = System.Drawing.Color.White;
            this.textIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textIP.ForeColor = System.Drawing.Color.Black;
            this.textIP.Location = new System.Drawing.Point(136, 67);
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(185, 22);
            this.textIP.TabIndex = 38;
            this.textIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "IP";
            // 
            // btnNuevoGuardar
            // 
            this.btnNuevoGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoGuardar.Location = new System.Drawing.Point(75, 296);
            this.btnNuevoGuardar.Name = "btnNuevoGuardar";
            this.btnNuevoGuardar.Size = new System.Drawing.Size(113, 49);
            this.btnNuevoGuardar.TabIndex = 43;
            this.btnNuevoGuardar.Text = "Nuevo";
            this.btnNuevoGuardar.UseVisualStyleBackColor = true;
            this.btnNuevoGuardar.Click += new System.EventHandler(this.btnNuevoGuardar_Click);
            // 
            // textFila
            // 
            this.textFila.BackColor = System.Drawing.Color.White;
            this.textFila.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textFila.ForeColor = System.Drawing.Color.Black;
            this.textFila.Location = new System.Drawing.Point(137, 120);
            this.textFila.Name = "textFila";
            this.textFila.Size = new System.Drawing.Size(185, 22);
            this.textFila.TabIndex = 44;
            this.textFila.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textCol
            // 
            this.textCol.BackColor = System.Drawing.Color.White;
            this.textCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCol.ForeColor = System.Drawing.Color.Black;
            this.textCol.Location = new System.Drawing.Point(136, 171);
            this.textCol.Name = "textCol";
            this.textCol.Size = new System.Drawing.Size(185, 22);
            this.textCol.TabIndex = 45;
            this.textCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Fila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Columna";
            // 
            // btnEditarCancelar
            // 
            this.btnEditarCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCancelar.Location = new System.Drawing.Point(208, 296);
            this.btnEditarCancelar.Name = "btnEditarCancelar";
            this.btnEditarCancelar.Size = new System.Drawing.Size(113, 49);
            this.btnEditarCancelar.TabIndex = 48;
            this.btnEditarCancelar.Text = "Editar";
            this.btnEditarCancelar.UseVisualStyleBackColor = true;
            this.btnEditarCancelar.Click += new System.EventHandler(this.btnEditarCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(147, 363);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(113, 49);
            this.btnEliminar.TabIndex = 49;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 50;
            this.label3.Text = "Estado";
            // 
            // estadoCheck
            // 
            this.estadoCheck.AutoSize = true;
            this.estadoCheck.Location = new System.Drawing.Point(137, 223);
            this.estadoCheck.Name = "estadoCheck";
            this.estadoCheck.Size = new System.Drawing.Size(18, 17);
            this.estadoCheck.TabIndex = 51;
            this.estadoCheck.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.White;
            this.btnAtras.BackgroundImage = global::Punto_de_venta.Properties.Resources.goback;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Location = new System.Drawing.Point(12, 11);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(63, 56);
            this.btnAtras.TabIndex = 52;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_Pcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.estadoCheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditarCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCol);
            this.Controls.Add(this.textFila);
            this.Controls.Add(this.btnNuevoGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textIP);
            this.Controls.Add(this.dgPCs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin_Pcs";
            this.Text = "Administrador de PCs";
            this.Load += new System.EventHandler(this.Admin_Pcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPCs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPCs;
        internal System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevoGuardar;
        internal System.Windows.Forms.TextBox textFila;
        internal System.Windows.Forms.TextBox textCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditarCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox estadoCheck;
        private System.Windows.Forms.Button btnAtras;
    }
}