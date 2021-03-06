using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.TryGetComponent(out Enemy enemy))
        {
            Destroy(enemy.gameObject);
        }

        if (other.gameObject.TryGetComponent(out Bonus bonus))
        {
            Destroy(bonus.gameObject);
        }
    }
}
