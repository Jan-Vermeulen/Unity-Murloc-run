using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }
    public void OnTrigger()
    {
        if(player && player.speed < player.initialSpeed && !player.isSwiming)
        {
            player.speed = player.initialSpeed;
        }
    }
}
