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

    private void Start()
    {
        starCount.OnStarValueChange += UpdateStarUI;
    }

    private void UpdateStarUI(int numStars)
    {
        text.text = numStars.ToString() + "/10";
    }
}
