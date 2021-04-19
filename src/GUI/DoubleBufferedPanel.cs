using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIProjectDraw.src.GUI
{
    /// <summary>
	/// Потребителски контрол, в който ще се визуализира модела.
	/// Използва се за визуализация с двойно буфериране.
	/// </summary>
    public partial class DoubleBufferedPanel : UserControl
    {
        public DoubleBufferedPanel()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }
    }
}
