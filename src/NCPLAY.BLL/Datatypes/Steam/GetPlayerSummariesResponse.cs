using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.Steam
{
    public class GetPlayerSummariesResponse : ApiResponse
    {
        //public SupportedApiList Response { get; set; }

        public string Type { get; set; }
        public bool Optional { get; set; }
        public string Description { get; set; }

        public class PlayerSummary
        {
            //64bit SteamID of the user
            public long steamid { get; set; }
            //The player's persona name (display name)
            public string personaname { get; set; }
            //The full URL of the player's Steam Community profile.
            public string profileurl { get; set; }
            //The full URL of the player's 32x32px avatar. If the user hasn't configured an avatar, this will be the default ? avatar.
            public string avatar { get; set; }
            //The full URL of the player's 64x64px avatar. If the user hasn't configured an avatar, this will be the default ? avatar.
            public string avatarmedium { get; set; }
            //The full URL of the player's 184x184px avatar. If the user hasn't configured an avatar, this will be the default ? avatar.
            public string avatarfull { get; set; }
            //The user's current status. 0 - Offline, 1 - Online, 2 - Busy, 3 - Away, 4 - Snooze, 5 - looking to trade, 6 - looking to play. 
            //If the player's profile is private, this will always be "0", except is the user has set his status to looking to trade or looking 
            //to play, because a bug makes those status appear even if the profile is private.
            public int personastate { get; set; }
            //This represents whether the profile is visible or not, and if it is visible, why you are allowed to see it. 
            //Note that because this WebAPI does not use authentication, there are only two possible values returned: 
            //1 - the profile is not visible to you (Private, Friends Only, etc), 3 - the profile is "Public", and the data is visible. 
            //Mike Blaszczak's post on Steam forums says, "The community visibility state this API returns is different than the privacy state. 
            //It's the effective visibility state from the account making the request to the account being viewed given the requesting 
            //account's relationship to the viewed account.
            public int communityvisibilitystate { get; set; }
            //If set, indicates the user has a community profile configured (will be set to '1')
            public int profilestate { get; set; }
            //The last time the user was online, in unix time.
            public string lastlogoff { get; set; }
            //If set, indicates the profile allows public comments.
            public string commentpermission { get; set; }

            //Private Data
            //The player's "Real Name", if they have set it.
            public string realname { get; set; }
            //The player's primary group, as configured in their Steam Community profile.
            public long primaryclanid { get; set; }
            //The time the player's account was created.
            public string timecreated { get; set; }
            //If the user is currently in-game, this value will be returned and set to the gameid of that game.
            public long gameid { get; set; }
            //The ip and port of the game server the user is currently playing on, if they are playing on-line in a game using Steam matchmaking. 
            //Otherwise will be set to "0.0.0.0:0".
            public string gameserverip { get; set; }
            //If the user is currently in-game, this will be the name of the game they are playing. This may be the name of a non-Steam game shortcut.
            public string gameextrainfo { get; set; }
            //This value will be removed in a future update (see loccityid)
            public long cityid { get; set; }
            //If set on the user's Steam Community profile, The user's country of residence, 2-character ISO country code
            public string loccountrycode { get; set; }
            //If set on the user's Steam Community profile, The user's state of residence
            public int locstatecode { get; set; }
            //An internal code indicating the user's city of residence. A future update will provide this data in a more useful way.
            public long loccityid { get; set; }
        }

        //public class SupportedApiList
        //{
        //    public List<PlayerSummary> players { get; set; }
        //}
    }
}