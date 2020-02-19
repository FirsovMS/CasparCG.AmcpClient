//////////////////////////////////////////////////////////////////////////////////
//
// Author: Sase
// Email: sase@stilsoft.net
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//
//////////////////////////////////////////////////////////////////////////////////

using StilSoft.CasparCG.AmcpClient.Common;
using System;

namespace StilSoft.CasparCG.AmcpClient.Commands.Mixer.Common.Response
{
    public class MixerMipmapGetCommandResponse : AmcpResponse
    {
        public bool IsMipmapEnabled { get; private set; }

        internal override void ProcessData(AmcpParsedData data)
        {
            base.ProcessData(data);

            IsMipmapEnabled = Convert.ToBoolean(Convert.ToInt32(data.Data[1])); ;
        }
    }
}