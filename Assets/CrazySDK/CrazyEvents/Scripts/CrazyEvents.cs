﻿using System.Collections.Generic;

namespace CrazyGames
{
    public class CrazyEvents : Singleton<CrazyEvents>
    {
        #if CRAZY_GAMES

        public void HappyTime()
        {
            CrazySDK.Instance.HappyTime();
        }

        public void GameplayStart()
        {
            CrazySDK.Instance.GameplayStart();
        }

        public void GameplayStop()
        {
            CrazySDK.Instance.GameplayStop();
        }

        public string InviteLink(Dictionary<string, string> parameters)
        {
            return CrazySDK.Instance.InviteLink(parameters);
        }

        public bool IsInviteLink()
        {
            return CrazySDK.Instance.IsInviteLink();
        }

        public string GetInviteLinkParameter(string key)
        {
            return CrazySDK.Instance.GetInviteLinkParameter(key);
        }

        public void CopyToClipboard(string text)
        {
            CrazySDK.Instance.CopyToClipboard(text);
        }
#endif
    }
}