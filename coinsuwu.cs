using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsuwu : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Vasya vasya = other.GetComponent<Vasya>();
        vasya.CollectCoins();
        Destroy(gameObject);
    }
}
