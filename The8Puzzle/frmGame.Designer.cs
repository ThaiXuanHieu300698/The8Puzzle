namespace The8Puzzle
{
    partial class frmGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.lblNameGame = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ElipseForm = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ElipseButtonClose = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ElipseButtonRefresh = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameGame
            // 
            this.lblNameGame.AutoSize = true;
            this.lblNameGame.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameGame.ForeColor = System.Drawing.Color.White;
            this.lblNameGame.Location = new System.Drawing.Point(61, 12);
            this.lblNameGame.Name = "lblNameGame";
            this.lblNameGame.Size = new System.Drawing.Size(221, 44);
            this.lblNameGame.TabIndex = 9;
            this.lblNameGame.Text = "The 8 Puzzle";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(300, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // ElipseForm
            // 
            this.ElipseForm.ElipseRadius = 25;
            this.ElipseForm.TargetControl = this;
            // 
            // ElipseButtonClose
            // 
            this.ElipseButtonClose.ElipseRadius = 10;
            this.ElipseButtonClose.TargetControl = this.btnClose;
            // 
            // btnNine
            // 
            this.btnNine.BackgroundImage = global::The8Puzzle.Properties.Resources.circle;
            this.btnNine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNine.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnNine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNine.ForeColor = System.Drawing.Color.White;
            this.btnNine.Location = new System.Drawing.Point(219, 270);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(84, 77);
            this.btnNine.TabIndex = 8;
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEight.BackgroundImage")));
            this.btnEight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEight.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnEight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEight.ForeColor = System.Drawing.Color.White;
            this.btnEight.Location = new System.Drawing.Point(129, 270);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(84, 77);
            this.btnEight.TabIndex = 7;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeven.BackgroundImage")));
            this.btnSeven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeven.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeven.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSeven.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.ForeColor = System.Drawing.Color.White;
            this.btnSeven.Location = new System.Drawing.Point(39, 270);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(84, 77);
            this.btnSeven.TabIndex = 6;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSix.BackgroundImage")));
            this.btnSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSix.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSix.ForeColor = System.Drawing.Color.White;
            this.btnSix.Location = new System.Drawing.Point(219, 187);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(84, 77);
            this.btnSix.TabIndex = 5;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFive.BackgroundImage")));
            this.btnFive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFive.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFive.ForeColor = System.Drawing.Color.White;
            this.btnFive.Location = new System.Drawing.Point(129, 187);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(84, 77);
            this.btnFive.TabIndex = 4;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFour.BackgroundImage")));
            this.btnFour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFour.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFour.ForeColor = System.Drawing.Color.White;
            this.btnFour.Location = new System.Drawing.Point(39, 187);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(84, 77);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThree.BackgroundImage")));
            this.btnThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThree.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThree.ForeColor = System.Drawing.Color.White;
            this.btnThree.Location = new System.Drawing.Point(219, 104);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(84, 77);
            this.btnThree.TabIndex = 2;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTwo.BackgroundImage")));
            this.btnTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTwo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTwo.ForeColor = System.Drawing.Color.White;
            this.btnTwo.Location = new System.Drawing.Point(129, 104);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(84, 77);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOne.BackgroundImage")));
            this.btnOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOne.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOne.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOne.ForeColor = System.Drawing.Color.White;
            this.btnOne.Location = new System.Drawing.Point(39, 104);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(84, 77);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(94, 353);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(155, 46);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ElipseButtonRefresh
            // 
            this.ElipseButtonRefresh.ElipseRadius = 10;
            this.ElipseButtonRefresh.TargetControl = this.btnRefresh;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(123, 65);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(125, 33);
            this.lblMessage.TabIndex = 12;
            this.lblMessage.Text = "-- Win --";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.White;
            this.lblCount.Location = new System.Drawing.Point(279, 65);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(30, 33);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "0";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(347, 411);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNameGame);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The 8 Puzzle";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblNameGame;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnTwo;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private Bunifu.Framework.UI.BunifuElipse ElipseForm;
        private Bunifu.Framework.UI.BunifuElipse ElipseButtonClose;
        private System.Windows.Forms.Button btnRefresh;
        private Bunifu.Framework.UI.BunifuElipse ElipseButtonRefresh;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblCount;
    }
}

