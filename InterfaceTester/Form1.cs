using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCWin;
using System.Reflection;

namespace InterfaceTester
{
    /*
     * 更多实用组件，请到 www.oraycn.com
     */ 

    public partial class Form1 : CCSkinMain
    {
        private Type targetInterface = null;
        private MethodInfo targetMethod = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void skinButtom1_Click(object sender, EventArgs e)
        {
            string filePath = ESBasic.Helpers.FileHelper.GetFileToOpen2("选择程序集", null, ".dll", ".exe");
            if (filePath == null)
            {
                return;                
            }

            try
            {
                this.textBox1.Text = filePath;
                Assembly asm = Assembly.LoadFile(filePath);
                Type[] types = asm.GetTypes();
                List<Type> interfaces = new List<Type>();
                foreach (Type t in types)
                {
                    if (t.IsInterface && t.IsPublic)
                    {
                        interfaces.Add(t);
                    }
                }

                this.skinComboBox_interType.DataSource = interfaces;
                if (interfaces.Count > 0)
                {
                    this.skinComboBox_interType.SelectedIndex = 0;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void skinComboBox_interType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Type> interfaces = (List<Type>)this.skinComboBox_interType.DataSource;
            this.targetInterface = interfaces[this.skinComboBox_interType.SelectedIndex];
            MethodInfo[] methods = this.targetInterface.GetMethods();
            this.skinComboBox_method.DataSource = methods;
            if (methods.Length > 0)
            {
                this.skinComboBox_method.SelectedIndex = 0;
            }
        }

        private void skinComboBox_method_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.skinComboBox_method.DataSource == null)
            {
                return;
            }
            try
            {
                this.flowLayoutPanel1.Controls.Clear();

                MethodInfo[] methods = (MethodInfo[])this.skinComboBox_method.DataSource;
                this.targetMethod = methods[this.skinComboBox_method.SelectedIndex];

                ParameterInfo[] paras = this.targetMethod.GetParameters();
                if (paras == null || paras.Length == 0)
                {
                    this.skinLabel_paraCount.Text = "None";
                    return;
                }

                this.skinLabel_paraCount.Text = paras.Length.ToString() + "个";
                for (int i = 0; i < paras.Length; i++)
                {
                    if (ESBasic.Helpers.TypeHelper.IsSimpleType(paras[i].ParameterType))
                    {
                        ParameterPanel panel = new ParameterPanel(i, paras[i].ParameterType, paras[i].Name ,this.flowLayoutPanel1.Width-25);
                        this.flowLayoutPanel1.Controls.Add(panel);
                    }
                    else if (paras[i].ParameterType.IsGenericType && (typeof(IDictionary<,>) == paras[i].ParameterType.GetGenericTypeDefinition() || typeof(Dictionary<,>) == paras[i].ParameterType.GetGenericTypeDefinition()))
                    {
                        DicPanel panel = new DicPanel(i, paras[i].ParameterType, paras[i].Name, this.flowLayoutPanel1.Width - 25);
                        this.flowLayoutPanel1.Controls.Add(panel);
                    }
                    else
                    {
                        ComplexParaPanel panel = new ComplexParaPanel(i, paras[i].ParameterType, paras[i].Name, this.flowLayoutPanel1.Width - 25);
                        this.flowLayoutPanel1.Controls.Add(panel);
                    }
                }

                this.flowLayoutPanel1.Focus();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private void skinButtom2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                object remotingObject = Activator.GetObject(this.targetInterface, this.skinTextBox_address.Text);
                object[] args = new object[this.targetMethod.GetParameters().Length];
                foreach (IParameterPanel panel in this.flowLayoutPanel1.Controls)
                {
                    args[panel.ArgIndex] = panel.ArgValue;
                }
                object ret = this.targetMethod.Invoke(remotingObject, args);
                string res = ret.ToString();
                if (!ESBasic.Helpers.TypeHelper.IsSimpleType(ret.GetType()))
                {
                    res = ESBasic.Serialization.SimpleXmlConverter.XmlSerializeObject(ret);
                }
                this.rtfRichTextBox1.Text = res;
            }
            catch (Exception ee)
            {
                while (ee.InnerException != null)
                {
                    ee = ee.InnerException;
                }
                MessageBox.Show(ee.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control ctr in this.flowLayoutPanel1.Controls)
            {
                ctr.Width = this.flowLayoutPanel1.Width - 25;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //this.skinComboBox_method_SelectedIndexChanged(this.skinComboBox_method, null);
        }
    }
}
