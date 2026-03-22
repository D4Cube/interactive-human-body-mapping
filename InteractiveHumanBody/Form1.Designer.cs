namespace InteractiveHumanBody;

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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        FaceList = new System.Windows.Forms.ComboBox();
        ViewList = new System.Windows.Forms.ComboBox();
        AmountList = new System.Windows.Forms.ComboBox();
        SaveButton = new System.Windows.Forms.Button();
        BodyName = new System.Windows.Forms.TextBox();
        DescriptionBox = new System.Windows.Forms.RichTextBox();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        pictureBox3 = new System.Windows.Forms.PictureBox();
        LoadPicture = new System.Windows.Forms.PictureBox();
        DeleteButton = new System.Windows.Forms.Button();
        pictureBox2 = new System.Windows.Forms.PictureBox();
        CleanButton = new System.Windows.Forms.Button();
        listBox1 = new System.Windows.Forms.ListBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)LoadPicture).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        SuspendLayout();
        // 
        // FaceList
        // 
        FaceList.ForeColor = System.Drawing.SystemColors.ScrollBar;
        FaceList.FormattingEnabled = true;
        FaceList.Items.AddRange(new object[] { "Derecho", "Izquierdo" });
        FaceList.Location = new System.Drawing.Point(26, 65);
        FaceList.Name = "FaceList";
        FaceList.Size = new System.Drawing.Size(121, 23);
        FaceList.TabIndex = 1;
        FaceList.Text = "Lado";
        FaceList.Enter += FaceList_Enter;
        FaceList.Leave += FaceList_Leave;
        // 
        // ViewList
        // 
        ViewList.ForeColor = System.Drawing.SystemColors.ScrollBar;
        ViewList.FormattingEnabled = true;
        ViewList.Items.AddRange(new object[] { "Frente", "Detras", "N/A" });
        ViewList.Location = new System.Drawing.Point(26, 107);
        ViewList.Name = "ViewList";
        ViewList.Size = new System.Drawing.Size(121, 23);
        ViewList.TabIndex = 2;
        ViewList.Text = "Vista";
        ViewList.Enter += ViewList_Enter;
        ViewList.Leave += ViewList_Leave;
        // 
        // AmountList
        // 
        AmountList.ForeColor = System.Drawing.SystemColors.ScrollBar;
        AmountList.FormattingEnabled = true;
        AmountList.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
        AmountList.Location = new System.Drawing.Point(26, 148);
        AmountList.Name = "AmountList";
        AmountList.Size = new System.Drawing.Size(121, 23);
        AmountList.TabIndex = 3;
        AmountList.Text = "Cantidad";
        AmountList.Enter += AmountList_Enter;
        AmountList.Leave += AmountList_Leave;
        // 
        // SaveButton
        // 
        SaveButton.Location = new System.Drawing.Point(89, 336);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new System.Drawing.Size(75, 23);
        SaveButton.TabIndex = 4;
        SaveButton.Text = "Guardar";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += Save;
        // 
        // BodyName
        // 
        BodyName.Enabled = false;
        BodyName.ForeColor = System.Drawing.SystemColors.ScrollBar;
        BodyName.Location = new System.Drawing.Point(26, 26);
        BodyName.Name = "BodyName";
        BodyName.Size = new System.Drawing.Size(121, 23);
        BodyName.TabIndex = 5;
        BodyName.Tag = "";
        BodyName.Text = "Parte del cuerpo";
        // 
        // DescriptionBox
        // 
        DescriptionBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
        DescriptionBox.Location = new System.Drawing.Point(164, 26);
        DescriptionBox.MaxLength = 50;
        DescriptionBox.Name = "DescriptionBox";
        DescriptionBox.Size = new System.Drawing.Size(153, 145);
        DescriptionBox.TabIndex = 6;
        DescriptionBox.Text = "Descripción";
        DescriptionBox.Enter += DescriptionBox_Enter;
        DescriptionBox.Leave += DescriptionBox_Leave;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.Location = new System.Drawing.Point(340, 26);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(314, 600);
        pictureBox1.TabIndex = 7;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(34, 572);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(130, 17);
        label1.TabIndex = 9;
        label1.Text = "Coordenadas:";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(34, 589);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(130, 17);
        label2.TabIndex = 10;
        label2.Text = "HEX Map1:";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(34, 606);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(130, 17);
        label3.TabIndex = 11;
        label3.Text = "HEX Map2:";
        // 
        // pictureBox3
        // 
        pictureBox3.Image = ((System.Drawing.Image)resources.GetObject("pictureBox3.Image"));
        pictureBox3.Location = new System.Drawing.Point(340, 26);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new System.Drawing.Size(314, 600);
        pictureBox3.TabIndex = 13;
        pictureBox3.TabStop = false;
        pictureBox3.Click += ColorPicker;
        // 
        // LoadPicture
        // 
        LoadPicture.Image = ((System.Drawing.Image)resources.GetObject("LoadPicture.Image"));
        LoadPicture.InitialImage = null;
        LoadPicture.Location = new System.Drawing.Point(50, 188);
        LoadPicture.MaximumSize = new System.Drawing.Size(241, 131);
        LoadPicture.Name = "LoadPicture";
        LoadPicture.Size = new System.Drawing.Size(241, 131);
        LoadPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        LoadPicture.TabIndex = 14;
        LoadPicture.TabStop = false;
        LoadPicture.Click += Load;
        // 
        // DeleteButton
        // 
        DeleteButton.Location = new System.Drawing.Point(231, 566);
        DeleteButton.Name = "DeleteButton";
        DeleteButton.Size = new System.Drawing.Size(75, 23);
        DeleteButton.TabIndex = 16;
        DeleteButton.Text = "Borrar";
        DeleteButton.UseVisualStyleBackColor = true;
        DeleteButton.Click += Delete;
        // 
        // pictureBox2
        // 
        pictureBox2.Image = ((System.Drawing.Image)resources.GetObject("pictureBox2.Image"));
        pictureBox2.Location = new System.Drawing.Point(340, 26);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new System.Drawing.Size(314, 600);
        pictureBox2.TabIndex = 17;
        pictureBox2.TabStop = false;
        // 
        // CleanButton
        // 
        CleanButton.Location = new System.Drawing.Point(183, 336);
        CleanButton.Name = "CleanButton";
        CleanButton.Size = new System.Drawing.Size(75, 23);
        CleanButton.TabIndex = 18;
        CleanButton.Text = "Limpiar";
        CleanButton.UseVisualStyleBackColor = true;
        CleanButton.Click += CleanAction;
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(50, 383);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(241, 154);
        listBox1.TabIndex = 19;
        listBox1.DoubleClick += listBox1_DoubleClick;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(732, 659);
        Controls.Add(listBox1);
        Controls.Add(CleanButton);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(DeleteButton);
        Controls.Add(label1);
        Controls.Add(LoadPicture);
        Controls.Add(pictureBox3);
        Controls.Add(pictureBox1);
        Controls.Add(DescriptionBox);
        Controls.Add(BodyName);
        Controls.Add(SaveButton);
        Controls.Add(AmountList);
        Controls.Add(ViewList);
        Controls.Add(FaceList);
        Controls.Add(pictureBox2);
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize)LoadPicture).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ListBox listBox1;

    private System.Windows.Forms.PictureBox LoadPicture;

    private System.Windows.Forms.Button CleanButton;

    private System.Windows.Forms.PictureBox pictureBox2;

    private System.Windows.Forms.Button DeleteButton;

    private System.Windows.Forms.PictureBox pictureBox3;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.DataGridView dataGridView1;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.RichTextBox DescriptionBox;

    private System.Windows.Forms.TextBox BodyName;

    private System.Windows.Forms.Button SaveButton;

    private System.Windows.Forms.ComboBox FaceList;
    private System.Windows.Forms.ComboBox ViewList;
    private System.Windows.Forms.ComboBox AmountList;

    #endregion
}