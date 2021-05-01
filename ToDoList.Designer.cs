namespace ToDoList
{
    partial class ToDoList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.savebtn = new System.Windows.Forms.Button();
            this.txtToDoList = new System.Windows.Forms.TextBox();
            this.viewbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.Plum;
            this.savebtn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.Location = new System.Drawing.Point(112, 417);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(87, 32);
            this.savebtn.TabIndex = 0;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // txtToDoList
            // 
            this.txtToDoList.BackColor = System.Drawing.Color.White;
            this.txtToDoList.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToDoList.Location = new System.Drawing.Point(49, 103);
            this.txtToDoList.Multiline = true;
            this.txtToDoList.Name = "txtToDoList";
            this.txtToDoList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtToDoList.Size = new System.Drawing.Size(425, 308);
            this.txtToDoList.TabIndex = 1;
            this.txtToDoList.Text = "What To Do:\r\n\r\n\r\nDescription:\r\n\r\n\r\nPriority Level:\r\n\r\n\r\nDate:";
            // 
            // viewbtn
            // 
            this.viewbtn.BackColor = System.Drawing.Color.Plum;
            this.viewbtn.Font = new System.Drawing.Font("Perpetua Titling MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbtn.Location = new System.Drawing.Point(321, 417);
            this.viewbtn.Name = "viewbtn";
            this.viewbtn.Size = new System.Drawing.Size(88, 32);
            this.viewbtn.TabIndex = 4;
            this.viewbtn.Text = "View";
            this.viewbtn.UseVisualStyleBackColor = false;
            this.viewbtn.Click += new System.EventHandler(this.viewbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.DarkRed;
            this.exitbtn.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.ForeColor = System.Drawing.Color.White;
            this.exitbtn.Location = new System.Drawing.Point(13, 13);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(47, 23);
            this.exitbtn.TabIndex = 5;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ToDoList.Properties.Resources._300_3002032_blank_christmas_invitation_template;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 521);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.viewbtn);
            this.Controls.Add(this.txtToDoList);
            this.Controls.Add(this.savebtn);
            this.Name = "ToDoList";
            this.Text = "ToDoList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox txtToDoList;
        private System.Windows.Forms.Button viewbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}

