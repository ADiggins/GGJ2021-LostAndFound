using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllTasksCompletedListener : MonoBehaviour
{

    [SerializeField]
    private StarTracker playerTracker;

    [SerializeField]
    private StarTracker borisTracker;

    [SerializeField]
    private StarTracker edwinaTracker;

    [SerializeField]
    private StarTracker dizzyTracker;

    [SerializeField]
    private int playerStarVictoryCount;

    [SerializeField]
    private int borisStarVictoryCount;

    [SerializeField]
    private int edwinaStarVictoryCount;

    [SerializeField]
    private int dizzyStarVictoryCount;


    private void Start()
    {

    }

	void Update()
	{
		CheckForVictory(0);
	}

    private void CheckForVictory(int ignored)
    {
        if (
            (int)playerTracker.currentStars == playerStarVictoryCount &&
            (int)borisTracker.currentStars <= borisStarVictoryCount &&
            (int)edwinaTracker.currentStars <= edwinaStarVictoryCount &&
            (int)dizzyTracker.currentStars <= dizzyStarVictoryCount
        )
        {
            DoVictory();
        }
    }

    private void DoVictory()
    {
        Debug.Log("All tasks completed");
    }

}
