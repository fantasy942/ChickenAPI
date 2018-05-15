﻿using System.Collections;
using System.Collections.Generic;
using ChickenAPI.Game.Network;
using ChickenAPI.Packets;

namespace ChickenAPI.ECS.Entities
{
    public interface IPlayerEntity : IEntity
    {
        void SendPacket(IPacket packetBase);
        void SendPackets(IEnumerable<IPacket> packets);

        ISession Session { get; }
    }
}