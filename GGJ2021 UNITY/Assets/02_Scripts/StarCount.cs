using UnityEngine;

[CreateAssetMenu(menuName = "Skunky/StarCount", fileName = "StarCount")]
public class StarCount : ScriptableObject
{
    private static readonly int MAX_STARS = 10;

    public int NumStars { get; private set; }

    [SerializeField]
    private int startingStars;

    private void OnEnable()
    {
        NumStars = startingStars;
    }

    public void AddStar()
    {
        if (NumStars == MAX_STARS)
        {
            Debug.Log("Tried to set star count to greater than maximum");
        }
        else
        {
            NumStars++;
        }
    }
}
