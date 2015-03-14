using System.Collections.Generic;

namespace NCPLAY.BLL.Datatypes.BattleNet.WoW
{
    public class AuctionDataResponse1 : ApiResponse
    {
        public List<AuctionDataFile> Files { get; set; }

        public class AuctionDataFile
        {
            public string Url { get; set; }
            public long LastModified { get; set; }
        }
    }

    public class AuctionDataResponse : ApiResponse
    {
        public AuctionDataRealm Realm { get; set; }
        public AuctionDataAuctions Auctions { get; set; }

        public class AuctionDataAuctions
        {
            public List<AuctionDataAuction> Auctions { get; set; }


            public class AuctionDataAuction
            {
                public long Auc { get; set; }
                public long Item { get; set; }
                public string Owner { get; set; }
                public string OwnerRealm { get; set; }
                public long Bid { get; set; }
                public long Buyout { get; set; }
                public int Quantity { get; set; }
                public string TimeLeft { get; set; }
                public long Rand { get; set; }
                public long Seed { get; set; }
                public long Context { get; set; }
            }
        }

        public class AuctionDataRealm
        {
            public string Name { get; set; }
            public string Slug { get; set; }
        }
    }
}