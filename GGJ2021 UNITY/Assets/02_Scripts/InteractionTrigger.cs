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

	[SerializeField]
	private AudioSource audioSource;


    private bool isPlayerInTrigger = false;


	private void Awake()
	{
		if (GetComponent<AudioSource>() && audioSource == null)
			audioSource = GetComponent<AudioSource>();
	}

	private void OnTriggerEnter(Collider other)
    {
        if (isPlayerInTrigger)
        {
            return;
        }
        if (other.gameObject.IsPlayer())
        {
            isPlayerInTrigger = true;
            playerPromptUI.DisplayPrompt(promptText);
        }
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
				if (audioSource != null)
					audioSource.Play();
            }
        }
    }
}
