using UnityEngine;
using UnityEngine.Events;

namespace AppartementTemoins
{
    using Definitions;

    public class Wallet : MonoBehaviour, IWallet
    {
        private readonly string PRICE_SAVED_SUFFIX = "/ans";

        [SerializeField]
        private float saves = 0f;

        [SerializeField]
        private UnityEvent NewSaveEvent;

        public float CurrentSaves => this.saves;

        public void AddSaves(float saves)
        {
            this.saves += saves;
            GameState.GetInstance().UISaves.Saves = this.saves.ToString() + this.PRICE_SAVED_SUFFIX;

            if (this.NewSaveEvent != null)
                this.NewSaveEvent.Invoke();
        }

        public void RemoveSaves(float saves)
        {
            this.saves -= saves;
            GameState.GetInstance().UISaves.Saves = this.saves.ToString() + this.PRICE_SAVED_SUFFIX;
        }
    }
}
