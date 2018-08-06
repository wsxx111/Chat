using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace InterfaceTester
{
    public partial class DicPanel : UserControl, IParameterPanel
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
                return this.propertyGrid1.SelectedObject;
            }
        }

        public DicPanel(int paraIndex, Type paraType, string name ,int width)
        {            
            InitializeComponent();
            this.Width = width;

            if ((typeof(IDictionary<,>).IsAssignableFrom(this.argType)))
            {
                return;
            }

            this.argIndex = paraIndex;
            this.argType = paraType;

            this.skinLabel1.Text = string.Format("参数{0}：", paraIndex);
            this.skinLabel2.Text = string.Format("{0} - [{1}]", name, paraType);
       
            this.propertyGrid1.SelectedObject = Activator.CreateInstance(this.argType);
        }      

        private void skinButtom1_Click(object sender, EventArgs e)
        {
            try
            {
                IDictionary dic = (IDictionary)this.propertyGrid1.SelectedObject;
                dic.Add(ESBasic.Helpers.TypeHelper.ChangeType(this.argType.GetGenericArguments()[0], this.skinTextBox1.Text), ESBasic.Helpers.TypeHelper.ChangeType(this.argType.GetGenericArguments()[1], this.skinTextBox2.Text));
                this.propertyGrid1.Refresh();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }       
    }
}
