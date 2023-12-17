using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Скорость полёта огненного шара
    public float speed;

    private void Update()
    {
        // Клон огненного шара уничтожается через 3 сек
        Destroy(gameObject, 3);

        // Каждый кадр позиция шара обновляется на произведеие вектора движением вперёд

        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Gosha gosha = other.GetComponent<Gosha>();
        Destroy(gosha.gameObject);

        Destroy(gameObject);
    }
}
