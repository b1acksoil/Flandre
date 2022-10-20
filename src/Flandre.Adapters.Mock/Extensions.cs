﻿using Flandre.Core.Messaging;

namespace Flandre.Adapters.Mock;

public static class FlandreTestingExtensions
{
    public static MockClient GenerateChannelClient(this MockAdapter adapter, string guildId, string channelId,
        string userId)
    {
        return new MockClient(adapter)
        {
            EnvironmentType = MessageSourceType.Channel,
            GuildId = guildId,
            ChannelId = channelId,
            UserId = userId
        };
    }

    public static MockClient GenerateChannelClient(this MockAdapter adapter)
    {
        return GenerateChannelClient(adapter, Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
            Guid.NewGuid().ToString());
    }

    public static MockClient GenerateFriendClient(this MockAdapter adapter, string userId)
    {
        return new MockClient(adapter)
        {
            EnvironmentType = MessageSourceType.Private,
            UserId = userId
        };
    }

    public static MockClient GenerateFriendClient(this MockAdapter adapter)
    {
        return GenerateFriendClient(adapter, Guid.NewGuid().ToString());
    }
}