namespace Projeto3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Destino = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nome = new System.Windows.Forms.TextBox();
            this.button_Sair = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Onibus = new System.Windows.Forms.RadioButton();
            this.radioButton_Aviao = new System.Windows.Forms.RadioButton();
            this.groupBox_Resultado = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_gastoTransporte = new System.Windows.Forms.Label();
            this.labelgastoDestino = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox_Resultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data de embarque";
            // 
            // comboBox_Destino
            // 
            this.comboBox_Destino.FormattingEnabled = true;
            this.comboBox_Destino.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "SC"});
            this.comboBox_Destino.Location = new System.Drawing.Point(63, 113);
            this.comboBox_Destino.Name = "comboBox_Destino";
            this.comboBox_Destino.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Destino.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // textBox_Nome
            // 
            this.textBox_Nome.Location = new System.Drawing.Point(63, 85);
            this.textBox_Nome.Name = "textBox_Nome";
            this.textBox_Nome.Size = new System.Drawing.Size(383, 20);
            this.textBox_Nome.TabIndex = 6;
            // 
            // button_Sair
            // 
            this.button_Sair.Location = new System.Drawing.Point(452, 81);
            this.button_Sair.Name = "button_Sair";
            this.button_Sair.Size = new System.Drawing.Size(106, 33);
            this.button_Sair.TabIndex = 12;
            this.button_Sair.Text = "Sair";
            this.button_Sair.UseVisualStyleBackColor = true;
            this.button_Sair.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(452, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Limpar dados";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button4.Location = new System.Drawing.Point(452, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 89);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(452, 178);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(106, 41);
            this.button5.TabIndex = 16;
            this.button5.Text = "Calculadora valor da viagem";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(210, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.radioButton_Onibus);
            this.groupBox1.Controls.Add(this.radioButton_Aviao);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(15, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 59);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meio de Transporte";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButton_Onibus
            // 
            this.radioButton_Onibus.AutoSize = true;
            this.radioButton_Onibus.Location = new System.Drawing.Point(74, 19);
            this.radioButton_Onibus.Name = "radioButton_Onibus";
            this.radioButton_Onibus.Size = new System.Drawing.Size(58, 17);
            this.radioButton_Onibus.TabIndex = 1;
            this.radioButton_Onibus.TabStop = true;
            this.radioButton_Onibus.Text = "Onibus";
            this.radioButton_Onibus.UseVisualStyleBackColor = true;
            // 
            // radioButton_Aviao
            // 
            this.radioButton_Aviao.AutoSize = true;
            this.radioButton_Aviao.Location = new System.Drawing.Point(16, 19);
            this.radioButton_Aviao.Name = "radioButton_Aviao";
            this.radioButton_Aviao.Size = new System.Drawing.Size(52, 17);
            this.radioButton_Aviao.TabIndex = 0;
            this.radioButton_Aviao.TabStop = true;
            this.radioButton_Aviao.Text = "Avião";
            this.radioButton_Aviao.UseVisualStyleBackColor = true;
            // 
            // groupBox_Resultado
            // 
            this.groupBox_Resultado.Controls.Add(this.label_total);
            this.groupBox_Resultado.Controls.Add(this.labelgastoDestino);
            this.groupBox_Resultado.Controls.Add(this.label_gastoTransporte);
            this.groupBox_Resultado.Location = new System.Drawing.Point(15, 233);
            this.groupBox_Resultado.Name = "groupBox_Resultado";
            this.groupBox_Resultado.Size = new System.Drawing.Size(200, 75);
            this.groupBox_Resultado.TabIndex = 19;
            this.groupBox_Resultado.TabStop = false;
            this.groupBox_Resultado.Text = "Valores de Pacote";
            this.groupBox_Resultado.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label4.Location = new System.Drawing.Point(109, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(337, 37);
            this.label4.TabIndex = 20;
            this.label4.Text = "Reserva de Passagem";
            // 
            // label_gastoTransporte
            // 
            this.label_gastoTransporte.AutoSize = true;
            this.label_gastoTransporte.Location = new System.Drawing.Point(7, 20);
            this.label_gastoTransporte.Name = "label_gastoTransporte";
            this.label_gastoTransporte.Size = new System.Drawing.Size(92, 13);
            this.label_gastoTransporte.TabIndex = 0;
            this.label_gastoTransporte.Text = "Gasto Transporte:";
            // 
            // labelgastoDestino
            // 
            this.labelgastoDestino.AutoSize = true;
            this.labelgastoDestino.Location = new System.Drawing.Point(7, 33);
            this.labelgastoDestino.Name = "labelgastoDestino";
            this.labelgastoDestino.Size = new System.Drawing.Size(100, 13);
            this.labelgastoDestino.TabIndex = 1;
            this.labelgastoDestino.Text = "Gasto com Destino:";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(7, 46);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(61, 13);
            this.label_total.TabIndex = 2;
            this.label_total.Text = "Valor Total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(561, 334);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox_Resultado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_Sair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Destino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Nome);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Name = "Form1";
            this.Text = "Agencia de Viagens-FATEC ITU";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Resultado.ResumeLayout(false);
            this.groupBox_Resultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Destino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nome;
        private System.Windows.Forms.Button button_Sair;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Onibus;
        private System.Windows.Forms.RadioButton radioButton_Aviao;
        private System.Windows.Forms.GroupBox groupBox_Resultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label labelgastoDestino;
        private System.Windows.Forms.Label label_gastoTransporte;
    }
}

