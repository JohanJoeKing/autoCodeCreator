using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************
 * - Class name : CodeGenerator.cs
 * - Author : Chang Liu   Version : 1.0   Date : 2018/4/15
 * - Description : // 面向对象编程时的代码自动生成器
 *                 // 属性类
 * - Function list : 
 * //
 * - Others : 
 * //
 ********************************************************/

namespace autoCodeGenerator
{
    class Attribute
    {
        // 属性的基本参数
        string status;
        string type;
        string attributeName;
        string defValue;
        string note;
        bool ifConst;
        bool needSet;
        bool needGet;
        
        // set函数
        public void setStatus(string status) { this.status = status; }
        public void setType(string type) { this.type = type; }
        public void setAttributeName(string attributeName) { this.attributeName = attributeName; }
        public void setDefValue(string defValue) { this.defValue = defValue; }
        public void setNote(string note) { this.note = note; }
        public void setIfConst(bool ifConst) { this.ifConst = ifConst; }
        public void setNeedSet(bool needSet) { this.needSet = needSet; }
        public void setNeedGet(bool needGet) { this.needGet = needGet; }

        public string getStatus() { return status; }
        public string getType() { return type; }
        public string getAttributeName() { return attributeName; }
        public string getDefValue() { return defValue; }
        public string getNote() { return note; }
        public bool getIfConst() { return ifConst; }
        public bool getNeedSet() { return needSet; }
        public bool getNeedGet() { return needGet; }

        /**************************************************
         * Function name : Attribute
         * Description : 构造函数
         * Variables : void
         **************************************************/
        public Attribute()
        {
            status = "private";
            defValue = "";
            note = "";
            ifConst = false;
            needSet = false;
            needGet = false;
        }
    }
}
