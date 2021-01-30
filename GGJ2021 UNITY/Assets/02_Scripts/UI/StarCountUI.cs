using TMPro;
using UnityEngine;

public class StarCountUI : MonoBehaviour
{

    private static readonly string ANIM_PARAM_DROP_TEXT = "DropText";

    [SerializeField]
    private StarTracker starCount;

    [SerializeField]
    private TMP_Text dropText;

    private TMP_Text text;

    private Animator animator;

    private int cachedNumStars = -1;

    private void Awake()
    {
        text = GetComponent<TMP_Text>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        starCount.OnStarValueChange += UpdateStarUI;
        UpdateStarUI((int)starCount.currentStars);
    }

    private void UpdateStarUI(int numStars)
    {
        if (cachedNumStars != -1)
        {
            var difference = numStars - cachedNumStars;
            var effectColor = Color.green;
            var sign = Mathf.Sign(difference);
            if (sign < 0)
            {
                effectColor = Color.red;
            }
            var prefix = sign > 0 ? "+" : "-";
            dropText.text = prefix + Mathf.Abs(difference).ToString();
            dropText.color = effectColor;
            animator.SetTrigger(ANIM_PARAM_DROP_TEXT);
        }

        text.text = numStars.ToString() + "/10";

        cachedNumStars = numStars;
    }
}
