﻿using System.Collections.Generic;

namespace SlackNet.WebApi
{
    class ChannelListResponse
    {
        public List<Channel> Channels { get; set; } = new();
    }
}