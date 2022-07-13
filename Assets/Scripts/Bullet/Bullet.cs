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
    //    // 1 2가 동일한 식
    //    // 2.
    //    playerHealth?.Die();
    //    // ?. 연산자
    //    // (expression)?.~ : expression이 null이 아니면 멤버에 접근함.
    //    if (other.tag == "Player")
    //    {
    //        other.GetComponent<PlayerHealth>().Die();
    //    }
    //}

    

}
