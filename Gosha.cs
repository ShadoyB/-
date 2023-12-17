using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gosha : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    void Update()
    {
        // Меняет каждый кадр позицию НПС на новую
        transform.position =
            Vector3.MoveTowards(transform.position,
            target.position, speed * Time.deltaTime);

        // Разворачивает каждый кадр НПС к цели
        transform.LookAt(target.position);
    }
    private void OnTriggerEnter(Collider other)
    {
        Vasya player = other.GetComponent<Vasya>();
        player.TakeDamage(playerDamage);
    }
}
