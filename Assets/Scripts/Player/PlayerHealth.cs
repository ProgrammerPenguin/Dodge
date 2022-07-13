using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int life = 5;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            --life;
            if (life == 0)
            {
                Die();
            }
        }
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Bullet")
    //    {
    //        Die();
    //    }
    //}

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.GetComponent<Bullet>() == null)
    //    {
    //        Die(); //other¿∫ bullet¿Ã æ∆¥‘
    //    }
    //}
    public void Die()
    {
        gameObject.SetActive(false);


        FindObjectOfType<GameManager>().End();
    }
}
