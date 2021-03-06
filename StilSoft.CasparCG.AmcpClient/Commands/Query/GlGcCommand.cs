﻿//////////////////////////////////////////////////////////////////////////////////
//
// Author: Sase
// Email: sase@stilsoft.net
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//
//////////////////////////////////////////////////////////////////////////////////

namespace StilSoft.CasparCG.AmcpClient.Commands.Query
{
    /// <summary>
    /// Release pooled OpenGL resources.
    /// </summary>
    public class GlGcCommand : AbstractBaseCommand
    {
        // GL GC

        internal override string CommandName { get; } = "GL GC";
    }
}