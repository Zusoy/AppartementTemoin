using UnityEngine;
using UnityEngine.Events;

namespace AppartementTemoins
{
    using Interactions.Definitions;

    /// <summary>
    /// Handle Interactions
    /// </summary>
    public class InteractionCamera : MonoBehaviour
    {
        private Camera cam;

        private void Start()
        {
            this.cam = this.GetComponent<Camera>();
        }

        private void FixedUpdate()
        {
            this.CheckForInteraction();   
        }

        private void CheckForInteraction()
        {
            IInteraction interaction = this.GetTargetInteraction();

            GameState.GetInstance().UIInteractionAlert.gameObject.SetActive(
                interaction != null
            );

            if (Input.GetMouseButtonDown(0) && !GameState.GetInstance().Player.IsStatic)
            {
                if (interaction != null)
                    interaction.Interact();
            }
            
            if (Input.GetMouseButtonDown(1) && !GameState.GetInstance().Player.IsStatic)
            {
                if (interaction != null)
                    interaction.ShowDescription();
            }
        }

        private IInteraction GetTargetInteraction()
        {
            RaycastHit hit;

            if (Physics.Raycast(this.transform.position, this.transform.forward, out hit, 1.5f))
            {
                IInteraction interaction = hit.transform.GetComponent<IInteraction>();
                return interaction;
            }

            return null;
        }
    }
}
