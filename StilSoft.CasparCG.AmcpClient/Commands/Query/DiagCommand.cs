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
    /// Open the diagnostics window.
    /// </summary>
    public class DiagCommand : AbstractBaseCommand
    {
        // DIAG

        internal override string CommandName { get; } = "DIAG";
    }
}