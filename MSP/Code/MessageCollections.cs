using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MSP.Properties;

namespace MSP.Code
{
    public static class MessageCollections
    {
        // Message
        public static void ShowEmptyDataMessage()
        {
            MessageBox.Show(Resources.EmptyMessageText, Resources.EmptyMessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        // Dialog
    }
}
