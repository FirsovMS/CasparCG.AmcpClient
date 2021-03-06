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
using System.Globalization;

namespace StilSoft.CasparCG.AmcpClient.Commands.Mixer.Common.Response
{
    public class MixerMasterVolumeGetCommandResponse : AmcpResponse
    {
        public double MasterVolume { get; private set; }

        internal override void ProcessData(AmcpParsedData data)
        {
            base.ProcessData(data);

            MasterVolume = double.Parse(data.Data[1], NumberStyles.AllowDecimalPoint, new CultureInfo("en-US"));
        }
    }
}