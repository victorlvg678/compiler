namespace compiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonLexicalAnalyzer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxSyntaxAnalyzeOutput = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.buttonSintaxAnalyzer = new System.Windows.Forms.Button();
            this.buttonSemanticAnalyzer = new System.Windows.Forms.Button();
            this.listViewSymbolsTable = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.textBoxGeneratedASM = new System.Windows.Forms.TextBox();
            this.buttonGenerateAsmCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLexicalAnalyzer
            // 
            this.buttonLexicalAnalyzer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(214)))), ((int)(((byte)(160)))));
            this.buttonLexicalAnalyzer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLexicalAnalyzer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLexicalAnalyzer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLexicalAnalyzer.ForeColor = System.Drawing.Color.Black;
            this.buttonLexicalAnalyzer.Location = new System.Drawing.Point(192, 294);
            this.buttonLexicalAnalyzer.Name = "buttonLexicalAnalyzer";
            this.buttonLexicalAnalyzer.Size = new System.Drawing.Size(220, 60);
            this.buttonLexicalAnalyzer.TabIndex = 0;
            this.buttonLexicalAnalyzer.Text = "Análisis Léxico";
            this.buttonLexicalAnalyzer.UseVisualStyleBackColor = false;
            this.buttonLexicalAnalyzer.Click += new System.EventHandler(this.buttonLexicalAnalyzer_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(476, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 54);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.textBoxInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.textBoxInput.Location = new System.Drawing.Point(28, 34);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.PlaceholderText = "Ingresa el código a analizar:";
            this.textBoxInput.Size = new System.Drawing.Size(550, 250);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // textBoxSyntaxAnalyzeOutput
            // 
            this.textBoxSyntaxAnalyzeOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(46)))));
            this.textBoxSyntaxAnalyzeOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSyntaxAnalyzeOutput.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxSyntaxAnalyzeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxSyntaxAnalyzeOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(175)))), ((int)(((byte)(239)))));
            this.textBoxSyntaxAnalyzeOutput.Location = new System.Drawing.Point(28, 368);
            this.textBoxSyntaxAnalyzeOutput.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.textBoxSyntaxAnalyzeOutput.Multiline = true;
            this.textBoxSyntaxAnalyzeOutput.Name = "textBoxSyntaxAnalyzeOutput";
            this.textBoxSyntaxAnalyzeOutput.ReadOnly = true;
            this.textBoxSyntaxAnalyzeOutput.Size = new System.Drawing.Size(550, 250);
            this.textBoxSyntaxAnalyzeOutput.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HoverSelection = true;
            this.listView1.Location = new System.Drawing.Point(618, 34);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(550, 250);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lexema";
            this.columnHeader1.Width = 195;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Token";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 195;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tipo";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 195;
            // 
            // buttonSintaxAnalyzer
            // 
            this.buttonSintaxAnalyzer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.buttonSintaxAnalyzer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSintaxAnalyzer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSintaxAnalyzer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSintaxAnalyzer.ForeColor = System.Drawing.Color.Black;
            this.buttonSintaxAnalyzer.Location = new System.Drawing.Point(163, 632);
            this.buttonSintaxAnalyzer.Name = "buttonSintaxAnalyzer";
            this.buttonSintaxAnalyzer.Size = new System.Drawing.Size(220, 60);
            this.buttonSintaxAnalyzer.TabIndex = 6;
            this.buttonSintaxAnalyzer.Text = "Análisis Sintáctico";
            this.buttonSintaxAnalyzer.UseVisualStyleBackColor = false;
            this.buttonSintaxAnalyzer.Click += new System.EventHandler(this.buttonSintaxAnalyzer_Click_1);
            // 
            // buttonSemanticAnalyzer
            // 
            this.buttonSemanticAnalyzer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(71)))), ((int)(((byte)(111)))));
            this.buttonSemanticAnalyzer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSemanticAnalyzer.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSemanticAnalyzer.Location = new System.Drawing.Point(778, 632);
            this.buttonSemanticAnalyzer.Name = "buttonSemanticAnalyzer";
            this.buttonSemanticAnalyzer.Size = new System.Drawing.Size(220, 60);
            this.buttonSemanticAnalyzer.TabIndex = 10;
            this.buttonSemanticAnalyzer.Text = "Análisis Semántico";
            this.buttonSemanticAnalyzer.UseVisualStyleBackColor = false;
            this.buttonSemanticAnalyzer.Click += new System.EventHandler(this.buttonSemanticAnalyzer_Click_1);
            // 
            // listViewSymbolsTable
            // 
            this.listViewSymbolsTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.listViewSymbolsTable.Location = new System.Drawing.Point(618, 371);
            this.listViewSymbolsTable.Name = "listViewSymbolsTable";
            this.listViewSymbolsTable.Size = new System.Drawing.Size(550, 247);
            this.listViewSymbolsTable.TabIndex = 11;
            this.listViewSymbolsTable.UseCompatibleStateImageBehavior = false;
            this.listViewSymbolsTable.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Variable";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Estatus";
            this.columnHeader5.Width = 350;
            // 
            // textBoxGeneratedASM
            // 
            this.textBoxGeneratedASM.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxGeneratedASM.Location = new System.Drawing.Point(1209, 175);
            this.textBoxGeneratedASM.Multiline = true;
            this.textBoxGeneratedASM.Name = "textBoxGeneratedASM";
            this.textBoxGeneratedASM.Size = new System.Drawing.Size(550, 247);
            this.textBoxGeneratedASM.TabIndex = 12;
            // 
            // buttonGenerateAsmCode
            // 
            this.buttonGenerateAsmCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(138)))), ((int)(((byte)(178)))));
            this.buttonGenerateAsmCode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGenerateAsmCode.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerateAsmCode.ForeColor = System.Drawing.Color.Black;
            this.buttonGenerateAsmCode.Location = new System.Drawing.Point(1373, 442);
            this.buttonGenerateAsmCode.Name = "buttonGenerateAsmCode";
            this.buttonGenerateAsmCode.Size = new System.Drawing.Size(260, 60);
            this.buttonGenerateAsmCode.TabIndex = 13;
            this.buttonGenerateAsmCode.Text = "Generador de Código";
            this.buttonGenerateAsmCode.UseVisualStyleBackColor = false;
            this.buttonGenerateAsmCode.Click += new System.EventHandler(this.buttonGenerateAsmCode_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1771, 761);
            this.Controls.Add(this.buttonGenerateAsmCode);
            this.Controls.Add(this.textBoxGeneratedASM);
            this.Controls.Add(this.listViewSymbolsTable);
            this.Controls.Add(this.buttonSemanticAnalyzer);
            this.Controls.Add(this.buttonSintaxAnalyzer);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxSyntaxAnalyzeOutput);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLexicalAnalyzer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subproducto 4 - Seminario de Traductores 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonLexicalAnalyzer;
        private Label label1;
        private TextBox textBoxInput;
        private TextBox textBoxSyntaxAnalyzeOutput;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button buttonSintaxAnalyzer;
        private Button buttonSemanticAnalyzer;
        private ListView listViewSymbolsTable;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox textBox1;
        private TextBox textBoxGeneratedASM;
        private Button button1;
        private TextBox textBox2;
        private Button buttonGenerateAsmCode;
    }
}