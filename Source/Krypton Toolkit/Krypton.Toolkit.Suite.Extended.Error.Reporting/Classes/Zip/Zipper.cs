﻿#region BSD License
/*
 * Use of this source code is governed by a BSD-style
 * license or other governing licenses that can be found in the LICENSE.md file or at
 * https://raw.githubusercontent.com/Krypton-Suite/Extended-Toolkit/master/LICENSE
 */
#endregion

namespace Krypton.Toolkit.Suite.Extended.Error.Reporting
{
    internal class Zipper : IZipper
    {
        public void Zip(string zipFile, IEnumerable<string> files)
        {
            using (var zip = new ZipFile(zipFile))
            {
                zip.AddFiles(files, directoryPathInArchive: "");
                zip.Save();
            }
        }
    }
}