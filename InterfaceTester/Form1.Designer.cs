namespace InterfaceTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox_address = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinButtom1 = new CCWin.SkinControl.SkinButtom();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_interType = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinComboBox_method = new CCWin.SkinControl.SkinComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel_paraCount = new CCWin.SkinControl.SkinLabel();
            this.skinButtom2 = new CCWin.SkinControl.SkinButtom();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.rtfRichTextBox1 = new CCWin.SkinControl.RtfRichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(11, 48);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(100, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "Remoting地址：";
            // 
            // skinTextBox_address
            // 
            this.skinTextBox_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTextBox_address.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox_address.Icon = null;
            this.skinTextBox_address.IconIsButton = false;
            this.skinTextBox_address.IsPasswordChat = '\0';
            this.skinTextBox_address.IsSystemPasswordChar = false;
            this.skinTextBox_address.Lines = new string[] {
        "tcp://127.0.0.1:9000/TestService"};
            this.skinTextBox_address.Location = new System.Drawing.Point(114, 42);
            this.skinTextBox_address.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox_address.MaxLength = 32767;
            this.skinTextBox_address.MinimumSize = new System.Drawing.Size(0, 28);
            this.skinTextBox_address.MouseBack = null;
            this.skinTextBox_address.Multiline = false;
            this.skinTextBox_address.Name = "skinTextBox_address";
            this.skinTextBox_address.NormlBack = null;
            this.skinTextBox_address.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox_address.ReadOnly = false;
            this.skinTextBox_address.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox_address.Size = new System.Drawing.Size(605, 28);
            this.skinTextBox_address.TabIndex = 1;
            this.skinTextBox_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox_address.WaterColor = System.Drawing.Color.DarkGray;
            this.skinTextBox_address.WaterText = "";
            this.skinTextBox_address.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(7, 84);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(104, 17);
            this.skinLabel2.TabIndex = 0;
            this.skinLabel2.Text = "接口所在程序集：";
            // 
            // skinButtom1
            // 
            this.skinButtom1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButtom1.BackColor = System.Drawing.Color.Transparent;
            this.skinButtom1.BaseColor = System.Drawing.Color.Peru;
            this.skinButtom1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtom1.DownBack = null;
            this.skinButtom1.Location = new System.Drawing.Point(674, 80);
            this.skinButtom1.MouseBack = null;
            this.skinButtom1.Name = "skinButtom1";
            this.skinButtom1.NormlBack = null;
            this.skinButtom1.Size = new System.Drawing.Size(45, 23);
            this.skinButtom1.TabIndex = 3;
            this.skinButtom1.Text = "选取";
            this.skinButtom1.UseVisualStyleBackColor = false;
            this.skinButtom1.Click += new System.EventHandler(this.skinButtom1_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(43, 118);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(68, 17);
            this.skinLabel3.TabIndex = 0;
            this.skinLabel3.Text = "接口类型：";
            // 
            // skinComboBox_interType
            // 
            this.skinComboBox_interType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.skinComboBox_interType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_interType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_interType.FormattingEnabled = true;
            this.skinComboBox_interType.Location = new System.Drawing.Point(114, 116);
            this.skinComboBox_interType.Name = "skinComboBox_interType";
            this.skinComboBox_interType.Size = new System.Drawing.Size(605, 22);
            this.skinComboBox_interType.TabIndex = 4;
            this.skinComboBox_interType.WaterText = "";
            this.skinComboBox_interType.SelectedIndexChanged += new System.EventHandler(this.skinComboBox_interType_SelectedIndexChanged);
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(43, 149);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(68, 17);
            this.skinLabel4.TabIndex = 0;
            this.skinLabel4.Text = "目标方法：";
            // 
            // skinComboBox_method
            // 
            this.skinComboBox_method.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.skinComboBox_method.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.skinComboBox_method.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.skinComboBox_method.FormattingEnabled = true;
            this.skinComboBox_method.Location = new System.Drawing.Point(114, 147);
            this.skinComboBox_method.Name = "skinComboBox_method";
            this.skinComboBox_method.Size = new System.Drawing.Size(605, 22);
            this.skinComboBox_method.TabIndex = 4;
            this.skinComboBox_method.WaterText = "";
            this.skinComboBox_method.SelectedIndexChanged += new System.EventHandler(this.skinComboBox_method_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LightBlue;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(56, 205);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(663, 188);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.SizeChanged += new System.EventHandler(this.flowLayoutPanel1_SizeChanged);
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(43, 181);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(68, 17);
            this.skinLabel5.TabIndex = 0;
            this.skinLabel5.Text = "方法参数：";
            // 
            // skinLabel_paraCount
            // 
            this.skinLabel_paraCount.AutoSize = true;
            this.skinLabel_paraCount.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel_paraCount.BorderColor = System.Drawing.Color.White;
            this.skinLabel_paraCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel_paraCount.Location = new System.Drawing.Point(111, 181);
            this.skinLabel_paraCount.Name = "skinLabel_paraCount";
            this.skinLabel_paraCount.Size = new System.Drawing.Size(40, 17);
            this.skinLabel_paraCount.TabIndex = 0;
            this.skinLabel_paraCount.Text = "None";
            // 
            // skinButtom2
            // 
            this.skinButtom2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skinButtom2.BackColor = System.Drawing.Color.Transparent;
            this.skinButtom2.BaseColor = System.Drawing.Color.Peru;
            this.skinButtom2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtom2.DownBack = null;
            this.skinButtom2.Location = new System.Drawing.Point(674, 178);
            this.skinButtom2.MouseBack = null;
            this.skinButtom2.Name = "skinButtom2";
            this.skinButtom2.NormlBack = null;
            this.skinButtom2.Size = new System.Drawing.Size(45, 23);
            this.skinButtom2.TabIndex = 6;
            this.skinButtom2.Text = "调用";
            this.skinButtom2.UseVisualStyleBackColor = false;
            this.skinButtom2.Click += new System.EventHandler(this.skinButtom2_Click);
            // 
            // skinLabel6
            // 
            this.skinLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.ForeColor = System.Drawing.Color.Red;
            this.skinLabel6.Location = new System.Drawing.Point(43, 398);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(68, 17);
            this.skinLabel6.TabIndex = 0;
            this.skinLabel6.Text = "调用返回：";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.Location = new System.Drawing.Point(23, 5);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(80, 17);
            this.skinLabel7.TabIndex = 7;
            this.skinLabel7.Text = "接口测试工具";
            // 
            // rtfRichTextBox1
            // 
            this.rtfRichTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfRichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtfRichTextBox1.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBox1.Location = new System.Drawing.Point(114, 402);
            this.rtfRichTextBox1.Name = "rtfRichTextBox1";
            this.rtfRichTextBox1.ReadOnly = true;
            this.rtfRichTextBox1.Size = new System.Drawing.Size(605, 60);
            this.rtfRichTextBox1.TabIndex = 8;
            this.rtfRichTextBox1.Text = "-";
            this.rtfRichTextBox1.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(114, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(554, 21);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(736, 476);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtfRichTextBox1);
            this.Controls.Add(this.skinLabel7);
            this.Controls.Add(this.skinButtom2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.skinComboBox_method);
            this.Controls.Add(this.skinComboBox_interType);
            this.Controls.Add(this.skinButtom1);
            this.Controls.Add(this.skinTextBox_address);
            this.Controls.Add(this.skinLabel_paraCount);
            this.Controls.Add(this.skinLabel6);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox skinTextBox_address;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButtom skinButtom1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinComboBox skinComboBox_interType;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinComboBox skinComboBox_method;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel_paraCount;
        private CCWin.SkinControl.SkinButtom skinButtom2;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.RtfRichTextBox rtfRichTextBox1;
        private System.Windows.Forms.TextBox textBox1;

    }
}

