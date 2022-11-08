﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license or other governing licenses that can be found in the LICENSE.md file or at
 * https://raw.githubusercontent.com/Krypton-Suite/Extended-Toolkit/master/LICENSE
 */
#endregion

namespace Krypton.Toolkit.Suite.Extended.Error.Reporting
{
    /// <summary>
    /// winforms and wpf have different means of taking screenshots, hence this abstraction
    /// </summary>
    public interface IScreenShooter
    {
        /// <summary />
        /// <returns></returns>
        string TakeScreenShot();
    }
}