using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 2, 0, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        other.GetComponent<Player>().score += 10;

    }
}
