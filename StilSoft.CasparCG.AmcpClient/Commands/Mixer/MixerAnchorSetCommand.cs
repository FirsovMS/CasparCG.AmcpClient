﻿//////////////////////////////////////////////////////////////////////////////////
//
// Author: Sase
// Email: sase@stilsoft.net
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//
//////////////////////////////////////////////////////////////////////////////////

using StilSoft.CasparCG.AmcpClient.CommandBuilder.Attributes;
using StilSoft.CasparCG.AmcpClient.Commands.Mixer.Common;
using System.ComponentModel.DataAnnotations;

namespace StilSoft.CasparCG.AmcpClient.Commands.Mixer
{
    /// <summary>
    /// Change the anchor point of a layer.
    /// </summary>
    public class MixerAnchorSetCommand : AbstractMixerLayerCommandWithSubCommand
    {
        // MIXER
        // [video_channel:int]
        // {
        //     -[layer:int]
        //     |-0
        // }
        // ANCHOR
        // {
        //     [x:float]
        //     [y:float]
        //     {
        //         [duration:int]
        //         {
        //             [tween:string]
        //             |linear
        //         }
        //         |0 linear
        //     }
        // }

        internal override string SubCommandName { get; } = "ANCHOR";

        [Required]
        [CommandParameter]
        public MixerAnchor Anchor { get; set; }

        [CommandParameter]
        public Transform Transform { get; set; }

        public MixerAnchorSetCommand(int? channel = null, int? layer = null, MixerAnchor anchor = null, Transform transform = null)
        {
            Channel = channel;
            Layer = layer;
            Anchor = anchor;
            Transform = transform;
        }
    }
}