﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Profile : MonoBehaviour
{
    public void appear()
    {
        this.gameObject.SetActive(true);
    }

    public void disappear()
    {
        this.gameObject.SetActive(false);
    }
}
