namespace WindowsFormsApp6
{
    partial class TittleForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AuthForm = new System.Windows.Forms.Button();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btClear = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.btSave = new System.Windows.Forms.Button();
            this.tbDB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.gbServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(185, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Деский Развлекательный Клуб";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(452, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Настройки подключения";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AuthForm
            // 
            this.AuthForm.Location = new System.Drawing.Point(337, 130);
            this.AuthForm.Name = "AuthForm";
            this.AuthForm.Size = new System.Drawing.Size(109, 37);
            this.AuthForm.TabIndex = 3;
            this.AuthForm.Text = "Авторизация";
            this.AuthForm.UseVisualStyleBackColor = true;
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.label6);
            this.gbServer.Controls.Add(this.btClear);
            this.gbServer.Controls.Add(this.tbPassword);
            this.gbServer.Controls.Add(this.button6);
            this.gbServer.Controls.Add(this.btLoad);
            this.gbServer.Controls.Add(this.btSave);
            this.gbServer.Controls.Add(this.tbDB);
            this.gbServer.Controls.Add(this.label4);
            this.gbServer.Controls.Add(this.label3);
            this.gbServer.Controls.Add(this.label2);
            this.gbServer.Controls.Add(this.tbPort);
            this.gbServer.Controls.Add(this.tbServer);
            this.gbServer.Location = new System.Drawing.Point(12, 175);
            this.gbServer.Name = "gbServer";
            this.gbServer.Size = new System.Drawing.Size(701, 107);
            this.gbServer.TabIndex = 4;
            this.gbServer.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Пароль";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(252, 69);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(215, 20);
            this.btClear.TabIndex = 8;
            this.btClear.Text = "По умолчанию";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(302, 43);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(165, 20);
            this.tbPassword.TabIndex = 7;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(473, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(215, 20);
            this.button6.TabIndex = 8;
            this.button6.Text = "Открыть папку";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(473, 43);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(215, 20);
            this.btLoad.TabIndex = 7;
            this.btLoad.Text = "Загрузить";
            this.btLoad.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(473, 17);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(215, 20);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Сохранить";
            this.btSave.UseVisualStyleBackColor = true;
            // 
            // tbDB
            // 
            this.tbDB.Location = new System.Drawing.Point(85, 68);
            this.tbDB.Name = "tbDB";
            this.tbDB.Size = new System.Drawing.Size(161, 20);
            this.tbDB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "База данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Порт";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сервер";
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(57, 43);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(189, 20);
            this.tbPort.TabIndex = 1;
            // 
            // tbServer
            // 
            this.tbServer.Location = new System.Drawing.Point(57, 17);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(189, 20);
            this.tbServer.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Логин";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(314, 192);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(165, 20);
            this.tbLogin.TabIndex = 5;
            // 
            // TittleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 291);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.gbServer);
            this.Controls.Add(this.AuthForm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "TittleForm";
            this.Text = "Детский развлекатьный клуб";
            this.Load += new System.EventHandler(this.TittleForm_Load);
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AuthForm;
        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TextBox tbDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLogin;
    }
}

