﻿//////////////////////////////////////////////////////////////////////////////////
//
// Author: Sase
// Email: sase@stilsoft.net
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//
//////////////////////////////////////////////////////////////////////////////////

using StilSoft.CasparCG.AmcpClient.Common;

namespace StilSoft.CasparCG.AmcpClient.Commands.Data
{
    public abstract class AbstractDataCommandWithSubCommand : AbstractDataCommandWithSubCommand<AmcpResponse>
    {
    }

    public abstract class AbstractDataCommandWithSubCommand<TResponse> : AbstractBaseCommandWithSubCommand<TResponse>
        where TResponse : AmcpResponse, new()
    {
        internal override string CommandName { get; } = "DATA";
    }
}