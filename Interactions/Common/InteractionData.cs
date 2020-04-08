using UnityEngine;

namespace AppartementTemoins.Interactions.Common
{
    [CreateAssetMenu(fileName = "Interaction", menuName = "Appartement Témoins/Interaction")]
    public class InteractionData : ScriptableObject
    {
        [Header("Interaction Name.")]
        public string Name;

        [Header("Interaction Description.")]
        [TextArea]
        public string Description;

        [Header("Price saved Description with this Interaction.")]
        [TextArea]
        public string PriceSavedText;

        [Header("Price Savec / Year.")]
        public float PriceSaved;
    }
}
