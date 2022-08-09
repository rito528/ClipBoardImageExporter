using System.Runtime.InteropServices;

namespace ClipBoardImageExporter
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        private extern static void AddClipboardFormatListener(IntPtr hwnd);

        public Form1()
        {
            ShowInTaskbar = false;
            WindowState = FormWindowState.Minimized;
            AddClipboardFormatListener(Handle);
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x31D)
            {
                new ClipboardExporter().export();
            }
            else base.WndProc(ref m);
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}