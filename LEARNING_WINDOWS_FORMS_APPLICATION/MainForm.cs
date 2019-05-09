namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void DoSomethingButton_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.MessageBox.Show("Hello, World!");
		}
	}
}
