using System.Runtime.InteropServices;

namespace ClipBoardImageExporter
{
    internal class ClipboardExporter
    {

        public void export()
        {
            if (!Clipboard.ContainsImage()) return;

            DateTime dt = DateTime.Now;

            new Bitmap(Clipboard.GetImage()).Save(
                Path.GetDirectoryName(Application.ExecutablePath) + @"\" + dt.ToString("yyyy-MM-dd HH-mm-ss") + ".png", 
                System.Drawing.Imaging.ImageFormat.Png
            );
            
        }

    }
}
