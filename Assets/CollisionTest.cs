using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision) // 충돌과 관련된 정보
    {
        Debug.Log($"[OnCollisionEnter] Me : {gameObject.name}, Other : {collision.gameObject.name}");
    }
    
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log($"[OnCollisionStay] Me : {gameObject.name}, Other : {collision.gameObject.name}");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log($"[OnCollisionExit] Me : {gameObject.name}, Other : {collision.gameObject.name}");
    }

    private void OnTriggerEnter(Collider other) // 충돌된 상대방의 정보
    {
        Debug.Log($"[OnTriggerEnter] Me : {gameObject.name}, Other : {other.name}");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log($"[OnTriggerStay] Me : {gameObject.name}, Other : {other.name}");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log($"[OnTriggerExit] Me : {gameObject.name}, Other : {other.name}");
    }
}
