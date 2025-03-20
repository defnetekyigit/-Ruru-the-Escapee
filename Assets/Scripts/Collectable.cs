using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

    [SerializeField] public Boolean isCheese;
    public void CollectThis()
    {
        Destroy(gameObject);
    }
}
