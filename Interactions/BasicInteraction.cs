using UnityEngine;
using UnityEngine.Events;

namespace AppartementTemoins.Interactions
{
    using Definitions;
    using Common;

    /// <summary>
    /// Basic Object Interaction.
    /// </summary>
    public class BasicInteraction : MonoBehaviour, IInteraction
    {
        [SerializeField]
        [Header("Interaction Settings.")]
        private InteractionData Settings = null;

        [SerializeField]
        [Header("Interaction Event.")]
        private UnityEvent InteractionEvent;

        [SerializeField]
        [Header("Description Event.")]
        private UnityEvent DescriptionEvent;

        public InteractionData Data => this.Settings;


        public void Interact()
        {
            GameState.GetInstance().Wallet.AddSaves(this.Settings.PriceSaved);

            if (this.InteractionEvent != null)
                this.InteractionEvent.Invoke();
        }

        public void ShowDescription()
        {
            GameState.GetInstance().DescriptionModal.Title = this.Settings.Name;
            GameState.GetInstance().DescriptionModal.Description = this.Settings.Description;
            GameState.GetInstance().DescriptionModal.Savings = this.Settings.PriceSavedText;

            if (this.DescriptionEvent != null)
                this.DescriptionEvent.Invoke();
        }
    }
}
