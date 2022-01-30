
namespace CSV_Import_V2
{
    partial class FormDataImport
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
            this.Import_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Loc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc_Zn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc_Purp_Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc_QTI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Flow_Ind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TSQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Auth_Overrun_Ind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_Cap_Exceed_Ind = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.All_Qty_Avail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty_Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Save_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Import_btn
            // 
            this.Import_btn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Import_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Import_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Import_btn.ForeColor = System.Drawing.Color.Black;
            this.Import_btn.Location = new System.Drawing.Point(324, 27);
            this.Import_btn.Name = "Import_btn";
            this.Import_btn.Size = new System.Drawing.Size(113, 35);
            this.Import_btn.TabIndex = 0;
            this.Import_btn.Text = "&Load CSV File";
            this.Import_btn.UseVisualStyleBackColor = false;
            this.Import_btn.Click += new System.EventHandler(this.Import_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Loc,
            this.Loc_Zn,
            this.Loc_Name,
            this.Loc_Purp_Desc,
            this.Loc_QTI,
            this.Flow_Ind,
            this.DC,
            this.OPC,
            this.TSQ,
            this.OAC,
            this.IT,
            this.Auth_Overrun_Ind,
            this.Nom_Cap_Exceed_Ind,
            this.All_Qty_Avail,
            this.Qty_Reason});
            this.dataGridView1.Location = new System.Drawing.Point(12, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 303);
            this.dataGridView1.TabIndex = 1;
            // 
            // Loc
            // 
            this.Loc.DataPropertyName = "Loc";
            this.Loc.HeaderText = "Loc";
            this.Loc.Name = "Loc";
            this.Loc.ReadOnly = true;
            this.Loc.Width = 50;
            // 
            // Loc_Zn
            // 
            this.Loc_Zn.DataPropertyName = "Loc Zn";
            this.Loc_Zn.HeaderText = "Loc_Zn";
            this.Loc_Zn.Name = "Loc_Zn";
            this.Loc_Zn.ReadOnly = true;
            // 
            // Loc_Name
            // 
            this.Loc_Name.DataPropertyName = "Loc Name";
            this.Loc_Name.HeaderText = "Loc_Name";
            this.Loc_Name.Name = "Loc_Name";
            this.Loc_Name.ReadOnly = true;
            // 
            // Loc_Purp_Desc
            // 
            this.Loc_Purp_Desc.DataPropertyName = "Loc Purp Desc";
            this.Loc_Purp_Desc.HeaderText = "Loc_Purp_Desc";
            this.Loc_Purp_Desc.Name = "Loc_Purp_Desc";
            this.Loc_Purp_Desc.ReadOnly = true;
            // 
            // Loc_QTI
            // 
            this.Loc_QTI.DataPropertyName = "Loc/QTI";
            this.Loc_QTI.HeaderText = "Loc_QTI";
            this.Loc_QTI.Name = "Loc_QTI";
            this.Loc_QTI.ReadOnly = true;
            // 
            // Flow_Ind
            // 
            this.Flow_Ind.DataPropertyName = "Flow Ind";
            this.Flow_Ind.HeaderText = "Flow_Ind";
            this.Flow_Ind.Name = "Flow_Ind";
            this.Flow_Ind.ReadOnly = true;
            // 
            // DC
            // 
            this.DC.DataPropertyName = "DC";
            this.DC.HeaderText = "DC";
            this.DC.Name = "DC";
            this.DC.ReadOnly = true;
            // 
            // OPC
            // 
            this.OPC.DataPropertyName = "OPC";
            this.OPC.HeaderText = "OPC";
            this.OPC.Name = "OPC";
            this.OPC.ReadOnly = true;
            // 
            // TSQ
            // 
            this.TSQ.DataPropertyName = "TSQ";
            this.TSQ.HeaderText = "TSQ";
            this.TSQ.Name = "TSQ";
            this.TSQ.ReadOnly = true;
            // 
            // OAC
            // 
            this.OAC.DataPropertyName = "OAC";
            this.OAC.HeaderText = "OAC";
            this.OAC.Name = "OAC";
            this.OAC.ReadOnly = true;
            // 
            // IT
            // 
            this.IT.DataPropertyName = "IT";
            this.IT.HeaderText = "IT";
            this.IT.Name = "IT";
            this.IT.ReadOnly = true;
            // 
            // Auth_Overrun_Ind
            // 
            this.Auth_Overrun_Ind.DataPropertyName = "Auth Overrun Ind";
            this.Auth_Overrun_Ind.HeaderText = "Auth_Overrun_Ind";
            this.Auth_Overrun_Ind.Name = "Auth_Overrun_Ind";
            this.Auth_Overrun_Ind.ReadOnly = true;
            // 
            // Nom_Cap_Exceed_Ind
            // 
            this.Nom_Cap_Exceed_Ind.DataPropertyName = "Nom Cap Exceed Ind";
            this.Nom_Cap_Exceed_Ind.HeaderText = "Nom_Cap_Exceed_Ind";
            this.Nom_Cap_Exceed_Ind.Name = "Nom_Cap_Exceed_Ind";
            this.Nom_Cap_Exceed_Ind.ReadOnly = true;
            // 
            // All_Qty_Avail
            // 
            this.All_Qty_Avail.DataPropertyName = "All Qty Avail";
            this.All_Qty_Avail.HeaderText = "All_Qty_Avail";
            this.All_Qty_Avail.Name = "All_Qty_Avail";
            this.All_Qty_Avail.ReadOnly = true;
            // 
            // Qty_Reason
            // 
            this.Qty_Reason.DataPropertyName = "Qty Reason";
            this.Qty_Reason.HeaderText = "Qty_Reason";
            this.Qty_Reason.Name = "Qty_Reason";
            this.Qty_Reason.ReadOnly = true;
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.Color.Green;
            this.Save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.ForeColor = System.Drawing.Color.White;
            this.Save_btn.Location = new System.Drawing.Point(242, 400);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(114, 35);
            this.Save_btn.TabIndex = 2;
            this.Save_btn.Text = "&Save in DB";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.Color.Red;
            this.Cancel_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.ForeColor = System.Drawing.Color.White;
            this.Cancel_btn.Location = new System.Drawing.Point(400, 400);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(114, 35);
            this.Cancel_btn.TabIndex = 3;
            this.Cancel_btn.Text = "&Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancel_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(661, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Created by Mina Dawood";
            // 
            // FormDataImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.Save_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Import_btn);
            this.MaximizeBox = false;
            this.Name = "FormDataImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV Data Import";
            this.Load += new System.EventHandler(this.FormDataImport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Import_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc_Zn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc_Purp_Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc_QTI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Flow_Ind;
        private System.Windows.Forms.DataGridViewTextBoxColumn DC;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TSQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn OAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Auth_Overrun_Ind;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Cap_Exceed_Ind;
        private System.Windows.Forms.DataGridViewTextBoxColumn All_Qty_Avail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty_Reason;
        private System.Windows.Forms.Label label1;
    }
}

