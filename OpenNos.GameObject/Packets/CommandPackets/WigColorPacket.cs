﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)
using OpenNos.Core;

namespace OpenNos.GameObject
{
    [PacketHeader("$WigColor")]
    public class WigColorPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public byte Color { get; set; }

        #endregion
    }
}