using UnityEngine;

public class TrainingExerciseExecutor : MonoBehaviour
{
    public bool Succeeded { get; private set; }
    public bool Failed { get; private set; }

    [SerializeField]
    private ProgressBar progressBar;

    private TrainingExercise exercise;
    private float startTime;
    private float timeProgress;

    public void ExecuteExercise(TrainingExercise exercise)
    {
        this.exercise = exercise;
        startTime = Time.time;
        Failed = false;
        Succeeded = false;
    }

    private void Update()
    {
        if (Failed || Succeeded || exercise == null)
        {
            return;
        }

        timeProgress = Time.time - startTime;
        if (timeProgress > exercise.Duration)
        {
            Failed = true;
        }
        else if (Input.GetKeyDown(exercise.InteractionKey))
        {
            Succeeded = true;
        }

        progressBar.SetCompletion(1 - Mathf.Max(0, timeProgress / exercise.Duration));
    }
}
