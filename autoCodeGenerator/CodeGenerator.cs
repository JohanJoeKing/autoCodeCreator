using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/********************************************************
 * - Class name : CodeGenerator.cs
 * - Author : Chang Liu   Version : 1.0   Date : 2018/4/15
 * - Description : // 面向对象编程时的代码自动生成器
 *                 // 生成器类
 * - Function list : 
 * //
 * - Others : 
 * //
 ********************************************************/

namespace autoCodeGenerator
{
    class CodeGenerator
    {
        // 类的基本参数
        string cgClassName;
        string cgLanguage;
        int cgTextIndent;

        // 属性
        Attribute[] atr;
        private int atrNum;
        private const int MAX_ATTR = 100;

        // 支持项
        private string[] atrs;
        private string[] sets;
        private string[] gets;
        private int SN;
        private int GN;

        // set函数
        public void setClassName(string cgClassName) { this.cgClassName = cgClassName; }
        public void setLanguage(string cgLanguage) { this.cgLanguage = cgLanguage; }
        public void setTextIndent(int cgTextIndent) { this.cgTextIndent = cgTextIndent; }




        /**************************************************
         * Function name : CodeGenerator
         * Description : 构造函数
         * Variables : void
         **************************************************/
        public CodeGenerator()
        {
            atrs = new string[MAX_ATTR];
            sets = new string[MAX_ATTR];
            gets = new string[MAX_ATTR];
            atr = new Attribute[MAX_ATTR];
            for (int i = 0; i < MAX_ATTR; i++)
            {
                atr[i] = new Attribute();
            }
            atrNum = 0;
        }





        /**************************************************
         * Function name : addAttribute
         * Description : 添加属性
         * Variables : string status, string type, string name, string note,
         *             bool ifConst, bool needSet, bool needGet
         **************************************************/
        public bool addAttribute(string status, string type, string name, string note,
            string def, bool ifConst, bool needSet, bool needGet)
        {
            atr[atrNum].setStatus(status);
            atr[atrNum].setType(type);
            atr[atrNum].setAttributeName(name);
            atr[atrNum].setDefValue(def);
            atr[atrNum].setNote(note);
            atr[atrNum].setIfConst(ifConst);
            atr[atrNum].setNeedGet(needGet);
            atr[atrNum].setNeedSet(needSet);
            atrNum++;
            return true;
        }




        /**************************************************
         * Function name : generateCode
         * Description : 生成代码
         * Variables : string savePath
         **************************************************/
        public void generateCode(string savePath)
        {
            // 组织代码
            createParagraphs();

            // 创建文件
            string path = savePath + "\\" + cgClassName + ".txt";
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);

            string head = "";
            for (int j = 0; j < cgTextIndent; j++)
            {
                head += "\t";
            }
            // 写入属性区
            for (int i = 0; i < atrNum; i++)
            {
                sw.WriteLine(head + atrs[i]);
            }
            sw.WriteLine("\n\n\n");

            // 写入set函数区
            for (int i = 0; i < SN; i++)
            {
                sw.WriteLine(head + sets[i]);
            }
            sw.WriteLine("\n\n\n");

            // 写入get函数区
            for (int i = 0; i < GN; i++)
            {
                sw.WriteLine(head + gets[i]);
            }
            sw.WriteLine("\n\n\n");


            sw.Close();
        }



        /**************************************************
         * Function name : createParagraphs
         * Description : 组织代码样式
         * Variables : 
         **************************************************/
        private void createParagraphs()
        {
            // 统计属性数、需要的set函数数、get函数数
            int AN = atrNum;
            for (int i = 0; i < AN; i++)
            {
                if (atr[i].getNeedSet())
                {
                    SN++;
                }
                if (atr[i].getNeedGet())
                {
                    GN++;
                }
            }

            // 属性声明区
            for (int i = 0; i < atrNum; i++)
            {
                atrs[i] += atr[i].getStatus() + " ";
                if (atr[i].getIfConst())
                {
                    if (cgLanguage == "Java")
                    {
                        atrs[i] += "final ";
                    }
                    else
                    {
                        atrs[i] += "const ";
                    }
                }
                atrs[i] += atr[i].getType() + " ";
                atrs[i] += atr[i].getAttributeName();
                if (atr[i].getDefValue() != "")
                {
                    atrs[i] += " = " + atr[i].getDefValue();
                }
                atrs[i] += ";";
                if (atr[i].getNote() != "")
                {
                    atrs[i] += "   //" + atr[i].getNote();
                }
            } // for

            // set函数区
            int si = 0;
            for (int i = 0; i < AN; i++)
            {
                if (atr[i].getNeedSet())
                {
                    string name = atr[i].getAttributeName();
                    string headChar = name.Substring(0, 1);
                    headChar = headChar.ToUpper();
                    sets[si] += "public void set" + headChar + name.Substring(1, name.Length - 1);
                    sets[si] += "(" + atr[i].getType() + " " + name + ")";
                    sets[si] += "{ this." + name + " = " + name + "; }";
                    si++;
                }
                else
                {
                    continue;
                }
            } // for

            // get函数区
            int gi = 0;
            for (int i = 0; i < AN; i++)
            {
                if (atr[i].getNeedGet())
                {
                    string name = atr[i].getAttributeName();
                    string headChar = name.Substring(0, 1).ToUpper();
                    gets[gi] += "public " + atr[i].getType() + " ";
                    gets[gi] += "get" + headChar + name.Substring(1, name.Length - 1) + "()";
                    gets[gi] += "{ return " + name + "; }";
                    gi++;
                }
                else
                {
                    continue;
                }
            } // for
        }
    }
}
