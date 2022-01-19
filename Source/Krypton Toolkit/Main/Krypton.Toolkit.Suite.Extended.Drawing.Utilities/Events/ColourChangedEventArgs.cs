﻿namespace Krypton.Toolkit.Suite.Extended.Drawing.Utilities
{
    public class ColourChangedEventArgs : EventArgs
    {
        #region Variables
        private Color _colour;
        #endregion

        #region Property
        public Color Colour { get => _colour; set => _colour = value; }
        #endregion

        #region Constructor
        public ColourChangedEventArgs(Color colour)
        {
            Colour = colour;
        }
        #endregion
    }
}