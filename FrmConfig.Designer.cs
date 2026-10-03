namespace CyberCoffe_User_Control
{
    partial class FrmConfig
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
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSetTimeSetPrice = new Guna.UI2.WinForms.Guna2Panel();
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSeconds = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbMinutes = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbHour = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PnlMethods = new Guna.UI2.WinForms.Guna2Panel();
            this.lblMethodText = new System.Windows.Forms.Label();
            this.btnByPrice = new Guna.UI2.WinForms.Guna2Button();
            this.btnByTime = new Guna.UI2.WinForms.Guna2Button();
            this.btnForFree = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.tbPricePerHour = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.pnlSetTimeSetPrice.SuspendLayout();
            this.PnlMethods.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.guna2PictureBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(754, 62);
            this.pnlHeader.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(292, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "--- Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 20.25F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(90, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Internet Café";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::CyberCoffe_User_Control.Properties.Resources.monitor;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(12, 6);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(72, 43);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnSave);
            this.guna2Panel1.Controls.Add(this.pnlSetTimeSetPrice);
            this.guna2Panel1.Controls.Add(this.PnlMethods);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.guna2Panel1.Location = new System.Drawing.Point(2, 56);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(752, 383);
            this.guna2Panel1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.btnSave.BorderRadius = 7;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::CyberCoffe_User_Control.Properties.Resources.submit;
            this.btnSave.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSave.Location = new System.Drawing.Point(504, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(217, 43);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlSetTimeSetPrice
            // 
            this.pnlSetTimeSetPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.pnlSetTimeSetPrice.BorderRadius = 12;
            this.pnlSetTimeSetPrice.Controls.Add(this.tbPrice);
            this.pnlSetTimeSetPrice.Controls.Add(this.label9);
            this.pnlSetTimeSetPrice.Controls.Add(this.tbSeconds);
            this.pnlSetTimeSetPrice.Controls.Add(this.tbMinutes);
            this.pnlSetTimeSetPrice.Controls.Add(this.tbHour);
            this.pnlSetTimeSetPrice.Controls.Add(this.label6);
            this.pnlSetTimeSetPrice.Controls.Add(this.label8);
            this.pnlSetTimeSetPrice.Controls.Add(this.label5);
            this.pnlSetTimeSetPrice.Controls.Add(this.label7);
            this.pnlSetTimeSetPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.pnlSetTimeSetPrice.Location = new System.Drawing.Point(407, 22);
            this.pnlSetTimeSetPrice.Name = "pnlSetTimeSetPrice";
            this.pnlSetTimeSetPrice.Size = new System.Drawing.Size(314, 253);
            this.pnlSetTimeSetPrice.TabIndex = 2;
            // 
            // tbPrice
            // 
            this.tbPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.tbPrice.BorderRadius = 10;
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.DefaultText = "";
            this.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.tbPrice.ForeColor = System.Drawing.Color.White;
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.IconRight = global::CyberCoffe_User_Control.Properties.Resources.dollar_sign;
            this.tbPrice.Location = new System.Drawing.Point(15, 171);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(5);
            this.tbPrice.MaxLength = 6;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PlaceholderText = "";
            this.tbPrice.SelectedText = "";
            this.tbPrice.Size = new System.Drawing.Size(283, 47);
            this.tbPrice.TabIndex = 20;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            this.tbPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPrice_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 12.25F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.label9.Location = new System.Drawing.Point(12, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Price";
            // 
            // tbSeconds
            // 
            this.tbSeconds.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.tbSeconds.BorderRadius = 12;
            this.tbSeconds.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSeconds.DefaultText = "";
            this.tbSeconds.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSeconds.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSeconds.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSeconds.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSeconds.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.tbSeconds.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSeconds.Font = new System.Drawing.Font("Segoe UI", 23F);
            this.tbSeconds.ForeColor = System.Drawing.Color.White;
            this.tbSeconds.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSeconds.Location = new System.Drawing.Point(226, 35);
            this.tbSeconds.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbSeconds.MaxLength = 2;
            this.tbSeconds.Name = "tbSeconds";
            this.tbSeconds.PlaceholderText = "";
            this.tbSeconds.SelectedText = "";
            this.tbSeconds.Size = new System.Drawing.Size(64, 62);
            this.tbSeconds.TabIndex = 18;
            this.tbSeconds.Tag = "59";
            this.tbSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbSeconds.TextChanged += new System.EventHandler(this.tbSeconds_TextChanged);
            this.tbSeconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSeconds_KeyPress);
            // 
            // tbMinutes
            // 
            this.tbMinutes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.tbMinutes.BorderRadius = 12;
            this.tbMinutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMinutes.DefaultText = "";
            this.tbMinutes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMinutes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMinutes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMinutes.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMinutes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.tbMinutes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMinutes.Font = new System.Drawing.Font("Segoe UI", 23F);
            this.tbMinutes.ForeColor = System.Drawing.Color.White;
            this.tbMinutes.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMinutes.Location = new System.Drawing.Point(121, 35);
            this.tbMinutes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbMinutes.MaxLength = 2;
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.PlaceholderText = "";
            this.tbMinutes.SelectedText = "";
            this.tbMinutes.Size = new System.Drawing.Size(64, 62);
            this.tbMinutes.TabIndex = 17;
            this.tbMinutes.Tag = "59";
            this.tbMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbMinutes.TextChanged += new System.EventHandler(this.tbMinutes_TextChanged);
            this.tbMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMinutes_KeyPress);
            // 
            // tbHour
            // 
            this.tbHour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.tbHour.BorderRadius = 12;
            this.tbHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHour.DefaultText = "";
            this.tbHour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbHour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbHour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.tbHour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHour.Font = new System.Drawing.Font("Segoe UI", 23F);
            this.tbHour.ForeColor = System.Drawing.Color.White;
            this.tbHour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHour.Location = new System.Drawing.Point(16, 34);
            this.tbHour.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbHour.MaxLength = 2;
            this.tbHour.Name = "tbHour";
            this.tbHour.PlaceholderText = "";
            this.tbHour.SelectedText = "";
            this.tbHour.Size = new System.Drawing.Size(64, 62);
            this.tbHour.TabIndex = 16;
            this.tbHour.Tag = "23";
            this.tbHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbHour.TextChanged += new System.EventHandler(this.tbHour_TextChanged);
            this.tbHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHour_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12.25F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.label6.Location = new System.Drawing.Point(12, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(38, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(242, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 29);
            this.label5.TabIndex = 15;
            this.label5.Text = "s";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(142, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "m";
            // 
            // PnlMethods
            // 
            this.PnlMethods.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.PnlMethods.BorderRadius = 12;
            this.PnlMethods.Controls.Add(this.lblMethodText);
            this.PnlMethods.Controls.Add(this.btnByPrice);
            this.PnlMethods.Controls.Add(this.btnByTime);
            this.PnlMethods.Controls.Add(this.btnForFree);
            this.PnlMethods.Controls.Add(this.label2);
            this.PnlMethods.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.PnlMethods.Location = new System.Drawing.Point(15, 136);
            this.PnlMethods.Name = "PnlMethods";
            this.PnlMethods.Size = new System.Drawing.Size(372, 185);
            this.PnlMethods.TabIndex = 1;
            // 
            // lblMethodText
            // 
            this.lblMethodText.BackColor = System.Drawing.Color.Transparent;
            this.lblMethodText.Font = new System.Drawing.Font("Cooper Black", 9.25F);
            this.lblMethodText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.lblMethodText.Location = new System.Drawing.Point(12, 111);
            this.lblMethodText.Name = "lblMethodText";
            this.lblMethodText.Size = new System.Drawing.Size(349, 54);
            this.lblMethodText.TabIndex = 9;
            this.lblMethodText.Text = "Timer starts immediately. When the customer finishes,stop the session and the pri" +
    "ce is calculated then.";
            // 
            // btnByPrice
            // 
            this.btnByPrice.BorderRadius = 12;
            this.btnByPrice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnByPrice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnByPrice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnByPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnByPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnByPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.btnByPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByPrice.ForeColor = System.Drawing.Color.White;
            this.btnByPrice.Location = new System.Drawing.Point(247, 46);
            this.btnByPrice.Name = "btnByPrice";
            this.btnByPrice.Size = new System.Drawing.Size(114, 50);
            this.btnByPrice.TabIndex = 8;
            this.btnByPrice.Text = "3. By price\r\n";
            this.btnByPrice.Click += new System.EventHandler(this.btnByPrice_Click);
            // 
            // btnByTime
            // 
            this.btnByTime.BorderRadius = 12;
            this.btnByTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnByTime.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnByTime.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnByTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnByTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnByTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.btnByTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnByTime.ForeColor = System.Drawing.Color.White;
            this.btnByTime.Location = new System.Drawing.Point(127, 46);
            this.btnByTime.Name = "btnByTime";
            this.btnByTime.Size = new System.Drawing.Size(114, 50);
            this.btnByTime.TabIndex = 7;
            this.btnByTime.Text = "2. By time\r\n";
            this.btnByTime.Click += new System.EventHandler(this.btnByTime_Click);
            // 
            // btnForFree
            // 
            this.btnForFree.BorderRadius = 12;
            this.btnForFree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForFree.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnForFree.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnForFree.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnForFree.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnForFree.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.btnForFree.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForFree.ForeColor = System.Drawing.Color.White;
            this.btnForFree.Location = new System.Drawing.Point(11, 46);
            this.btnForFree.Name = "btnForFree";
            this.btnForFree.Size = new System.Drawing.Size(110, 50);
            this.btnForFree.TabIndex = 6;
            this.btnForFree.Text = "1. Free\r\n";
            this.btnForFree.Click += new System.EventHandler(this.btnForFree_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.label2.Location = new System.Drawing.Point(12, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Session Type";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.guna2Panel2.BorderRadius = 12;
            this.guna2Panel2.Controls.Add(this.tbPricePerHour);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(22)))), ((int)(((byte)(38)))));
            this.guna2Panel2.Location = new System.Drawing.Point(10, 22);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(377, 96);
            this.guna2Panel2.TabIndex = 0;
            // 
            // tbPricePerHour
            // 
            this.tbPricePerHour.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.tbPricePerHour.BorderRadius = 10;
            this.tbPricePerHour.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPricePerHour.DefaultText = "";
            this.tbPricePerHour.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPricePerHour.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPricePerHour.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPricePerHour.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPricePerHour.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(35)))), ((int)(((byte)(60)))));
            this.tbPricePerHour.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPricePerHour.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.tbPricePerHour.ForeColor = System.Drawing.Color.White;
            this.tbPricePerHour.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPricePerHour.IconRight = global::CyberCoffe_User_Control.Properties.Resources.dollar_sign;
            this.tbPricePerHour.Location = new System.Drawing.Point(5, 35);
            this.tbPricePerHour.Margin = new System.Windows.Forms.Padding(5);
            this.tbPricePerHour.MaxLength = 5;
            this.tbPricePerHour.Name = "tbPricePerHour";
            this.tbPricePerHour.PlaceholderText = "";
            this.tbPricePerHour.ReadOnly = true;
            this.tbPricePerHour.SelectedText = "";
            this.tbPricePerHour.Size = new System.Drawing.Size(361, 47);
            this.tbPricePerHour.TabIndex = 6;
            this.tbPricePerHour.TextChanged += new System.EventHandler(this.tbPricePerHour_TextChanged);
            this.tbPricePerHour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPricePerHour_KeyPress);
            this.tbPricePerHour.Validating += new System.ComponentModel.CancelEventHandler(this.tbPricePerHour_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(110)))), ((int)(((byte)(180)))));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Price Per Hour";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 439);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmConfig";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.FrmConfig_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.pnlSetTimeSetPrice.ResumeLayout(false);
            this.pnlSetTimeSetPrice.PerformLayout();
            this.PnlMethods.ResumeLayout(false);
            this.PnlMethods.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbPricePerHour;
        private Guna.UI2.WinForms.Guna2Panel PnlMethods;
        private Guna.UI2.WinForms.Guna2Button btnForFree;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnByPrice;
        private Guna.UI2.WinForms.Guna2Button btnByTime;
        private System.Windows.Forms.Label lblMethodText;
        private Guna.UI2.WinForms.Guna2Panel pnlSetTimeSetPrice;
        private Guna.UI2.WinForms.Guna2TextBox tbHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox tbSeconds;
        private Guna.UI2.WinForms.Guna2TextBox tbMinutes;
        private Guna.UI2.WinForms.Guna2TextBox tbPrice;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}