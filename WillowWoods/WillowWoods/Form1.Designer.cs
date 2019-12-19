namespace WillowWoods
{
    partial class Form1
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

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Welcomelbl = new System.Windows.Forms.Label();
            this.continuebtn = new System.Windows.Forms.Button();
            this.storybodylbl = new System.Windows.Forms.Label();
            this.storypart1lbl = new System.Windows.Forms.Label();
            this.nextbtn = new System.Windows.Forms.Button();
            this.next2btn = new System.Windows.Forms.Button();
            this.namelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.AutoSize = true;
            this.Welcomelbl.BackColor = System.Drawing.Color.Transparent;
            this.Welcomelbl.Font = new System.Drawing.Font("Engravers MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelbl.ForeColor = System.Drawing.Color.White;
            this.Welcomelbl.Location = new System.Drawing.Point(166, 152);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(0, 34);
            this.Welcomelbl.TabIndex = 0;
            // 
            // continuebtn
            // 
            this.continuebtn.Font = new System.Drawing.Font("Engravers MT", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuebtn.Location = new System.Drawing.Point(191, 370);
            this.continuebtn.Name = "continuebtn";
            this.continuebtn.Size = new System.Drawing.Size(228, 23);
            this.continuebtn.TabIndex = 9;
            this.continuebtn.Text = "Click me to continue";
            this.continuebtn.UseVisualStyleBackColor = true;
            this.continuebtn.Visible = false;
            this.continuebtn.Click += new System.EventHandler(this.continuebtn_Click);
            // 
            // storybodylbl
            // 
            this.storybodylbl.BackColor = System.Drawing.Color.Transparent;
            this.storybodylbl.Font = new System.Drawing.Font("Engravers MT", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storybodylbl.ForeColor = System.Drawing.Color.White;
            this.storybodylbl.Location = new System.Drawing.Point(126, 49);
            this.storybodylbl.Name = "storybodylbl";
            this.storybodylbl.Size = new System.Drawing.Size(367, 265);
            this.storybodylbl.TabIndex = 7;
            this.storybodylbl.Text = resources.GetString("storybodylbl.Text");
            this.storybodylbl.Visible = false;
            // 
            // storypart1lbl
            // 
            this.storypart1lbl.AutoSize = true;
            this.storypart1lbl.BackColor = System.Drawing.Color.Transparent;
            this.storypart1lbl.Font = new System.Drawing.Font("Engravers MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storypart1lbl.ForeColor = System.Drawing.Color.White;
            this.storypart1lbl.Location = new System.Drawing.Point(79, 170);
            this.storypart1lbl.Name = "storypart1lbl";
            this.storypart1lbl.Size = new System.Drawing.Size(432, 34);
            this.storypart1lbl.TabIndex = 6;
            this.storypart1lbl.Text = "Once Upon A Time...";
            // 
            // nextbtn
            // 
            this.nextbtn.Font = new System.Drawing.Font("Engravers MT", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbtn.Location = new System.Drawing.Point(256, 331);
            this.nextbtn.Name = "nextbtn";
            this.nextbtn.Size = new System.Drawing.Size(95, 21);
            this.nextbtn.TabIndex = 5;
            this.nextbtn.Text = "Next";
            this.nextbtn.UseVisualStyleBackColor = true;
            this.nextbtn.Click += new System.EventHandler(this.nextbtn_Click);
            // 
            // next2btn
            // 
            this.next2btn.Font = new System.Drawing.Font("Engravers MT", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next2btn.Location = new System.Drawing.Point(256, 328);
            this.next2btn.Name = "next2btn";
            this.next2btn.Size = new System.Drawing.Size(95, 24);
            this.next2btn.TabIndex = 10;
            this.next2btn.Text = "Next";
            this.next2btn.UseVisualStyleBackColor = true;
            this.next2btn.Visible = false;
            this.next2btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.BackColor = System.Drawing.Color.Transparent;
            this.namelbl.Font = new System.Drawing.Font("Engravers MT", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelbl.ForeColor = System.Drawing.Color.White;
            this.namelbl.Location = new System.Drawing.Point(106, 164);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(405, 41);
            this.namelbl.TabIndex = 11;
            this.namelbl.Text = "Willow Woods";
            this.namelbl.Visible = false;
            // 

            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackgroundImage = global::WillowWoods.Properties.Resources.d629niv_9aeef292_3db0_40b7_a49f_21ef4370006a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 460);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.next2btn);
            this.Controls.Add(this.continuebtn);
            this.Controls.Add(this.storybodylbl);
            this.Controls.Add(this.storypart1lbl);
            this.Controls.Add(this.nextbtn);
            this.Controls.Add(this.Welcomelbl);
            this.Name = "Form1";
            this.Text = "Story page";
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.Label Welcomelbl;
        private System.Windows.Forms.Button continuebtn;
        private System.Windows.Forms.Label storybodylbl;
        private System.Windows.Forms.Label storypart1lbl;
        private System.Windows.Forms.Button nextbtn;
        private System.Windows.Forms.Button next2btn;
        private System.Windows.Forms.Label namelbl;
    }
}

