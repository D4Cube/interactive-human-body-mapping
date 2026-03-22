using System.ComponentModel;

namespace InteractiveHumanBody;

partial class FormDetail
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        richTextBox1 = new System.Windows.Forms.RichTextBox();
        label5 = new System.Windows.Forms.Label();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(28, 22);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 0;
        label1.Text = "label1";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(28, 68);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 1;
        label2.Text = "label2";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(28, 117);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 2;
        label3.Text = "label3";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(28, 161);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 23);
        label4.TabIndex = 3;
        label4.Text = "label4";
        // 
        // richTextBox1
        // 
        richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        richTextBox1.Enabled = false;
        richTextBox1.Location = new System.Drawing.Point(28, 230);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new System.Drawing.Size(161, 138);
        richTextBox1.TabIndex = 4;
        richTextBox1.Text = "";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(28, 204);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(80, 23);
        label5.TabIndex = 5;
        label5.Text = "Descripcion";
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new System.Drawing.Point(244, 22);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(360, 360);
        pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 6;
        pictureBox1.TabStop = false;
        // 
        // FormDetail
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(666, 450);
        Controls.Add(pictureBox1);
        Controls.Add(label5);
        Controls.Add(richTextBox1);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Text = "FormDetail";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.RichTextBox richTextBox1;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    #endregion
}