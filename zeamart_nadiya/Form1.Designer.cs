namespace zeamart_nadiya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            tb_stok = new TextBox();
            label7 = new Label();
            tb_harga = new TextBox();
            label6 = new Label();
            tb_penerbit = new TextBox();
            label5 = new Label();
            tb_penulis = new TextBox();
            label4 = new Label();
            tb_judul = new TextBox();
            label3 = new Label();
            tb_id = new TextBox();
            label2 = new Label();
            panel3 = new Panel();
            btn_delete = new Button();
            btn_update = new Button();
            btn_add = new Button();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            tb_searchdata = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(587, 116);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(713, 81);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 30);
            label1.Name = "label1";
            label1.Size = new Size(170, 21);
            label1.TabIndex = 2;
            label1.Text = "Welcome to Zeamart";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(27, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(tb_stok);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(tb_harga);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(tb_penerbit);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(tb_penulis);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tb_judul);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(tb_id);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(27, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(648, 283);
            panel2.TabIndex = 2;
            // 
            // tb_stok
            // 
            tb_stok.Location = new Point(248, 228);
            tb_stok.Name = "tb_stok";
            tb_stok.Size = new Size(354, 23);
            tb_stok.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(182, 233);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 8;
            label7.Text = "stok";
            // 
            // tb_harga
            // 
            tb_harga.Location = new Point(248, 185);
            tb_harga.Name = "tb_harga";
            tb_harga.Size = new Size(354, 23);
            tb_harga.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(182, 190);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 8;
            label6.Text = "harga";
            // 
            // tb_penerbit
            // 
            tb_penerbit.Location = new Point(248, 143);
            tb_penerbit.Name = "tb_penerbit";
            tb_penerbit.Size = new Size(354, 23);
            tb_penerbit.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 148);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 6;
            label5.Text = "penerbit";
            // 
            // tb_penulis
            // 
            tb_penulis.Location = new Point(248, 102);
            tb_penulis.Name = "tb_penulis";
            tb_penulis.Size = new Size(354, 23);
            tb_penulis.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(182, 107);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 4;
            label4.Text = "penulis";
            // 
            // tb_judul
            // 
            tb_judul.Location = new Point(248, 62);
            tb_judul.Name = "tb_judul";
            tb_judul.Size = new Size(354, 23);
            tb_judul.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 67);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 2;
            label3.Text = "judul";
            // 
            // tb_id
            // 
            tb_id.Location = new Point(248, 23);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(354, 23);
            tb_id.TabIndex = 1;
            tb_id.TextChanged += tb_id_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 28);
            label2.Name = "label2";
            label2.Size = new Size(17, 15);
            label2.TabIndex = 0;
            label2.Text = "id";
            // 
            // panel3
            // 
            panel3.BackColor = Color.CornflowerBlue;
            panel3.Controls.Add(btn_delete);
            panel3.Controls.Add(btn_update);
            panel3.Controls.Add(btn_add);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(27, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(150, 283);
            panel3.TabIndex = 0;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(28, 225);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(88, 23);
            btn_delete.TabIndex = 3;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(28, 190);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(88, 23);
            btn_update.TabIndex = 2;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(28, 158);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(88, 23);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image_removebg_preview;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(150, 138);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSteelBlue;
            panel4.Controls.Add(tb_searchdata);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(dataGridView1);
            panel4.Location = new Point(27, 414);
            panel4.Name = "panel4";
            panel4.Size = new Size(648, 200);
            panel4.TabIndex = 3;
            // 
            // tb_searchdata
            // 
            tb_searchdata.Location = new Point(85, 18);
            tb_searchdata.Name = "tb_searchdata";
            tb_searchdata.Size = new Size(530, 23);
            tb_searchdata.TabIndex = 11;
            tb_searchdata.TextChanged += tb_searchdata_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(28, 23);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 10;
            label8.Text = "search";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 626);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox tb_stok;
        private Label label7;
        private TextBox tb_harga;
        private Label label6;
        private TextBox tb_penerbit;
        private Label label5;
        private TextBox tb_penulis;
        private Label label4;
        private TextBox tb_judul;
        private Label label3;
        private TextBox tb_id;
        private Label label2;
        private Panel panel3;
        private Button btn_add;
        private PictureBox pictureBox2;
        private Panel panel4;
        private TextBox tb_searchdata;
        private Label label8;
        private Button btn_delete;
        private Button btn_update;
    }
}