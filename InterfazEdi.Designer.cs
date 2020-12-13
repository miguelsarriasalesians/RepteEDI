namespace Repte
{
    partial class InterfazEdi
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
            this.button1 = new System.Windows.Forms.Button();
            this.lsbLectura = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblLectura = new System.Windows.Forms.Label();
            this.lblArray = new System.Windows.Forms.Label();
            this.lsbArray = new System.Windows.Forms.ListBox();
            this.dtgContacts = new System.Windows.Forms.DataGridView();
            this.dtgSystems = new System.Windows.Forms.DataGridView();
            this.dtgContactsPost = new System.Windows.Forms.DataGridView();
            this.dtgSystemsPost = new System.Windows.Forms.DataGridView();
            this.lblContactsPre = new System.Windows.Forms.Label();
            this.lblContactosPost = new System.Windows.Forms.Label();
            this.lblSystemsPost = new System.Windows.Forms.Label();
            this.lblSystemsPre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSystems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContactsPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSystemsPost)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(118, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 77);
            this.button1.TabIndex = 0;
            this.button1.Text = "PROCESAR EDI";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lsbLectura
            // 
            this.lsbLectura.FormattingEnabled = true;
            this.lsbLectura.ItemHeight = 16;
            this.lsbLectura.Location = new System.Drawing.Point(118, 182);
            this.lsbLectura.Name = "lsbLectura";
            this.lsbLectura.Size = new System.Drawing.Size(355, 180);
            this.lsbLectura.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblLectura
            // 
            this.lblLectura.AutoSize = true;
            this.lblLectura.Location = new System.Drawing.Point(115, 149);
            this.lblLectura.Name = "lblLectura";
            this.lblLectura.Size = new System.Drawing.Size(76, 17);
            this.lblLectura.TabIndex = 2;
            this.lblLectura.Text = "LECTURA:";
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(115, 376);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(180, 17);
            this.lblArray.TabIndex = 4;
            this.lblArray.Text = "CONTENIDO DEL ARRAY: ";
            // 
            // lsbArray
            // 
            this.lsbArray.FormattingEnabled = true;
            this.lsbArray.ItemHeight = 16;
            this.lsbArray.Location = new System.Drawing.Point(118, 409);
            this.lsbArray.Name = "lsbArray";
            this.lsbArray.Size = new System.Drawing.Size(355, 180);
            this.lsbArray.TabIndex = 3;
            // 
            // dtgContacts
            // 
            this.dtgContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContacts.Location = new System.Drawing.Point(665, 114);
            this.dtgContacts.Name = "dtgContacts";
            this.dtgContacts.RowHeadersWidth = 51;
            this.dtgContacts.RowTemplate.Height = 24;
            this.dtgContacts.Size = new System.Drawing.Size(401, 195);
            this.dtgContacts.TabIndex = 5;
            // 
            // dtgSystems
            // 
            this.dtgSystems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSystems.Location = new System.Drawing.Point(665, 394);
            this.dtgSystems.Name = "dtgSystems";
            this.dtgSystems.RowHeadersWidth = 51;
            this.dtgSystems.RowTemplate.Height = 24;
            this.dtgSystems.Size = new System.Drawing.Size(409, 195);
            this.dtgSystems.TabIndex = 6;
            // 
            // dtgContactsPost
            // 
            this.dtgContactsPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContactsPost.Location = new System.Drawing.Point(1152, 114);
            this.dtgContactsPost.Name = "dtgContactsPost";
            this.dtgContactsPost.RowHeadersWidth = 51;
            this.dtgContactsPost.RowTemplate.Height = 24;
            this.dtgContactsPost.Size = new System.Drawing.Size(401, 195);
            this.dtgContactsPost.TabIndex = 7;
            // 
            // dtgSystemsPost
            // 
            this.dtgSystemsPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSystemsPost.Location = new System.Drawing.Point(1144, 394);
            this.dtgSystemsPost.Name = "dtgSystemsPost";
            this.dtgSystemsPost.RowHeadersWidth = 51;
            this.dtgSystemsPost.RowTemplate.Height = 24;
            this.dtgSystemsPost.Size = new System.Drawing.Size(409, 195);
            this.dtgSystemsPost.TabIndex = 8;
            // 
            // lblContactsPre
            // 
            this.lblContactsPre.AutoSize = true;
            this.lblContactsPre.Location = new System.Drawing.Point(662, 80);
            this.lblContactsPre.Name = "lblContactsPre";
            this.lblContactsPre.Size = new System.Drawing.Size(251, 17);
            this.lblContactsPre.TabIndex = 9;
            this.lblContactsPre.Text = "CONTACTOS ANTES DE PROCESAR:";
            // 
            // lblContactosPost
            // 
            this.lblContactosPost.AutoSize = true;
            this.lblContactosPost.Location = new System.Drawing.Point(1146, 80);
            this.lblContactosPost.Name = "lblContactosPost";
            this.lblContactosPost.Size = new System.Drawing.Size(270, 17);
            this.lblContactosPost.TabIndex = 10;
            this.lblContactosPost.Text = "CONTACTOS DESPUES DE PROCESAR:";
            // 
            // lblSystemsPost
            // 
            this.lblSystemsPost.AutoSize = true;
            this.lblSystemsPost.Location = new System.Drawing.Point(1146, 360);
            this.lblSystemsPost.Name = "lblSystemsPost";
            this.lblSystemsPost.Size = new System.Drawing.Size(252, 17);
            this.lblSystemsPost.TabIndex = 12;
            this.lblSystemsPost.Text = "SISTEMAS DESPUES DE PROCESAR:";
            // 
            // lblSystemsPre
            // 
            this.lblSystemsPre.AutoSize = true;
            this.lblSystemsPre.Location = new System.Drawing.Point(662, 360);
            this.lblSystemsPre.Name = "lblSystemsPre";
            this.lblSystemsPre.Size = new System.Drawing.Size(233, 17);
            this.lblSystemsPre.TabIndex = 11;
            this.lblSystemsPre.Text = "SISTEMAS ANTES DE PROCESAR:";
            // 
            // InterfazEdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1640, 633);
            this.Controls.Add(this.lblSystemsPost);
            this.Controls.Add(this.lblSystemsPre);
            this.Controls.Add(this.lblContactosPost);
            this.Controls.Add(this.lblContactsPre);
            this.Controls.Add(this.dtgSystemsPost);
            this.Controls.Add(this.dtgContactsPost);
            this.Controls.Add(this.dtgSystems);
            this.Controls.Add(this.dtgContacts);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.lsbArray);
            this.Controls.Add(this.lblLectura);
            this.Controls.Add(this.lsbLectura);
            this.Controls.Add(this.button1);
            this.Name = "InterfazEdi";
            this.Text = "InterfazEdi";
            this.Load += new System.EventHandler(this.InterfazEdi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSystems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContactsPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSystemsPost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lsbLectura;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblLectura;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.ListBox lsbArray;
        private System.Windows.Forms.DataGridView dtgContacts;
        private System.Windows.Forms.DataGridView dtgSystems;
        private System.Windows.Forms.DataGridView dtgContactsPost;
        private System.Windows.Forms.DataGridView dtgSystemsPost;
        private System.Windows.Forms.Label lblContactsPre;
        private System.Windows.Forms.Label lblContactosPost;
        private System.Windows.Forms.Label lblSystemsPost;
        private System.Windows.Forms.Label lblSystemsPre;
    }
}