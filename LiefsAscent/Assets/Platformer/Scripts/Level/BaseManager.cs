﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseManager : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<OpenPartySelection>().resetParty();
    }
}
