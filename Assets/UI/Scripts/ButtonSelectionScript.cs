using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonSelectionScript : MonoBehaviour, ISelectHandler, IDeselectHandler {

    Button btn;
    Text txt;

public void OnSelect(BaseEventData eventData)
{
        if (txt != null)
        {
            txt.fontSize = 150;
            txt.color = new Color32(255, 255, 255, 255);
        }
    }

public void OnDeselect(BaseEventData eventData)
{
    if (txt != null)
    {
            txt.fontSize = 128;
            txt.color = new Color32(119, 119, 119, 255);
    }
}

    private void Start()
    {
        btn = GetComponent<Button>();
        txt = btn.GetComponentInChildren<Text>();
    }

}
