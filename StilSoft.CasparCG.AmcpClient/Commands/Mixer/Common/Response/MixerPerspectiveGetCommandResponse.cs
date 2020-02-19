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
    public class MixerPerspectiveGetCommandResponse : AmcpResponse
    {
        public MixerPerspective Perspective { get; private set; }

        internal override void ProcessData(AmcpParsedData data)
        {
            base.ProcessData(data);

            var values = Converter.StringToDoubleArray(data.Data[1], " ", NumberStyles.AllowDecimalPoint | NumberStyles.AllowLeadingSign, new CultureInfo("en-US"));

            Perspective = new MixerPerspective(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7]);
        }
    }
}