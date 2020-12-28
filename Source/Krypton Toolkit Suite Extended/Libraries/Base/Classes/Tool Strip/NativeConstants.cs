﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license or other governing licenses that can be found in the LICENSE.md file or at
 * https://raw.githubusercontent.com/Krypton-Suite/Extended-Toolkit/master/LICENSE
 */
#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krypton.Toolkit.Suite.Extended.Base
{
    internal sealed class NativeConstants
    {
        #region Constants
        internal const uint WM_MOUSEACTIVATE = 0x21, MA_ACTIVATE = 1, MA_ACTIVATEANDEAT = 2, MA_NOACTIVATE = 3, MA_NOACTIVATEANDEAT = 4;
        #endregion

        #region Constructor
        public NativeConstants()
        {

        }
        #endregion
    }
}