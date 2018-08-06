using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace InterfaceTester
{
    public partial class ParameterPanel : UserControl, InterfaceTester.IParameterPanel
    {
        private int argIndex = 0;
        public int ArgIndex
        {
            get { return argIndex; }          
        }

        private Type argType = null;
        public Type ArgType
        {
            get { return argType; }            
        }
       
        public object ArgValue
        {
            get 
            {
                return ESBasic.Helpers.TypeHelper.ChangeType(this.argType, this.textBox1.Text);                
            }            
        }

        public ParameterPanel(int paraIndex, Type paraType, string name, int width)
        {
            InitializeComponent();
            this.Width = width;

            this.argIndex = paraIndex;
            this.argType = paraType;

            this.skinLabel1.Text = string.Format("参数{0}：" ,paraIndex);
            this.skinLabel2.Text = string.Format("{0} - [{1}]", name , ESBasic.Helpers.TypeHelper.GetClassSimpleName(paraType));
            object def =ESBasic.Helpers.TypeHelper.GetDefaultValue(paraType) ;
            if (def != null)
            {
                this.textBox1.Text = def.ToString();
            }
        }
    }
}
