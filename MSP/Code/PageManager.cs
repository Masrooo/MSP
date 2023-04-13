using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace MSP.Code
{
    public class PageManager
    {
        private readonly Main main;

        public PageManager(Main main) 
        {
            this.main = main;
        }
        public void LoadPage(UserControl pageUserControl) 
        { 
            // Load old page
            var oldPage=main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldPage != null)
            {
                main.panelContainer.Controls.Remove(oldPage);  // Remove Old Page
                oldPage.Dispose();
            }

            // Lod New Page
            pageUserControl.Dock = DockStyle.Fill;
            main.panelContainer.Controls.Add(pageUserControl);

        }
    }
}
