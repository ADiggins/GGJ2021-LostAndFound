using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    private bool open = false;
    public GameObject pauseMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (open)
            {
                Application.Quit();
            }
            else
            {
                open = true;
                pauseMenu.SetActive(true);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && open)
        {
            open = false;
            pauseMenu.SetActive(false);
        }
    }

}
