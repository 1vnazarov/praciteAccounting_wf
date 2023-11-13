namespace praciteAccounting {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.department_button = new System.Windows.Forms.Button();
            this.group_button = new System.Windows.Forms.Button();
            this.curators_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // department_button
            // 
            this.department_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.department_button.Location = new System.Drawing.Point(59, 17);
            this.department_button.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.department_button.Name = "department_button";
            this.department_button.Size = new System.Drawing.Size(168, 54);
            this.department_button.TabIndex = 2;
            this.department_button.Text = "Отделение";
            this.department_button.UseVisualStyleBackColor = true;
            this.department_button.Click += new System.EventHandler(this.department_button_Click);
            // 
            // group_button
            // 
            this.group_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_button.Location = new System.Drawing.Point(254, 17);
            this.group_button.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.group_button.Name = "group_button";
            this.group_button.Size = new System.Drawing.Size(168, 54);
            this.group_button.TabIndex = 3;
            this.group_button.Text = "Группы";
            this.group_button.UseVisualStyleBackColor = true;
            // 
            // curators_button
            // 
            this.curators_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.curators_button.Location = new System.Drawing.Point(448, 17);
            this.curators_button.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.curators_button.Name = "curators_button";
            this.curators_button.Size = new System.Drawing.Size(168, 54);
            this.curators_button.TabIndex = 4;
            this.curators_button.Text = "Кураторы";
            this.curators_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 447);
            this.Controls.Add(this.curators_button);
            this.Controls.Add(this.group_button);
            this.Controls.Add(this.department_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button department_button;
        private System.Windows.Forms.Button group_button;
        private System.Windows.Forms.Button curators_button;
    }
}

