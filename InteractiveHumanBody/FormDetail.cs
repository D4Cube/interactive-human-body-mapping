namespace InteractiveHumanBody;

public partial class FormDetail : Form
{
    public FormDetail(Regist regist)
    {
        InitializeComponent();
        
        label1.Text = regist.Data1;
        label2.Text = regist.Data2;
        label3.Text = regist.Data3;
        label4.Text = regist.Data4;
        richTextBox1.Text = regist.Data5;

        pictureBox1.Image = regist.SaveImage;
    }
}