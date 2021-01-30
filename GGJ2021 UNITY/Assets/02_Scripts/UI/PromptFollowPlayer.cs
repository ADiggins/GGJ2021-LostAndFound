using TMPro;
using UnityEngine;

[ExecuteInEditMode]
public class PromptFollowPlayer : MonoBehaviour
{
    /// <summary>
    /// The transform of the object to follow the position of. The Text component will follow this transform
    /// </summary>
    [SerializeField]
    private Transform positionToFollow;

    /// <summary>
    /// Amount to offset the position of the text by
    /// </summary>
    [SerializeField]
    private Vector3 positionOffset;

    /// <summary>
    /// /// The transform of the object to match rotation with. This should be the camera;
    /// </summary>
    [SerializeField]
    private Transform rotationToFollow;

    private TMP_Text textUI;

    private void Awake()
    {
        textUI = GetComponent<TMP_Text>();
    }

    public void DisplayPrompt(string textToDisplay)
    {
        textUI.text = textToDisplay;
    }

    public void Clear()
    {
        textUI.text = "";
    }

    private void Update()
    {
        transform.position = positionToFollow.transform.position + positionToFollow.forward * positionOffset.z + positionToFollow.up * positionOffset.y + positionToFollow.right * positionOffset.x;// positionOffset ;
        transform.rotation = rotationToFollow.transform.rotation;
    }
}
