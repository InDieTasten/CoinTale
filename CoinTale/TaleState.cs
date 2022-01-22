namespace CoinTale
{
    public struct TaleState
    {
        public Location CurrentLocation { get; set; }
        public bool KeepRunning { get; set; } = true;
    }
}