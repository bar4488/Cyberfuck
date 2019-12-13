﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cyberfuck.Data;
using Microsoft.Xna.Framework;

namespace Cyberfuck.Network
{
    public enum NetType
    {
        Server,
        Client,
        Single
    }
    public interface INetBase
    {
        void SendMessage(MessageContentType messageType, int player, IMessageContent data);
        void Update(GameTime gameTime);
        void Close();
        void SnapShot();
    }

}
