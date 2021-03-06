//////////////////////////////////////////////////////////////////////////////////
//
// Author: Sase
// Email: sase@stilsoft.net
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//
//////////////////////////////////////////////////////////////////////////////////

namespace StilSoft.CasparCG.AmcpClient.CommandBuilder.Attributes.Conditions
{
    internal class IncludeIfNotIncludedAttribute : AbstractPropertyIncludedConditionAttribute
    {
        public IncludeIfNotIncludedAttribute(string propertyName) : base(propertyName)
        {
        }
    }
}