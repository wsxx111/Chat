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
    public partial class ComplexParaPanel : UserControl, IParameterPanel
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
                if (typeof(IEnumerable).IsAssignableFrom(this.argType) && (!typeof(IDictionary).IsAssignableFrom(this.argType)))
                {
                    Type t = typeof(CollectionWrapper<>).MakeGenericType(this.argType);
                    return t.InvokeMember("Items", System.Reflection.BindingFlags.GetProperty, null, this.propertyGrid1.SelectedObject, null);
                }
                else
                {
                    return this.propertyGrid1.SelectedObject;
                }
            }
        }

        public ComplexParaPanel(int paraIndex, Type paraType, string name, int width)
        {
            InitializeComponent();
            this.Width = width;

            this.argIndex = paraIndex;
            this.argType = paraType;

            this.skinLabel1.Text = string.Format("参数{0}：", paraIndex);
            this.skinLabel2.Text = string.Format("{0} - [{1}]", name, ESBasic.Helpers.TypeHelper.GetClassSimpleName(paraType));

            if (typeof(IEnumerable).IsAssignableFrom(this.argType) && (!typeof(IDictionary).IsAssignableFrom(this.argType)))
            {
                Type t = typeof(CollectionWrapper<>).MakeGenericType(this.argType);
                this.propertyGrid1.SelectedObject = Activator.CreateInstance(t);
            }
            else
            {
                this.propertyGrid1.SelectedObject = Activator.CreateInstance(this.argType);
            }            
        }        
    }

    public class CollectionWrapper<T> where T : new()
    {
        private T items = new T();
        public T Items
        {
            get { return items; }
            set { items = value; }
        }

    }
}
