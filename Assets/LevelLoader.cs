using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    LevelButton levelButton;

    public void LoadScene(string level)
    {
        if(level == "Quit")
        {
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene(level, LoadSceneMode.Single);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        levelButton = GetComponentInChildren<LevelButton>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Submit") && EventSystem.current.currentSelectedGameObject)
            {
                LoadScene(EventSystem.current.currentSelectedGameObject.name);
            }

        if (Input.GetButton("Cancel") && EventSystem.current.currentSelectedGameObject)
        {
            LoadScene("Menu");
        }

    }
}
