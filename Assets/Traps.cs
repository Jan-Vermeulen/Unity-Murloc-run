using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traps : MonoBehaviour
{
    protected Player player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }
}
