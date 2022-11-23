namespace task;

internal partial class Form2 : Form
{
    public Form2()
    {
        InitializeComponent();
        MaximizeBox = false;
    }

    public string Label1Text
    {
        get => label1.Text;
        set => label1.Text = value;
    }

    public string TextBox1Text
    {
        get => textBox1.Text;
        set => textBox1.Text = value;
    }
}