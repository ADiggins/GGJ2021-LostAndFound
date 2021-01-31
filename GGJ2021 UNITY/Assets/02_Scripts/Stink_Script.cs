using UnityEngine;

public class Stink_Script : MonoBehaviour
{
    //Define Variables
    public Animation Stink_anim;
    public AudioSource Stink_sound;
    public GameObject Marker;
    public CompletedTask task;

    //Public Function for triggering sound effects and animation.
    public void triggerStink()
    {
        if (!task.Completed)
        {
            //Stink_anim = GetComponent<Animation>();
            //if (Stink_anim != null)
            //{
            //    foreach (AnimationState state in Stink_anim)
            //    {
            //        state.speed = 1f;
            //    }
            //}

            if (Stink_sound != null)
            {
                Stink_sound.Play();
            }

            //Add charm for successful action
            GetComponent<StarTracker>().LoseStars();

            Marker.GetComponent<Quest_Marker>().disappear();
            task.Completed = true;
        }
    }
}
