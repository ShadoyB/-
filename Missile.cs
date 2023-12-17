using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // �������� ����� ��������� ����
    public float speed;

    private void Update()
    {
        // ���� ��������� ���� ������������ ����� 3 ���
        Destroy(gameObject, 3);

        // ������ ���� ������� ���� ����������� �� ����������� ������� ��������� �����

        transform.position += transform.forward * speed * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Gosha gosha = other.GetComponent<Gosha>();
        Destroy(gosha.gameObject);

        Destroy(gameObject);
    }
}
