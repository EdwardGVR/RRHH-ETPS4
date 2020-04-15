using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHH.PL
{
    class ControlUtils
    {
        public static void abrirFormEnPanel(Control container, object formChild)
        {
            //if (container.Controls.Count > 0)
            //    container.Controls.RemoveAt(0);
            Form fc = formChild as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            container.Controls.Add(fc);
            container.Tag = fc;
            fc.Show();
        }

        public static void centrar(Control padre, Control hijo)
        {
            int x = 0;
            int y = 0;

            x = (padre.Width / 2) - (hijo.Width / 2);
            y = (padre.Height / 2) - (hijo.Height / 2);

            hijo.Location = new System.Drawing.Point(x, y);
        }

        public static Control getContainer (Control container)
        {
            return container;
        }
    }
}
