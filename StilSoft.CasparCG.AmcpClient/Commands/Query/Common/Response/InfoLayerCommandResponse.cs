﻿//////////////////////////////////////////////////////////////////////////////////
//
// Author: Sase
// Email: sase@stilsoft.net
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//
//////////////////////////////////////////////////////////////////////////////////

using StilSoft.CasparCG.AmcpClient.Commands.Query.Common.Info.Channel;
using StilSoft.CasparCG.AmcpClient.Common;
using StilSoft.CasparCG.AmcpClient.Utils;

namespace StilSoft.CasparCG.AmcpClient.Commands.Query.Common.Response
{
    public class InfoLayerCommandResponse : AmcpResponse
    {
        public string LayerInfoXml { get; private set; }
        public LayerInfo LayerInfo { get; private set; }

        internal override void ProcessData(AmcpParsedData data)
        {
            base.ProcessData(data);

            LayerInfoXml = data.Data[1];
            LayerInfo = Serializer.XmlDeserialize<LayerInfo>(data.Data[1]);
        }
    }
}