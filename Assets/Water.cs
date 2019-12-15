using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    Player player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            player.Swim();
            player.isSwiming = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Player>())
        {
            player.isSwiming = false;
        }
    }

}
