using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 0.01f;
    // Update is called once per frame
    void Start()
    {
        Destroy(gameObject, 3f);    
    }
    void Update()
    {
        transform.Translate(0f, 0f, bulletSpeed);
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();
    //    // 1.
    //    if (playerHealth != null)
    //    {
    //        playerHealth.Die();
    //    }
    //    // 1 2�� ������ ��
    //    // 2.
    //    playerHealth?.Die();
    //    // ?. ������
    //    // (expression)?.~ : expression�� null�� �ƴϸ� ����� ������.
    //    if (other.tag == "Player")
    //    {
    //        other.GetComponent<PlayerHealth>().Die();
    //    }
    //}

    

}
