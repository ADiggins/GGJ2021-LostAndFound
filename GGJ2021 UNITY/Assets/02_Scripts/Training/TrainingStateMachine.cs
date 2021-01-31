using UnityEngine;
using System.Collections;
using TMPro;

[RequireComponent(typeof(TrainingExerciseExecutor))]
public class TrainingStateMachine : MonoBehaviour
{
    [SerializeField]
    private CompletedTask task;

    [SerializeField]
    private TrainingExercise[] exercises;

    [SerializeField]
    private TMP_Text text;

    [SerializeField]
    private StarTracker playerStarTracker;

    private TrainingExerciseExecutor executor;

    private int currentExerciseIndex = 0;
    private TrainingExercise currentExercise;
    private bool inProgress;

    private Coroutine currentDialougeRoutine;

    //Quest Marker GameObject
    public GameObject Marker;

    private void Awake()
    {
        Initialise();
        executor = GetComponent<TrainingExerciseExecutor>();
    }

    private void Initialise()
    {
        inProgress = false;
    }

    public void StartTraining()
    {
        if (!task.Completed)
        {
            inProgress = true;
            currentExerciseIndex = 0;
            NextInteraction();
        }
    }

    private void Update()
    {
        if (!inProgress)
        {
            return;
        }

        if (executor.Succeeded)
        {
            currentExerciseIndex++;
            if (currentExerciseIndex >= exercises.Length)
            {
                CompleteTraining();
            }
            else
            {
                NextInteraction();
            }
        }

        if (executor.Failed)
        {
            FailTraining();
        }
    }

    private void CompleteTraining()
    {
        if (currentDialougeRoutine != null)
        {
            StopCoroutine(currentDialougeRoutine);
        }
        currentDialougeRoutine = StartCoroutine(PopulateDialogue("Well done little skunk! Here is your star"));
        inProgress = false;
        playerStarTracker.AddStars();
        Marker.GetComponent<Quest_Marker>().disappear();
        task.Completed = true;
    }

    private void NextInteraction()
    {
        currentExercise = exercises[currentExerciseIndex];
        executor.ExecuteExercise(currentExercise);
        if (currentDialougeRoutine != null)
        {
            StopCoroutine(currentDialougeRoutine);
        }
        currentDialougeRoutine = StartCoroutine(PopulateDialogue(currentExercise.PromptText));
    }


    private IEnumerator PopulateDialogue(string promptText)
    {
        var promptTextBuilder = "";
        foreach (var character in promptText.ToCharArray())
        {
            promptTextBuilder += character;
            text.text = promptTextBuilder;
            yield return new WaitForFixedUpdate();
        }
    }

    private void FailTraining()
    {
        Initialise();
        if (currentDialougeRoutine != null)
        {
            StopCoroutine(currentDialougeRoutine);
        }
        currentDialougeRoutine = StartCoroutine(PopulateDialogue("Wrong, wrong, wrong, do you want to try again?"));
    }
}
