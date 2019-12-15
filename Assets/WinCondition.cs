using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTrigger()
    {
        if (player && player.speed >= player.initialSpeed)
        {
            player.speed = 0;
            player.initialSpeed = 0;
            player.GetComponent<Animator>().SetBool("Dance", true);
        }

    }
}
