﻿//////////////////////////////////////////////////////////////////////////////////
//
// Author: Sase
// Email: sase@stilsoft.net
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//
//////////////////////////////////////////////////////////////////////////////////

using StilSoft.CasparCG.AmcpClient.CommandBuilder.Attributes.Conditions;
using StilSoft.CasparCG.AmcpClient.Common;

namespace StilSoft.CasparCG.AmcpClient.Commands.Cg
{
    public abstract class AbstractCgCommandWithSubCommandNoCgLayer : AbstractCgCommandWithSubCommandNoCglayer<AmcpResponse>
    {
    }

    public abstract class AbstractCgCommandWithSubCommandNoCglayer<TResponse> : AbstractLayerCommandWithSubCommand<TResponse>
        where TResponse : AmcpResponse, new()
    {
        internal override string CommandName { get; } = "CG";

        /// <summary>
        /// Video layer.
        /// </summary>
        [IncludeIfNotEqual(nameof(Layer), 9999)]
        public override int? Layer { get; set; }
    }
}