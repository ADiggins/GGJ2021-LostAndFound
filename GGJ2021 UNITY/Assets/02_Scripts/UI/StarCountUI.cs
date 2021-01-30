using TMPro;
using UnityEngine;

public class StarCountUI : MonoBehaviour
{

    [SerializeField]
    private StarTracker starCount;

    private TMP_Text text;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        text.text = ((int)starCount.currentStars).ToString() + "/10";
    }

}
