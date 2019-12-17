namespace ProfesorPuntual
{
    partial class FrmNewUser
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
            this.components = new System.ComponentModel.Container();
            this.Bar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BttnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TxtCel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BttnSave = new System.Windows.Forms.Button();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.LblVNom = new System.Windows.Forms.Label();
            this.LblVMail = new System.Windows.Forms.Label();
            this.LblVCel = new System.Windows.Forms.Label();
            this.TxtNroFuncionario = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LblVNro = new System.Windows.Forms.Label();
            this.Bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bar
            // 
            this.Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.Bar.Controls.Add(this.label2);
            this.Bar.Controls.Add(this.BttnClose);
            this.Bar.Location = new System.Drawing.Point(0, -1);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(360, 42);
            this.Bar.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "REGISTRO";
            // 
            // BttnClose
            // 
            this.BttnClose.FlatAppearance.BorderSize = 0;
            this.BttnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnClose.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(27)))));
            this.BttnClose.Location = new System.Drawing.Point(306, 2);
            this.BttnClose.Name = "BttnClose";
            this.BttnClose.Size = new System.Drawing.Size(51, 40);
            this.BttnClose.TabIndex = 0;
            this.BttnClose.Text = "X";
            this.BttnClose.UseVisualStyleBackColor = true;
            this.BttnClose.Click += new System.EventHandler(this.BttnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(86, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "CREA TU PERFIL DOCENTE:";
            // 
            // TxtNom
            // 
            this.TxtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNom.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtNom.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtNom.HintText = "Nombre";
            this.TxtNom.isPassword = false;
            this.TxtNom.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtNom.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtNom.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtNom.LineThickness = 2;
            this.TxtNom.Location = new System.Drawing.Point(56, 154);
            this.TxtNom.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(244, 36);
            this.TxtNom.TabIndex = 2;
            this.TxtNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNom.Enter += new System.EventHandler(this.TxtNom_Enter);
            this.TxtNom.Leave += new System.EventHandler(this.TxtNom_Leave);
            // 
            // TxtMail
            // 
            this.TxtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtMail.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtMail.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtMail.HintText = "Mail ";
            this.TxtMail.isPassword = false;
            this.TxtMail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtMail.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtMail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtMail.LineThickness = 2;
            this.TxtMail.Location = new System.Drawing.Point(56, 209);
            this.TxtMail.Margin = new System.Windows.Forms.Padding(4);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(244, 36);
            this.TxtMail.TabIndex = 3;
            this.TxtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtMail.Enter += new System.EventHandler(this.TxtMail_Enter);
            this.TxtMail.Leave += new System.EventHandler(this.TxtMail_Leave);
            // 
            // TxtCel
            // 
            this.TxtCel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCel.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtCel.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtCel.HintText = "Celular";
            this.TxtCel.isPassword = false;
            this.TxtCel.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtCel.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtCel.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtCel.LineThickness = 2;
            this.TxtCel.Location = new System.Drawing.Point(56, 267);
            this.TxtCel.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCel.Name = "TxtCel";
            this.TxtCel.Size = new System.Drawing.Size(244, 36);
            this.TxtCel.TabIndex = 4;
            this.TxtCel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtCel.Enter += new System.EventHandler(this.TxtCel_Enter);
            this.TxtCel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCel_KeyPress);
            this.TxtCel.Leave += new System.EventHandler(this.TxtCel_Leave);
            // 
            // BttnSave
            // 
            this.BttnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.BttnSave.FlatAppearance.BorderSize = 0;
            this.BttnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnSave.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BttnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(27)))));
            this.BttnSave.Location = new System.Drawing.Point(56, 324);
            this.BttnSave.Name = "BttnSave";
            this.BttnSave.Size = new System.Drawing.Size(244, 47);
            this.BttnSave.TabIndex = 5;
            this.BttnSave.Text = "GUARDAR";
            this.BttnSave.UseVisualStyleBackColor = false;
            this.BttnSave.Click += new System.EventHandler(this.BttnSave_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Bar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // LblVNom
            // 
            this.LblVNom.AutoSize = true;
            this.LblVNom.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.LblVNom.Location = new System.Drawing.Point(307, 171);
            this.LblVNom.Name = "LblVNom";
            this.LblVNom.Size = new System.Drawing.Size(18, 19);
            this.LblVNom.TabIndex = 7;
            this.LblVNom.Text = "*";
            this.LblVNom.Visible = false;
            // 
            // LblVMail
            // 
            this.LblVMail.AutoSize = true;
            this.LblVMail.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.LblVMail.Location = new System.Drawing.Point(307, 226);
            this.LblVMail.Name = "LblVMail";
            this.LblVMail.Size = new System.Drawing.Size(18, 19);
            this.LblVMail.TabIndex = 8;
            this.LblVMail.Text = "*";
            this.LblVMail.Visible = false;
            // 
            // LblVCel
            // 
            this.LblVCel.AutoSize = true;
            this.LblVCel.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVCel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.LblVCel.Location = new System.Drawing.Point(307, 284);
            this.LblVCel.Name = "LblVCel";
            this.LblVCel.Size = new System.Drawing.Size(18, 19);
            this.LblVCel.TabIndex = 9;
            this.LblVCel.Text = "*";
            this.LblVCel.Visible = false;
            // 
            // TxtNroFuncionario
            // 
            this.TxtNroFuncionario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNroFuncionario.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroFuncionario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtNroFuncionario.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtNroFuncionario.HintText = "Nº Funcionario";
            this.TxtNroFuncionario.isPassword = false;
            this.TxtNroFuncionario.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtNroFuncionario.LineIdleColor = System.Drawing.Color.Gray;
            this.TxtNroFuncionario.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.TxtNroFuncionario.LineThickness = 2;
            this.TxtNroFuncionario.Location = new System.Drawing.Point(56, 101);
            this.TxtNroFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.TxtNroFuncionario.Name = "TxtNroFuncionario";
            this.TxtNroFuncionario.Size = new System.Drawing.Size(244, 36);
            this.TxtNroFuncionario.TabIndex = 1;
            this.TxtNroFuncionario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TxtNroFuncionario.OnValueChanged += new System.EventHandler(this.TxtNroFuncionario_OnValueChanged);
            this.TxtNroFuncionario.Enter += new System.EventHandler(this.TxtNroFuncionario_Enter);
            this.TxtNroFuncionario.Leave += new System.EventHandler(this.TxtNroFuncionario_Leave);
            // 
            // LblVNro
            // 
            this.LblVNro.AutoSize = true;
            this.LblVNro.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVNro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(82)))), ((int)(((byte)(83)))));
            this.LblVNro.Location = new System.Drawing.Point(307, 118);
            this.LblVNro.Name = "LblVNro";
            this.LblVNro.Size = new System.Drawing.Size(18, 19);
            this.LblVNro.TabIndex = 11;
            this.LblVNro.Text = "*";
            this.LblVNro.Visible = false;
            // 
            // FrmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(358, 404);
            this.Controls.Add(this.LblVNro);
            this.Controls.Add(this.TxtNroFuncionario);
            this.Controls.Add(this.LblVCel);
            this.Controls.Add(this.LblVMail);
            this.Controls.Add(this.LblVNom);
            this.Controls.Add(this.BttnSave);
            this.Controls.Add(this.TxtCel);
            this.Controls.Add(this.TxtMail);
            this.Controls.Add(this.TxtNom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNewUser";
            this.Load += new System.EventHandler(this.FrmNewUser_Load);
            this.Bar.ResumeLayout(false);
            this.Bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Bar;
        private System.Windows.Forms.Button BttnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtNom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtMail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtCel;
        private System.Windows.Forms.Button BttnSave;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label LblVNom;
        private System.Windows.Forms.Label LblVMail;
        private System.Windows.Forms.Label LblVCel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TxtNroFuncionario;
        private System.Windows.Forms.Label LblVNro;
    }
}