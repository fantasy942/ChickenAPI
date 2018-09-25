﻿namespace ChickenAPI.Packets
{
    public abstract class PacketBase : IPacket
    {
        #region Properties

        public string Header { get; set; }

        // get the packet without the sessionId
        public string Content => OriginalContent.Substring(OriginalContent.IndexOf(' '));

        /// <summary>
        /// </summary>
        public string OriginalContent { get; set; }

        #endregion
    }
}