namespace AuctionAPI
{
    public class Auction
    {
        public int AuctionId { get; set; }
        public string AuctionName { get; set; } = String.Empty;
        public string AuctionDescription { get; set; } = String.Empty;
        public string AuctionImage { get; set; } = String.Empty;
        public string AuctionStartDate { get; set; } = String.Empty;
        public string AuctionEndDate { get; set; } = String.Empty;
        public int AuctionStatus { get; set; } 
        public int AuctionOwnerUserId { get; set; }
        public string AuctionOwnerUserName { get; set; } = String.Empty;
        public string AuctionCategory { get; set; } = String.Empty;
        public int AuctionBidAmount { get; set; }
        public int AuctionBidUserId { get; set; }
        
    }
}
