﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    public KeyCode fireButton;

    public override void Attack()
    {
        GameObject clone = Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
        Bullet newBullet = clone.GetComponent<Bullet>();
        newBullet.Fire(transform.forward);
    }
}
