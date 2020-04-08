using UnityEngine;
using UnityEngine.Events;
using UnityStandardAssets.Characters.FirstPerson;

namespace AppartementTemoins
{
    using UI;
    using Definitions;

    /// <summary>
    /// Game Global State Singleton.
    /// </summary>
    public class GameState : MonoBehaviour
    {
        [SerializeField]
        private FirstPersonController FirstPersonController;

        [SerializeField]
        private DescriptionWindow DescriptionWindow;

        [SerializeField]
        private SavesText SavesText;

        [SerializeField]
        private Transform InteractionAlert;

        [SerializeField]
        private UnityEvent StartEvent;

        private IWallet wallet; 


        private static GameState _instance;
        public static GameState GetInstance()
        {
            return _instance;
        }

        public FirstPersonController Player
        {
            private set { }
            get => this.FirstPersonController;
        }

        public IWallet Wallet
        {
            private set { }
            get => this.wallet;
        }

        public DescriptionWindow DescriptionModal
        {
            private set { }
            get => this.DescriptionWindow;
        }

        public SavesText UISaves
        {
            private set { }
            get => this.SavesText;
        }

        public Transform UIInteractionAlert
        {
            private set { }
            get => this.InteractionAlert;
        }


        private void Start()
        {
            this.wallet = this.GetComponent<IWallet>();
            _instance = this;

            this.StartEvent.Invoke();
        }
    }
}
