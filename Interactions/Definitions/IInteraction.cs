namespace AppartementTemoins.Interactions.Definitions
{
    using Common;

    /// <summary>
    /// Define an Interaction
    /// </summary>
    public interface IInteraction
    {
        /// <summary>
        /// All Interaction Data.
        /// </summary>
        InteractionData Data
        {
            get;
        }

        /// <summary>
        /// Interact with the Object.
        /// </summary>
        void Interact();

        /// <summary>
        /// Show Interaction Description.
        /// </summary>
        void ShowDescription();
    }
}
