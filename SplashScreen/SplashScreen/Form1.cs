using System.Drawing.Drawing2D;

namespace SplashScreen;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        // Set the size and position of the form

        // Create a GraphicsPath that defines the rounded rectangle shape
        GraphicsPath path = new GraphicsPath();
        int arcSize = 20; // adjust this value to control the roundness of the corners
        path.AddArc(0, 0, arcSize, arcSize, 180, 90); // top-left corner
        path.AddArc(this.Width - arcSize, 0, arcSize, arcSize, 270, 90); // top-right corner
        path.AddArc(this.Width - arcSize, this.Height - arcSize, arcSize, arcSize, 0, 90); // bottom-right corner
        path.AddArc(0, this.Height - arcSize, arcSize, arcSize, 90, 90); // bottom-left corner
        path.CloseAllFigures();

        // Set the Region property of the form to the custom GraphicsPath
        this.Region = new Region(path);
        progressbar1.Value = 0;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        progressbar1.Value += 1;
        progressbar1.Text = progressbar1.Value.ToString() + "%";
        if (progressbar1.Value == 100)
        {
            timer1.Enabled = false;
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}