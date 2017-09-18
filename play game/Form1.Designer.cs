namespace play_game
{
    partial class PlayGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGame));
            this.playgamebutton = new System.Windows.Forms.Button();
            this.startingGame3lable = new System.Windows.Forms.TextBox();
            this.startingGame2lable = new System.Windows.Forms.TextBox();
            this.startingGame1lable = new System.Windows.Forms.TextBox();
            this.go = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playgamebutton
            // 
            this.playgamebutton.BackColor = System.Drawing.Color.White;
            this.playgamebutton.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.playgamebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.playgamebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.playgamebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playgamebutton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playgamebutton.ForeColor = System.Drawing.Color.Green;
            this.playgamebutton.Location = new System.Drawing.Point(68, 12);
            this.playgamebutton.Name = "playgamebutton";
            this.playgamebutton.Size = new System.Drawing.Size(232, 45);
            this.playgamebutton.TabIndex = 0;
            this.playgamebutton.Text = "Play Game";
            this.playgamebutton.UseVisualStyleBackColor = true;
            this.playgamebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // startingGame3lable
            // 
            this.startingGame3lable.BackColor = System.Drawing.Color.Black;
            this.startingGame3lable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startingGame3lable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingGame3lable.ForeColor = System.Drawing.Color.White;
            this.startingGame3lable.Location = new System.Drawing.Point(118, 139);
            this.startingGame3lable.Name = "startingGame3lable";
            this.startingGame3lable.Size = new System.Drawing.Size(143, 20);
            this.startingGame3lable.TabIndex = 1;
            this.startingGame3lable.Text = "Starting Game....3 ";
            this.startingGame3lable.Visible = false;
            // 
            // startingGame2lable
            // 
            this.startingGame2lable.BackColor = System.Drawing.Color.Black;
            this.startingGame2lable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startingGame2lable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.startingGame2lable.ForeColor = System.Drawing.Color.White;
            this.startingGame2lable.Location = new System.Drawing.Point(118, 165);
            this.startingGame2lable.Name = "startingGame2lable";
            this.startingGame2lable.Size = new System.Drawing.Size(143, 20);
            this.startingGame2lable.TabIndex = 2;
            this.startingGame2lable.Text = "Starting game....2";
            this.startingGame2lable.Visible = false;
            // 
            // startingGame1lable
            // 
            this.startingGame1lable.BackColor = System.Drawing.Color.Black;
            this.startingGame1lable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.startingGame1lable.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.startingGame1lable.ForeColor = System.Drawing.Color.White;
            this.startingGame1lable.Location = new System.Drawing.Point(118, 191);
            this.startingGame1lable.Name = "startingGame1lable";
            this.startingGame1lable.Size = new System.Drawing.Size(143, 20);
            this.startingGame1lable.TabIndex = 3;
            this.startingGame1lable.Text = "Starting game....1";
            this.startingGame1lable.Visible = false;
            // 
            // go
            // 
            this.go.BackColor = System.Drawing.Color.Green;
            this.go.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.go.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.go.ForeColor = System.Drawing.Color.White;
            this.go.Location = new System.Drawing.Point(148, 217);
            this.go.Name = "go";
            this.go.Size = new System.Drawing.Size(72, 20);
            this.go.TabIndex = 4;
            this.go.Text = "GO!!!!!!!!!";
            this.go.Visible = false;
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(378, 324);
            this.Controls.Add(this.go);
            this.Controls.Add(this.startingGame1lable);
            this.Controls.Add(this.startingGame2lable);
            this.Controls.Add(this.startingGame3lable);
            this.Controls.Add(this.playgamebutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlayGame";
            this.Load += new System.EventHandler(this.PlayGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playgamebutton;
        private System.Windows.Forms.TextBox startingGame3lable;
        private System.Windows.Forms.TextBox startingGame2lable;
        private System.Windows.Forms.TextBox startingGame1lable;
        private System.Windows.Forms.TextBox go;
    }
}

