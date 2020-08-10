﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelePortation : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject thePlayer;

    void OnTriggerEnter(Collider other)
    {
        thePlayer.transform.position = teleportTarget.transform.position;
    }
}
