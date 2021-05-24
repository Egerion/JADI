
namespace JADI
{
    partial class Form_JADI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Settings = new System.Windows.Forms.Panel();
            this.Button_ProcRefresh = new System.Windows.Forms.Button();
            this.Label_Inject = new System.Windows.Forms.Label();
            this.Button_DllEject = new System.Windows.Forms.Button();
            this.Label_CreateProcWithDll = new System.Windows.Forms.Label();
            this.Button_CreateProcWithDll = new System.Windows.Forms.Button();
            this.Label_ProcFilter = new System.Windows.Forms.Label();
            this.TextBox_FindProcString = new System.Windows.Forms.TextBox();
            this.Button_Inject = new System.Windows.Forms.Button();
            this.ComboBox_Process = new System.Windows.Forms.ComboBox();
            this.Label_Title = new System.Windows.Forms.Label();
            this.ListBox_Dll = new System.Windows.Forms.ListBox();
            this.Button_AddDLL = new System.Windows.Forms.Button();
            this.Button_RemoveDll = new System.Windows.Forms.Button();
            this.Label_DllList = new System.Windows.Forms.Label();
            this.Panel_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Settings
            // 
            this.Panel_Settings.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Panel_Settings.Controls.Add(this.Button_ProcRefresh);
            this.Panel_Settings.Controls.Add(this.Label_Inject);
            this.Panel_Settings.Controls.Add(this.Button_DllEject);
            this.Panel_Settings.Controls.Add(this.Label_CreateProcWithDll);
            this.Panel_Settings.Controls.Add(this.Button_CreateProcWithDll);
            this.Panel_Settings.Controls.Add(this.Label_ProcFilter);
            this.Panel_Settings.Controls.Add(this.TextBox_FindProcString);
            this.Panel_Settings.Controls.Add(this.Button_Inject);
            this.Panel_Settings.Controls.Add(this.ComboBox_Process);
            this.Panel_Settings.Location = new System.Drawing.Point(-4, 50);
            this.Panel_Settings.Name = "Panel_Settings";
            this.Panel_Settings.Size = new System.Drawing.Size(447, 641);
            this.Panel_Settings.TabIndex = 0;
            // 
            // Button_ProcRefresh
            // 
            this.Button_ProcRefresh.Location = new System.Drawing.Point(293, 81);
            this.Button_ProcRefresh.Name = "Button_ProcRefresh";
            this.Button_ProcRefresh.Size = new System.Drawing.Size(96, 34);
            this.Button_ProcRefresh.TabIndex = 8;
            this.Button_ProcRefresh.Text = "Refresh";
            this.Button_ProcRefresh.UseVisualStyleBackColor = true;
            this.Button_ProcRefresh.Click += new System.EventHandler(this.Button_ProcRefresh_Click);
            // 
            // Label_Inject
            // 
            this.Label_Inject.AutoSize = true;
            this.Label_Inject.Location = new System.Drawing.Point(261, 148);
            this.Label_Inject.Name = "Label_Inject";
            this.Label_Inject.Size = new System.Drawing.Size(155, 25);
            this.Label_Inject.TabIndex = 7;
            this.Label_Inject.Text = "Standard Injection";
            // 
            // Button_DllEject
            // 
            this.Button_DllEject.Location = new System.Drawing.Point(277, 216);
            this.Button_DllEject.Name = "Button_DllEject";
            this.Button_DllEject.Size = new System.Drawing.Size(112, 34);
            this.Button_DllEject.TabIndex = 6;
            this.Button_DllEject.Text = "Eject Dll";
            this.Button_DllEject.UseVisualStyleBackColor = true;
            this.Button_DllEject.Click += new System.EventHandler(this.Button_DllEject_Click);
            // 
            // Label_CreateProcWithDll
            // 
            this.Label_CreateProcWithDll.AutoSize = true;
            this.Label_CreateProcWithDll.Location = new System.Drawing.Point(16, 148);
            this.Label_CreateProcWithDll.Name = "Label_CreateProcWithDll";
            this.Label_CreateProcWithDll.Size = new System.Drawing.Size(195, 25);
            this.Label_CreateProcWithDll.TabIndex = 5;
            this.Label_CreateProcWithDll.Text = "Create Process With Dll";
            // 
            // Button_CreateProcWithDll
            // 
            this.Button_CreateProcWithDll.Location = new System.Drawing.Point(39, 176);
            this.Button_CreateProcWithDll.Name = "Button_CreateProcWithDll";
            this.Button_CreateProcWithDll.Size = new System.Drawing.Size(155, 34);
            this.Button_CreateProcWithDll.TabIndex = 4;
            this.Button_CreateProcWithDll.Text = "Create and Run";
            this.Button_CreateProcWithDll.UseVisualStyleBackColor = true;
            this.Button_CreateProcWithDll.Click += new System.EventHandler(this.Button_CreateProcWithDll_Click);
            // 
            // Label_ProcFilter
            // 
            this.Label_ProcFilter.AutoSize = true;
            this.Label_ProcFilter.Location = new System.Drawing.Point(93, 17);
            this.Label_ProcFilter.Name = "Label_ProcFilter";
            this.Label_ProcFilter.Size = new System.Drawing.Size(146, 25);
            this.Label_ProcFilter.TabIndex = 3;
            this.Label_ProcFilter.Text = "Filter Process List";
            // 
            // TextBox_FindProcString
            // 
            this.TextBox_FindProcString.Location = new System.Drawing.Point(39, 45);
            this.TextBox_FindProcString.Name = "TextBox_FindProcString";
            this.TextBox_FindProcString.Size = new System.Drawing.Size(248, 31);
            this.TextBox_FindProcString.TabIndex = 2;
            this.TextBox_FindProcString.TextChanged += new System.EventHandler(this.TextBox_FindProcString_TextChanged);
            // 
            // Button_Inject
            // 
            this.Button_Inject.Location = new System.Drawing.Point(277, 176);
            this.Button_Inject.Name = "Button_Inject";
            this.Button_Inject.Size = new System.Drawing.Size(112, 34);
            this.Button_Inject.TabIndex = 1;
            this.Button_Inject.Text = "Inject Dll";
            this.Button_Inject.UseVisualStyleBackColor = true;
            this.Button_Inject.Click += new System.EventHandler(this.Button_Inject_Click);
            // 
            // ComboBox_Process
            // 
            this.ComboBox_Process.DropDownHeight = 450;
            this.ComboBox_Process.DropDownWidth = 350;
            this.ComboBox_Process.FormattingEnabled = true;
            this.ComboBox_Process.IntegralHeight = false;
            this.ComboBox_Process.Location = new System.Drawing.Point(39, 82);
            this.ComboBox_Process.Name = "ComboBox_Process";
            this.ComboBox_Process.Size = new System.Drawing.Size(248, 33);
            this.ComboBox_Process.TabIndex = 0;
            this.ComboBox_Process.Text = "Select Process";
            this.ComboBox_Process.SelectedIndexChanged += new System.EventHandler(this.ComboBox_Process_SelectedIndexChanged);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label_Title.Location = new System.Drawing.Point(51, 9);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(302, 38);
            this.Label_Title.TabIndex = 1;
            this.Label_Title.Text = "JADI - DLL Injector v1.0";
            // 
            // ListBox_Dll
            // 
            this.ListBox_Dll.FormattingEnabled = true;
            this.ListBox_Dll.ItemHeight = 25;
            this.ListBox_Dll.Location = new System.Drawing.Point(480, 75);
            this.ListBox_Dll.Name = "ListBox_Dll";
            this.ListBox_Dll.Size = new System.Drawing.Size(583, 229);
            this.ListBox_Dll.TabIndex = 2;
            this.ListBox_Dll.SelectedIndexChanged += new System.EventHandler(this.ListBox_Dll_SelectedIndexChanged);
            // 
            // Button_AddDLL
            // 
            this.Button_AddDLL.Location = new System.Drawing.Point(480, 335);
            this.Button_AddDLL.Name = "Button_AddDLL";
            this.Button_AddDLL.Size = new System.Drawing.Size(112, 34);
            this.Button_AddDLL.TabIndex = 3;
            this.Button_AddDLL.Text = "Add";
            this.Button_AddDLL.UseVisualStyleBackColor = true;
            this.Button_AddDLL.Click += new System.EventHandler(this.Button_AddDLL_Click);
            // 
            // Button_RemoveDll
            // 
            this.Button_RemoveDll.Location = new System.Drawing.Point(598, 335);
            this.Button_RemoveDll.Name = "Button_RemoveDll";
            this.Button_RemoveDll.Size = new System.Drawing.Size(112, 34);
            this.Button_RemoveDll.TabIndex = 4;
            this.Button_RemoveDll.Text = "Remove";
            this.Button_RemoveDll.UseVisualStyleBackColor = true;
            this.Button_RemoveDll.Click += new System.EventHandler(this.Button_RemoveDll_Click);
            // 
            // Label_DllList
            // 
            this.Label_DllList.AutoSize = true;
            this.Label_DllList.Location = new System.Drawing.Point(480, 50);
            this.Label_DllList.Name = "Label_DllList";
            this.Label_DllList.Size = new System.Drawing.Size(64, 25);
            this.Label_DllList.TabIndex = 5;
            this.Label_DllList.Text = "Dll List";
            // 
            // Form_JADI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1099, 686);
            this.Controls.Add(this.Label_DllList);
            this.Controls.Add(this.Button_RemoveDll);
            this.Controls.Add(this.Button_AddDLL);
            this.Controls.Add(this.ListBox_Dll);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.Panel_Settings);
            this.Name = "Form_JADI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JADI - DLL Injector x86 v1.0";
            this.Panel_Settings.ResumeLayout(false);
            this.Panel_Settings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Settings;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.ComboBox ComboBox_Process;
        private System.Windows.Forms.Button Button_Inject;
        private System.Windows.Forms.TextBox TextBox_FindProcString;
        private System.Windows.Forms.Label Label_ProcFilter;
        private System.Windows.Forms.ListBox ListBox_Dll;
        private System.Windows.Forms.Button Button_AddDLL;
        private System.Windows.Forms.Button Button_RemoveDll;
        private System.Windows.Forms.Button Button_CreateProcWithDll;
        private System.Windows.Forms.Label Label_CreateProcWithDll;
        private System.Windows.Forms.Label Label_Inject;
        private System.Windows.Forms.Button Button_DllEject;
        private System.Windows.Forms.Button Button_ProcRefresh;
        private System.Windows.Forms.Label Label_DllList;
    }
}

