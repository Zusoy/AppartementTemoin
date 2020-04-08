using UnityEngine;
using TMPro;

namespace AppartementTemoins.UI
{
    /// <summary>
    /// Interaction Description Window
    /// </summary>
    public class DescriptionWindow : MonoBehaviour
    {
        public string Title
        {
            get => this.transform.Find("Content")
                    .Find("Title Bar")
                    .Find("Title")
                    .GetComponent<TextMeshProUGUI>()
                    .text;
            set => this.transform.Find("Content")
                    .Find("Title Bar")
                    .Find("Title")
                    .GetComponent<TextMeshProUGUI>()
                    .text = value;
        }

        public string Description
        {
            get => this.transform.Find("Content")
                        .Find("Tabs")
                        .Find("Tab 1")
                        .Find("Text")
                        .GetComponent<TextMeshProUGUI>()
                        .text;
            set => this.transform.Find("Content")
                        .Find("Tabs")
                        .Find("Tab 1")
                        .Find("Text")
                        .GetComponent<TextMeshProUGUI>()
                        .text = value;
        }

        public string Savings
        {
            get => this.transform.Find("Content")
                        .Find("Tabs")
                        .Find("Tab 2")
                        .Find("Text")
                        .GetComponent<TextMeshProUGUI>()
                        .text;
            set => this.transform.Find("Content")
                        .Find("Tabs")
                        .Find("Tab 2")
                        .Find("Text")
                        .GetComponent<TextMeshProUGUI>()
                        .text = value;
        }
    }
}
