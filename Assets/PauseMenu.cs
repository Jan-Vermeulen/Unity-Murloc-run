using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    CanvasGroup panel;
    bool pauseEnabled = false;
    // Start is called before the first frame update
    void Start()
    {
        //panel = GameObject.Find("PauseMenu").GetComponent<CanvasGroup>();
    }

    // Update is called once per frame
    void Update()
    { 
         if(Input.GetKeyDown("escape")){
    
        if (pauseEnabled == true)
        {
            //unpause the game
            Time.timeScale = 1;
            pauseEnabled = false;
            panel.enabled = true;
        }
        //else if game isn't paused, then pause it
        else if (pauseEnabled == false)
        {
            Time.timeScale = 0;
            pauseEnabled = true;
            panel.enabled = false;

            }
        }

    }
}
