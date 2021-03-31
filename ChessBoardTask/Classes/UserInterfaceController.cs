using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardTask
{
    class UserInterfaceController
    {
        #region Consts

        public const string message = "Please enter even number for <Height>" +
                " than < , > and <Width>\nAfter these actions push <Enter>";

        #endregion

        #region Private

        private UserInterface _viewer;

        #endregion

        public int Height { get; private set; }

        public int Width { get; private set; }

        public UserInterfaceController()
        {
            _viewer = new UserInterface();
        }

        public void Run()
        {
            int height;
            int width;
            _viewer.GetNumbers(message, out height, out width);
            Height = height;
            Width = width;
        }
    }
}
