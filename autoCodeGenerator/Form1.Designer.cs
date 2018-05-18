namespace autoCodeGenerator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxClassName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxHead = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxClass = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxAttributeName = new System.Windows.Forms.TextBox();
            this.checkBoxStatic = new System.Windows.Forms.CheckBox();
            this.textBoxNotes = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxSetMethod = new System.Windows.Forms.CheckBox();
            this.checkBoxGetMethod = new System.Windows.Forms.CheckBox();
            this.buttonAddAttribute = new System.Windows.Forms.Button();
            this.buttonGenerateCode = new System.Windows.Forms.Button();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.buttonOpenDirectory = new System.Windows.Forms.Button();
            this.textBoxDefault = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxHead);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxLanguage);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxClassName);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本属性";
            // 
            // textBoxClassName
            // 
            this.textBoxClassName.Location = new System.Drawing.Point(65, 20);
            this.textBoxClassName.Name = "textBoxClassName";
            this.textBoxClassName.Size = new System.Drawing.Size(88, 21);
            this.textBoxClassName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "类名";
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Location = new System.Drawing.Point(65, 48);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(88, 20);
            this.comboBoxLanguage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "语言";
            // 
            // textBoxHead
            // 
            this.textBoxHead.Location = new System.Drawing.Point(65, 75);
            this.textBoxHead.Name = "textBoxHead";
            this.textBoxHead.Size = new System.Drawing.Size(88, 21);
            this.textBoxHead.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "首行缩进";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxClass);
            this.groupBox2.Location = new System.Drawing.Point(178, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 441);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "属性列表";
            // 
            // listBoxClass
            // 
            this.listBoxClass.FormattingEnabled = true;
            this.listBoxClass.ItemHeight = 12;
            this.listBoxClass.Location = new System.Drawing.Point(6, 20);
            this.listBoxClass.Name = "listBoxClass";
            this.listBoxClass.Size = new System.Drawing.Size(427, 412);
            this.listBoxClass.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.textBoxDefault);
            this.groupBox4.Controls.Add(this.buttonAddAttribute);
            this.groupBox4.Controls.Add(this.checkBoxGetMethod);
            this.groupBox4.Controls.Add(this.checkBoxSetMethod);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBoxNotes);
            this.groupBox4.Controls.Add(this.checkBoxStatic);
            this.groupBox4.Controls.Add(this.textBoxAttributeName);
            this.groupBox4.Controls.Add(this.comboBoxStatus);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBoxType);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(13, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(159, 329);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "添加属性";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "属性名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "数据类型";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(65, 44);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(88, 21);
            this.textBoxType.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "权限";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(65, 18);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(88, 20);
            this.comboBoxStatus.TabIndex = 6;
            // 
            // textBoxAttributeName
            // 
            this.textBoxAttributeName.Location = new System.Drawing.Point(65, 71);
            this.textBoxAttributeName.Name = "textBoxAttributeName";
            this.textBoxAttributeName.Size = new System.Drawing.Size(88, 21);
            this.textBoxAttributeName.TabIndex = 7;
            // 
            // checkBoxStatic
            // 
            this.checkBoxStatic.AutoSize = true;
            this.checkBoxStatic.Location = new System.Drawing.Point(8, 220);
            this.checkBoxStatic.Name = "checkBoxStatic";
            this.checkBoxStatic.Size = new System.Drawing.Size(72, 16);
            this.checkBoxStatic.TabIndex = 8;
            this.checkBoxStatic.Text = "静态变量";
            this.checkBoxStatic.UseVisualStyleBackColor = true;
            // 
            // textBoxNotes
            // 
            this.textBoxNotes.Location = new System.Drawing.Point(8, 158);
            this.textBoxNotes.Multiline = true;
            this.textBoxNotes.Name = "textBoxNotes";
            this.textBoxNotes.Size = new System.Drawing.Size(145, 56);
            this.textBoxNotes.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "注释";
            // 
            // checkBoxSetMethod
            // 
            this.checkBoxSetMethod.AutoSize = true;
            this.checkBoxSetMethod.Location = new System.Drawing.Point(8, 243);
            this.checkBoxSetMethod.Name = "checkBoxSetMethod";
            this.checkBoxSetMethod.Size = new System.Drawing.Size(96, 16);
            this.checkBoxSetMethod.TabIndex = 11;
            this.checkBoxSetMethod.Text = "set函数/方法";
            this.checkBoxSetMethod.UseVisualStyleBackColor = true;
            // 
            // checkBoxGetMethod
            // 
            this.checkBoxGetMethod.AutoSize = true;
            this.checkBoxGetMethod.Location = new System.Drawing.Point(8, 266);
            this.checkBoxGetMethod.Name = "checkBoxGetMethod";
            this.checkBoxGetMethod.Size = new System.Drawing.Size(96, 16);
            this.checkBoxGetMethod.TabIndex = 12;
            this.checkBoxGetMethod.Text = "get函数/方法";
            this.checkBoxGetMethod.UseVisualStyleBackColor = true;
            // 
            // buttonAddAttribute
            // 
            this.buttonAddAttribute.Location = new System.Drawing.Point(7, 290);
            this.buttonAddAttribute.Name = "buttonAddAttribute";
            this.buttonAddAttribute.Size = new System.Drawing.Size(146, 30);
            this.buttonAddAttribute.TabIndex = 13;
            this.buttonAddAttribute.Text = "添加属性";
            this.buttonAddAttribute.UseVisualStyleBackColor = true;
            this.buttonAddAttribute.Click += new System.EventHandler(this.buttonAddAttribute_Click);
            // 
            // buttonGenerateCode
            // 
            this.buttonGenerateCode.Location = new System.Drawing.Point(489, 460);
            this.buttonGenerateCode.Name = "buttonGenerateCode";
            this.buttonGenerateCode.Size = new System.Drawing.Size(122, 23);
            this.buttonGenerateCode.TabIndex = 4;
            this.buttonGenerateCode.Text = "开始生成代码";
            this.buttonGenerateCode.UseVisualStyleBackColor = true;
            this.buttonGenerateCode.Click += new System.EventHandler(this.buttonGenerateCode_Click);
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Location = new System.Drawing.Point(13, 460);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.Size = new System.Drawing.Size(412, 21);
            this.textBoxSavePath.TabIndex = 5;
            // 
            // buttonOpenDirectory
            // 
            this.buttonOpenDirectory.Location = new System.Drawing.Point(432, 460);
            this.buttonOpenDirectory.Name = "buttonOpenDirectory";
            this.buttonOpenDirectory.Size = new System.Drawing.Size(51, 23);
            this.buttonOpenDirectory.TabIndex = 6;
            this.buttonOpenDirectory.Text = "打开";
            this.buttonOpenDirectory.UseVisualStyleBackColor = true;
            this.buttonOpenDirectory.Click += new System.EventHandler(this.buttonOpenDirectory_Click);
            // 
            // textBoxDefault
            // 
            this.textBoxDefault.Location = new System.Drawing.Point(65, 99);
            this.textBoxDefault.Name = "textBoxDefault";
            this.textBoxDefault.Size = new System.Drawing.Size(88, 21);
            this.textBoxDefault.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "默认值";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 495);
            this.Controls.Add(this.buttonOpenDirectory);
            this.Controls.Add(this.textBoxSavePath);
            this.Controls.Add(this.buttonGenerateCode);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "面向对象编程-类代码自动生成器";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxClassName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxHead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxClass;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAddAttribute;
        private System.Windows.Forms.CheckBox checkBoxGetMethod;
        private System.Windows.Forms.CheckBox checkBoxSetMethod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNotes;
        private System.Windows.Forms.CheckBox checkBoxStatic;
        private System.Windows.Forms.TextBox textBoxAttributeName;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Button buttonGenerateCode;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Button buttonOpenDirectory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDefault;
    }
}

