using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class Follow : MonoBehaviour
{
    public Patrol patrol;
    public AIDestinationSetter follow;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, player.position) > 3)
        {
            patrol.enabled = true;
            follow.enabled = false;
        }
        else
        {
            patrol.enabled = false;
            follow.enabled = true;
        }
    }
}
