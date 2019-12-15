using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MurlocSelector : MonoBehaviour
{
    GameObject murlocSelector;  

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("CursorSelection"))
        {
            murlocSelector = GameObject.Find("CursorSelection");
        };
    }

    // Update is called once per frame
    void Update()
    {
        if (EventSystem.current.currentSelectedGameObject && murlocSelector)
        {
            murlocSelector.transform.position = new Vector2(800, EventSystem.current.currentSelectedGameObject.transform.position.y + 7);
        }

    }
}
