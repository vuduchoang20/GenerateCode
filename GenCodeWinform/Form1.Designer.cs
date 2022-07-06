namespace GenCodeWinform
{
    partial class Form1
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
            this.txtPathApplicationShared = new System.Windows.Forms.TextBox();
            this.txtPathCore = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEntityName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.cbEntityBase = new System.Windows.Forms.ComboBox();
            this.cbEntityDtoBase = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPathApplication = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectPathApp = new System.Windows.Forms.Button();
            this.btnSelectPathAppShared = new System.Windows.Forms.Button();
            this.btnSelectPathCore = new System.Windows.Forms.Button();
            this.txtPathMvc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSelectPathMvc = new System.Windows.Forms.Button();
            this.cbCreateOrEditEntityDtoBase = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAppArea = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPathApplicationShared
            // 
            this.txtPathApplicationShared.Location = new System.Drawing.Point(186, 134);
            this.txtPathApplicationShared.Name = "txtPathApplicationShared";
            this.txtPathApplicationShared.Size = new System.Drawing.Size(404, 23);
            this.txtPathApplicationShared.TabIndex = 2;
            // 
            // txtPathCore
            // 
            this.txtPathCore.Location = new System.Drawing.Point(186, 186);
            this.txtPathCore.Name = "txtPathCore";
            this.txtPathCore.Size = new System.Drawing.Size(404, 23);
            this.txtPathCore.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path Core:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path Application Shared:";
            // 
            // txtEntityName
            // 
            this.txtEntityName.Location = new System.Drawing.Point(850, 132);
            this.txtEntityName.Name = "txtEntityName";
            this.txtEntityName.Size = new System.Drawing.Size(199, 23);
            this.txtEntityName.TabIndex = 7;
            this.txtEntityName.TextChanged += new System.EventHandler(this.txtEntityName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(763, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Entity Name:";
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(954, 639);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(112, 28);
            this.Generate.TabIndex = 11;
            this.Generate.Text = "GEN CODE";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // cbEntityBase
            // 
            this.cbEntityBase.BackColor = System.Drawing.Color.White;
            this.cbEntityBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntityBase.FormattingEnabled = true;
            this.cbEntityBase.Location = new System.Drawing.Point(850, 182);
            this.cbEntityBase.Name = "cbEntityBase";
            this.cbEntityBase.Size = new System.Drawing.Size(199, 23);
            this.cbEntityBase.TabIndex = 12;
            // 
            // cbEntityDtoBase
            // 
            this.cbEntityDtoBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEntityDtoBase.FormattingEnabled = true;
            this.cbEntityDtoBase.Location = new System.Drawing.Point(850, 232);
            this.cbEntityDtoBase.Name = "cbEntityDtoBase";
            this.cbEntityDtoBase.Size = new System.Drawing.Size(199, 23);
            this.cbEntityDtoBase.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(719, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Entity Dto Base Class:";
            // 
            // txtPathApplication
            // 
            this.txtPathApplication.Location = new System.Drawing.Point(186, 81);
            this.txtPathApplication.Name = "txtPathApplication";
            this.txtPathApplication.Size = new System.Drawing.Size(404, 23);
            this.txtPathApplication.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Path Application:";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(850, 79);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(199, 23);
            this.txtTableName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(741, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Entity Base Class:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Table Name:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectPathApp
            // 
            this.btnSelectPathApp.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelectPathApp.Location = new System.Drawing.Point(596, 79);
            this.btnSelectPathApp.Name = "btnSelectPathApp";
            this.btnSelectPathApp.Size = new System.Drawing.Size(32, 26);
            this.btnSelectPathApp.TabIndex = 0;
            this.btnSelectPathApp.Text = "...";
            this.btnSelectPathApp.UseVisualStyleBackColor = false;
            this.btnSelectPathApp.Click += new System.EventHandler(this.btnSelectPathApp_Click);
            // 
            // btnSelectPathAppShared
            // 
            this.btnSelectPathAppShared.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelectPathAppShared.Location = new System.Drawing.Point(596, 132);
            this.btnSelectPathAppShared.Name = "btnSelectPathAppShared";
            this.btnSelectPathAppShared.Size = new System.Drawing.Size(32, 25);
            this.btnSelectPathAppShared.TabIndex = 20;
            this.btnSelectPathAppShared.Text = "...";
            this.btnSelectPathAppShared.UseVisualStyleBackColor = false;
            this.btnSelectPathAppShared.Click += new System.EventHandler(this.btnSelectPathAppShared_Click);
            // 
            // btnSelectPathCore
            // 
            this.btnSelectPathCore.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelectPathCore.Location = new System.Drawing.Point(596, 185);
            this.btnSelectPathCore.Name = "btnSelectPathCore";
            this.btnSelectPathCore.Size = new System.Drawing.Size(32, 24);
            this.btnSelectPathCore.TabIndex = 21;
            this.btnSelectPathCore.Text = "...";
            this.btnSelectPathCore.UseVisualStyleBackColor = false;
            this.btnSelectPathCore.Click += new System.EventHandler(this.btnSelectPathCore_Click);
            // 
            // txtPathMvc
            // 
            this.txtPathMvc.Location = new System.Drawing.Point(186, 236);
            this.txtPathMvc.Name = "txtPathMvc";
            this.txtPathMvc.Size = new System.Drawing.Size(404, 23);
            this.txtPathMvc.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 15);
            this.label8.TabIndex = 23;
            this.label8.Text = "Path Mvc:";
            // 
            // btnSelectPathMvc
            // 
            this.btnSelectPathMvc.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelectPathMvc.Location = new System.Drawing.Point(596, 236);
            this.btnSelectPathMvc.Name = "btnSelectPathMvc";
            this.btnSelectPathMvc.Size = new System.Drawing.Size(32, 24);
            this.btnSelectPathMvc.TabIndex = 24;
            this.btnSelectPathMvc.Text = "...";
            this.btnSelectPathMvc.UseVisualStyleBackColor = false;
            this.btnSelectPathMvc.Click += new System.EventHandler(this.btnSelectPathMvc_Click);
            // 
            // cbCreateOrEditEntityDtoBase
            // 
            this.cbCreateOrEditEntityDtoBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCreateOrEditEntityDtoBase.FormattingEnabled = true;
            this.cbCreateOrEditEntityDtoBase.Location = new System.Drawing.Point(850, 284);
            this.cbCreateOrEditEntityDtoBase.Name = "cbCreateOrEditEntityDtoBase";
            this.cbCreateOrEditEntityDtoBase.Size = new System.Drawing.Size(199, 23);
            this.cbCreateOrEditEntityDtoBase.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(690, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 15);
            this.label9.TabIndex = 26;
            this.label9.Text = "C&&U Entity Dto Base Class:";
            // 
            // txtAppArea
            // 
            this.txtAppArea.Location = new System.Drawing.Point(186, 287);
            this.txtAppArea.Name = "txtAppArea";
            this.txtAppArea.Size = new System.Drawing.Size(194, 23);
            this.txtAppArea.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(82, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "App Area Name:";
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(322, 0);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(75, 23);
            this.btnAddRow.TabIndex = 29;
            this.btnAddRow.Text = "Add row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Controls.Add(this.btnAddRow);
            this.groupBox1.Location = new System.Drawing.Point(652, 341);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 275);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Properties:";
            // 
            // gridControl1
            // 
            this.gridControl1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridControl1.GridColor = System.Drawing.SystemColors.Window;
            this.gridControl1.Location = new System.Drawing.Point(6, 28);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RowTemplate.Height = 25;
            this.gridControl1.Size = new System.Drawing.Size(402, 239);
            this.gridControl1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(186, 367);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 118);
            this.richTextBox1.TabIndex = 31;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(186, 491);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(408, 117);
            this.richTextBox2.TabIndex = 32;
            this.richTextBox2.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 15);
            this.label11.TabIndex = 33;
            this.label11.Text = "List Permission:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 491);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 15);
            this.label12.TabIndex = 34;
            this.label12.Text = "Add Permission:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(518, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 15);
            this.label13.TabIndex = 35;
            this.label13.Text = "GENERATE CODE TOOL ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1129, 696);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAppArea);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbCreateOrEditEntityDtoBase);
            this.Controls.Add(this.btnSelectPathMvc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPathMvc);
            this.Controls.Add(this.btnSelectPathCore);
            this.Controls.Add(this.btnSelectPathAppShared);
            this.Controls.Add(this.btnSelectPathApp);
            this.Controls.Add(this.cbEntityDtoBase);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPathApplication);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbEntityBase);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEntityName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPathCore);
            this.Controls.Add(this.txtPathApplicationShared);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPathApplicationShared;
        private System.Windows.Forms.TextBox txtPathCore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtEntityName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.ComboBox cbEntityBaseExtension;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPathApplication;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEntityDtoBase;
        private System.Windows.Forms.ComboBox cbEntityBase;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectPathApp;
        private System.Windows.Forms.Button btnSelectPathAppShared;
        private System.Windows.Forms.Button btnSelectPathCore;
        private System.Windows.Forms.TextBox txtPathMvc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSelectPathMvc;
        private System.Windows.Forms.TextBox txtViewResources;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnViewResource;
        private System.Windows.Forms.ComboBox cbCreateOrEdit;
        private System.Windows.Forms.ComboBox cbCreateOrEditEntityDtoBase;
        private System.Windows.Forms.TextBox txtAppArea;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Generates;
        private System.Windows.Forms.DataGridView gridControl1;
        private System.Windows.Forms.DataGridView gridControl;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
