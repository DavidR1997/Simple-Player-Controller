﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimplePlayerController;

public class Normal : Projectile
{
    public Rigidbody rigid;
    public override void Fire(Vector3 direction)
    {
        base.Fire(direction);
    }
}
