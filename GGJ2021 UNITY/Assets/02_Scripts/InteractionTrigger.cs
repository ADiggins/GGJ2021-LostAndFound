using UnityEngine;
using UnityEngine.Events;

public class InteractionTrigger : MonoBehaviour
{
    [SerializeField]
    private PromptFollowPlayer playerPromptUI;

    [SerializeField]
    private string promptText;

    [SerializeField]
    private KeyCode interactKeyCode = KeyCode.E;

    [SerializeField]
    private UnityEvent unityEvent;


    private bool isPlayerInTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (isPlayerInTrigger)
        {
            return;
        }
        isPlayerInTrigger = other.gameObject.IsPlayer();
        playerPromptUI.DisplayPrompt(promptText);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.IsPlayer() && isPlayerInTrigger)
        {
            isPlayerInTrigger = false;
            playerPromptUI.Clear();
        }
    }

    private void Update()
    {
        if (isPlayerInTrigger)
        {
            if (Input.GetKeyDown(interactKeyCode))
            {
                unityEvent.Invoke();
                playerPromptUI.Clear();
            }
        }
    }
}
