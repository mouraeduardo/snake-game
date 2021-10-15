
namespace snake
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnTela = new System.Windows.Forms.Panel();
            this.LbPontuacao = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Start = new System.Windows.Forms.ToolStripMenuItem();
            this.Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.Frame = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnTela
            // 
            this.PnTela.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PnTela.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnTela.Location = new System.Drawing.Point(7, 68);
            this.PnTela.Name = "PnTela";
            this.PnTela.Size = new System.Drawing.Size(428, 428);
            this.PnTela.TabIndex = 0;
            // 
            // LbPontuacao
            // 
            this.LbPontuacao.BackColor = System.Drawing.SystemColors.Control;
            this.LbPontuacao.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbPontuacao.Location = new System.Drawing.Point(7, 32);
            this.LbPontuacao.Name = "LbPontuacao";
            this.LbPontuacao.Size = new System.Drawing.Size(428, 23);
            this.LbPontuacao.TabIndex = 1;
            this.LbPontuacao.Text = "Pontos: 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(441, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Start,
            this.Stop});
            this.Menu.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(50, 20);
            this.Menu.Text = "Menu";
            // 
            // Start
            // 
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(146, 22);
            this.Start.Text = "Iniciar Jogo";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(146, 22);
            this.Stop.Text = "Sair";
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Frame
            // 
            this.Frame.Interval = 80;
            this.Frame.Tick += new System.EventHandler(this.Frame_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 498);
            this.Controls.Add(this.LbPontuacao);
            this.Controls.Add(this.PnTela);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Big Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnTela;
        private System.Windows.Forms.Label LbPontuacao;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem Start;
        private System.Windows.Forms.ToolStripMenuItem Stop;
        private System.Windows.Forms.Timer Frame;
    }
}

