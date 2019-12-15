using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    Player player;
    NavMeshAgent agent;
    Animator animator;

    private Vector3 previousPosition;
    float currentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 currentMove = transform.position - previousPosition;
        currentSpeed = currentMove.magnitude / Time.deltaTime;
        previousPosition = transform.position;
        animator.SetFloat("Speed", currentSpeed);
    }
    public void OnTrigger()
    {
        if(player && player.speed >= player.initialSpeed)
        {
            player.speed /= 2;
        }

    }

}
