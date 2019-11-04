﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcFollow : MonoBehaviour
{
    GameObject ThePlayer;
    public float TargetDistance;
    public float AllowedDistance = 0;
    public GameObject TheNPC;
    public float FollowSpeed;
    public RaycastHit Shot;
    //public bool aggression = false;

    // Update is called once per frame

    private void Start()
    {
        ThePlayer = GameObject.FindWithTag("player");
    }
    void Update()
    {
        transform.LookAt(ThePlayer.transform);
        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out Shot))
        {
            TargetDistance = Shot.distance;
            if(TargetDistance <= AllowedDistance /*&& aggression == true*/)
            {
                FollowSpeed = 0.1f;
                transform.position = Vector3.MoveTowards(transform.position, ThePlayer.transform.position, FollowSpeed);

            }
            else
            {
                FollowSpeed = 0;
            }
        }
    }
}
