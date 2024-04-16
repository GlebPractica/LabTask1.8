namespace Task2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BttnEnterValues = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BttnAboutPlane = new System.Windows.Forms.Button();
            this.BttnAboutTrain = new System.Windows.Forms.Button();
            this.BttnAboutCar = new System.Windows.Forms.Button();
            this.BttnCalcTime = new System.Windows.Forms.Button();
            this.BttnCalcPrice = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 13);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(173, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Ввод значений для самолета";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(13, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(185, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Ввод значений для автомобиля";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 36);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(160, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Ввод значений для поезда";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(409, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(11, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(409, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите скорость т/с (км/ч)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите цену за 1 км пути";
            // 
            // BttnEnterValues
            // 
            this.BttnEnterValues.Location = new System.Drawing.Point(13, 206);
            this.BttnEnterValues.Name = "BttnEnterValues";
            this.BttnEnterValues.Size = new System.Drawing.Size(409, 30);
            this.BttnEnterValues.TabIndex = 7;
            this.BttnEnterValues.Text = "Принять";
            this.BttnEnterValues.UseVisualStyleBackColor = true;
            this.BttnEnterValues.Click += new System.EventHandler(this.BttnEnterValues_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(13, 280);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(409, 169);
            this.listBox1.TabIndex = 8;
            // 
            // BttnAboutPlane
            // 
            this.BttnAboutPlane.Location = new System.Drawing.Point(15, 251);
            this.BttnAboutPlane.Name = "BttnAboutPlane";
            this.BttnAboutPlane.Size = new System.Drawing.Size(113, 23);
            this.BttnAboutPlane.TabIndex = 9;
            this.BttnAboutPlane.Text = "Об самолете";
            this.BttnAboutPlane.UseVisualStyleBackColor = true;
            this.BttnAboutPlane.Click += new System.EventHandler(this.BttnAboutPlane_Click);
            // 
            // BttnAboutTrain
            // 
            this.BttnAboutTrain.Location = new System.Drawing.Point(162, 251);
            this.BttnAboutTrain.Name = "BttnAboutTrain";
            this.BttnAboutTrain.Size = new System.Drawing.Size(113, 23);
            this.BttnAboutTrain.TabIndex = 10;
            this.BttnAboutTrain.Text = "Об поезде";
            this.BttnAboutTrain.UseVisualStyleBackColor = true;
            this.BttnAboutTrain.Click += new System.EventHandler(this.BttnAboutTrain_Click);
            // 
            // BttnAboutCar
            // 
            this.BttnAboutCar.Location = new System.Drawing.Point(309, 251);
            this.BttnAboutCar.Name = "BttnAboutCar";
            this.BttnAboutCar.Size = new System.Drawing.Size(113, 23);
            this.BttnAboutCar.TabIndex = 11;
            this.BttnAboutCar.Text = "Об автомобиле";
            this.BttnAboutCar.UseVisualStyleBackColor = true;
            this.BttnAboutCar.Click += new System.EventHandler(this.BttnAboutCar_Click);
            // 
            // BttnCalcTime
            // 
            this.BttnCalcTime.Location = new System.Drawing.Point(266, 12);
            this.BttnCalcTime.Name = "BttnCalcTime";
            this.BttnCalcTime.Size = new System.Drawing.Size(75, 35);
            this.BttnCalcTime.TabIndex = 12;
            this.BttnCalcTime.Text = "Время прибытия";
            this.BttnCalcTime.UseVisualStyleBackColor = true;
            this.BttnCalcTime.Click += new System.EventHandler(this.BttnCalcTime_Click);
            // 
            // BttnCalcPrice
            // 
            this.BttnCalcPrice.Location = new System.Drawing.Point(347, 13);
            this.BttnCalcPrice.Name = "BttnCalcPrice";
            this.BttnCalcPrice.Size = new System.Drawing.Size(75, 35);
            this.BttnCalcPrice.TabIndex = 13;
            this.BttnCalcPrice.Text = "Цена за путь";
            this.BttnCalcPrice.UseVisualStyleBackColor = true;
            this.BttnCalcPrice.Click += new System.EventHandler(this.BttnCalcPrice_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Введите расстояние в км";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(11, 182);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(409, 20);
            this.textBox3.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.BttnCalcPrice);
            this.Controls.Add(this.BttnCalcTime);
            this.Controls.Add(this.BttnAboutCar);
            this.Controls.Add(this.BttnAboutTrain);
            this.Controls.Add(this.BttnAboutPlane);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BttnEnterValues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.Text = "Задание 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BttnEnterValues;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BttnAboutPlane;
        private System.Windows.Forms.Button BttnAboutTrain;
        private System.Windows.Forms.Button BttnAboutCar;
        private System.Windows.Forms.Button BttnCalcTime;
        private System.Windows.Forms.Button BttnCalcPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
    }
}

