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
using StilSoft.CasparCG.AmcpClient.CommandBuilder.Attributes.Conditions;
using StilSoft.CasparCG.AmcpClient.Common.Enums;
using System.ComponentModel.DataAnnotations;

namespace StilSoft.CasparCG.AmcpClient.Commands.Mixer.Common
{
    [CommandBuilderObject]
    public class Transform
    {
        // [duration:int]
        // {
        //     [tween:string]
        //     |linear
        // }
        // |0 linear

        /// <summary>
        /// Duration of transformation.
        /// </summary>
        [Required]
        [Range(0, int.MaxValue)]
        [IncludeIfNotEqual(nameof(Duration), 0)]
        [CommandParameter]
        public int? Duration { get; set; }

        /// <summary>
        /// Transformation tween.
        /// </summary>
        [EnumDataType(typeof(Tween))]
        [IncludeIfIncluded(nameof(Duration))]
        [IncludeIfNotEqual(nameof(Tween), AmcpClient.Common.Enums.Tween.Linear)]
        [CommandParameter]
        public Tween? Tween { get; set; }

        /// <param name="duration"><see cref="Duration"/> </param>
        /// <param name="tween"><see cref="Tween"/> </param>
        public Transform(int? duration = null, Tween? tween = null)
        {
            Duration = duration;
            Tween = tween;
        }
    }
}