using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SwapMouse
{
    public partial class frmSwapMouse : Form
    {
        private const int RIGHT_HANDED = 0;
        private const int LEFT_HANDED = 1;

        [DllImport("user32.dll")]
        public static extern Int32 SwapMouseButton(Int32 bSwap);

        public frmSwapMouse()
        {
            InitializeComponent();
            this.DisplayCurrentMouseSetup();
        }

        private void FlipMouse(object sender, EventArgs e)
        {
            SwapMouseButton(this.rdoRight.Checked ? RIGHT_HANDED : LEFT_HANDED);
        }

        private void FocussedForm(object sender, EventArgs e)
        {
            this.DisplayCurrentMouseSetup();
        }

        private void DisplayCurrentMouseSetup()
        {
            //There is not a direct method for obtaining the current mouse direction
            //instead calling the swap method will return 0 if the direction was previously right handed, else non zero if previously left handed
            var mouseIsCurrentlyLeftHanded = SwapMouseButton(LEFT_HANDED) != 0;

            //restore whatever direction the mouse was set to
            SwapMouseButton(mouseIsCurrentlyLeftHanded ? LEFT_HANDED : RIGHT_HANDED);

            //display to the user what direction the mouse is currently set as
            this.rdoLeft.Checked = mouseIsCurrentlyLeftHanded;
        }
    }
}
