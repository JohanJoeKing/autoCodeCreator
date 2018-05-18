using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/********************************************************
 * - Class name : Form1.cs
 * - Author : Chang Liu   Version : 1.0   Date : 2018/4/15
 * - Description : // 面向对象编程时的代码自动生成器
 *                 // 程序主界面
 * - Function list : 
 * //
 * - Others : 
 * //
 ********************************************************/

namespace autoCodeGenerator
{
    public partial class Form1 : Form
    {
        // 生成器
        private CodeGenerator CG;

        public Form1()
        {
            InitializeComponent();
            CG = new CodeGenerator();
            comboBoxLanguage.Items.Add("Java");
            comboBoxLanguage.Items.Add("C#");
            comboBoxLanguage.Text = "Java";
            comboBoxStatus.Items.Add("private");
            comboBoxStatus.Items.Add("protected");
            comboBoxStatus.Items.Add("public");
            comboBoxStatus.Text = "private";
        }

        /**************************************************
         * Function name : buttonAddAttribute_Click
         * Description : 添加属性
         * Variables : object sender, EventArgs e
         **************************************************/
        private void buttonAddAttribute_Click(object sender, EventArgs e)
        {
            // 收集参数
            string status = comboBoxStatus.Text.ToString();
            string type = textBoxType.Text.ToString();
            string name = textBoxAttributeName.Text.ToString();
            string def = textBoxDefault.Text.ToString();
            string note = textBoxNotes.Text.ToString();
            bool ifConst = false, needSet = false, needGet = false;
            if (checkBoxStatic.Checked == true)
            {
                ifConst = true;
            }
            if (checkBoxSetMethod.Checked == true)
            {
                needSet = true;
            }
            if (checkBoxGetMethod.Checked == true)
            {
                needGet = true;
            }

            // 添加到属性列
            CG.addAttribute(status, type, name, note, def, ifConst, needSet, needGet);
            string str = status + "_";
            if (ifConst)
            {
                str += "const_";
            }
            str += type + "_" + name;
            if (def != "")
            {
                str += "_default=" + def;
            }
            if (needSet)
            {
                str += "_set";
            }
            if (needGet)
            {
                str += "_get";
            }
            str += "_" + note;
            listBoxClass.Items.Add(str);

            // 还原输入框
            textBoxType.Text = "";
            textBoxAttributeName.Text = "";
            textBoxDefault.Text = "";
            textBoxNotes.Text = "";
            checkBoxStatic.Checked = false;
            checkBoxSetMethod.Checked = false;
            checkBoxGetMethod.Checked = false;
        }






        /**************************************************
         * Function name : buttonGenerateCode_Click
         * Description : 开始生成代码
         * Variables : object sender, EventArgs e
         **************************************************/
        private void buttonGenerateCode_Click(object sender, EventArgs e)
        {
            // 获取路径
            string savePath = textBoxSavePath.Text.ToString();
            if (savePath == "")
            {
                MessageBox.Show("请选择txt文件保存路径");
                return;
            }

            // 检查缺省
            if (textBoxClassName.Text.ToString() == ""
                || textBoxHead.Text.ToString() == "")
            {
                MessageBox.Show("请输入类的完整信息！");
                return;
            }


            // 获取类参数
            CG.setClassName(textBoxClassName.Text.ToString());
            CG.setLanguage(comboBoxLanguage.Text.ToString());
            if (textBoxHead.Text.ToString() == "")
            {
                CG.setTextIndent(0);
            }
            else
            {
                CG.setTextIndent(Int16.Parse(textBoxHead.Text.ToString()));
            }

            // 开始生成
            CG.generateCode(savePath);

            MessageBox.Show("生成完毕！");
        }






        /**************************************************
         * Function name : buttonOpenDirectory_Click
         * Description : 打开文件夹
         * Variables : object sender, EventArgs e
         **************************************************/
        private void buttonOpenDirectory_Click(object sender, EventArgs e)
        {
            string savePath;
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择保存路径";
            dialog.ShowNewFolderButton = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                savePath = dialog.SelectedPath;
                textBoxSavePath.Text = savePath;
            }
        }
    }
}
