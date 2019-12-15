using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{

    Player player;
    Text myText;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        myText = GameObject.Find("Score").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {

        SetCountText();
    }

    void SetCountText()
    {
        myText.text = "Score : " + player.score.ToString();
    }
}
