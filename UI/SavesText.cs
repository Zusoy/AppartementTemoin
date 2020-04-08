using UnityEngine;
using TMPro;

namespace AppartementTemoins.UI
{
    public class SavesText : MonoBehaviour
    {
        public string Saves
        {
            get => this.transform
                    .GetComponent<TextMeshProUGUI>()
                    .text;
            set => this.transform
                    .GetComponent<TextMeshProUGUI>()
                    .text = value;
        }
    }
}
