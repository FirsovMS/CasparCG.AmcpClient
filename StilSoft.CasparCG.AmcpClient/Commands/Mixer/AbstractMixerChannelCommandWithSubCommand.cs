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

namespace StilSoft.CasparCG.AmcpClient.Commands.Mixer
{
    public abstract class AbstractMixerChannelCommandWithSubCommand : AbstractMixerChannelCommandWithSubCommand<AmcpResponse>
    {
    }

    public abstract class AbstractMixerChannelCommandWithSubCommand<TResponse> : AbstractChannelCommandWithSubCommand<TResponse>
        where TResponse : AmcpResponse, new()
    {
        internal override string CommandName { get; } = "MIXER";
    }
}