using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC102_Final_Project
{
    internal static class ClassExtensions
    {
        public static System.Windows.Forms.Label SetLabelSettings(this System.Windows.Forms.Label label, int x, Color color, Size size, Font font)
        {
            label.Size = size;
            label.Font = font;
            label.BackColor = color;

            label.Visible = true;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.TextAlign = ContentAlignment.MiddleCenter;

            return label;
        }

        public static System.Windows.Forms.Label SetLabelColor(this System.Windows.Forms.Label label, string color)
        {
            switch (color)
            {
                case "GREEN":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#6ca965");
                    break;
                
                case "ORANGE":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#c8b653");
                    break;

                case "GRAY":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#787c7f");
                    break;

                case "CONTROL":
                    label.BackColor = Color.FromKnownColor(KnownColor.Control);
                    break;

                case "DEFAULT":
                    label.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFFFFF");
                    break;
            }

            return label;
        }
    }
}