namespace Fabrica_Braian_Acosta
{
    partial class FrmView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            lstVehiculos = new ListBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            pcbFabrica = new PictureBox();
            btnFabricar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).BeginInit();
            SuspendLayout();
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.HorizontalScrollbar = true;
            lstVehiculos.ItemHeight = 20;
            lstVehiculos.Location = new Point(12, 12);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(697, 924);
            lstVehiculos.TabIndex = 0;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(790, 12);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(123, 20);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo de Vehiculo:";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(745, 62);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(207, 28);
            cmbTipo.TabIndex = 2;
            // 
            // pcbFabrica
            // 
            pcbFabrica.Location = new Point(745, 234);
            pcbFabrica.Name = "pcbFabrica";
            pcbFabrica.Size = new Size(207, 279);
            pcbFabrica.TabIndex = 3;
            pcbFabrica.TabStop = false;
            // 
            // btnFabricar
            // 
            btnFabricar.Location = new Point(745, 786);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(207, 60);
            btnFabricar.TabIndex = 4;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(745, 878);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(207, 60);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 953);
            Controls.Add(btnEliminar);
            Controls.Add(btnFabricar);
            Controls.Add(pcbFabrica);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(lstVehiculos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fabrica de Vehiculos";
            Load += FrmView_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVehiculos;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private PictureBox pcbFabrica;
        private Button btnFabricar;
        private Button btnEliminar;
    }
}