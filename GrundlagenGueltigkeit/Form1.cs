namespace GrundlagenGueltigkeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Mx = 0;
        private int x = 0;  //Objekteigenschaft
        private double a = 0.0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            int x = 0;
            Mx++;
            x++;
            LblAnzeige.Text = $"x: {x} Mx: {Mx}";
        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            int Mx = 0;
            Mx++;
            LblAnzeige.Text = $"Mx: {Mx}";
        }

        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {
            double y = 0.0; //lokale Variable
            a += 0.1;
            y += 0.1;
            LblAnzeige.Text = $"a: {a}\n"+
                              $"y: {y}";
        }

        private void CmdAnzeige4_Click(object sender, EventArgs e)
        {
            double z = 0.0;  //lokale Variable
            a += 0.1;
            z += 0.1;
            LblAnzeige.Text = $"a: {a}\n"+
                              $"z: {z}";
        }
    }
}
