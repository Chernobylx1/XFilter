namespace XFilter.GameData.Player
{
    public enum StallUpdateType : byte
    {
        UpdateItem = 1,
        AddItem = 2,
        RemoveItem = 3,
        FleaMarketMode = 4,
        
        // Open or closed ?
        State = 5,
        
        Message = 6,
        Name = 7,
    }
}