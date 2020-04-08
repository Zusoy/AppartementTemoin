
namespace AppartementTemoins.Definitions
{
    /// <summary>
    /// Define Wallet Object.
    /// </summary>
    public interface IWallet
    {
        /// <summary>
        /// Current Wallet Saves.
        /// </summary>
        float CurrentSaves
        {
            get;
        }

        /// <summary>
        /// Add Saves in Wallet.
        /// </summary>
        void AddSaves(float saves);

        /// <summary>
        /// Remove Saves from Wallet.
        /// </summary>
        void RemoveSaves(float saves);
    }
}