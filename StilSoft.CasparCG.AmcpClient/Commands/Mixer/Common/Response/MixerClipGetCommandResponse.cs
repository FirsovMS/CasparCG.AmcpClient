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
using StilSoft.CasparCG.AmcpClient.Utils;
using System.Globalization;

namespace StilSoft.CasparCG.AmcpClient.Commands.Mixer.Common.Response
{
    public class MixerClipGetCommandResponse : AmcpResponse
    {
        public MixerClip Clip { get; private set; }

        internal override void ProcessData(AmcpParsedData data)
        {
            base.ProcessData(data);

            var values = Converter.StringToDoubleArray(data.Data[1], " ", NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"));

            Clip = new MixerClip(values[0], values[1], values[2], values[3]);
        }
    }
}