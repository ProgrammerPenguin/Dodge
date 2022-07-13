using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    private float _elapsedTime;
    public GameObject BulletPrefab;
    public Transform Player;
    public float minNum = 0.5f;
    public float maxNum = 3f; 
    private float _radNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _elapsedTime += Time.deltaTime;
        if (_elapsedTime >= _radNum)
        {
            _elapsedTime = 0;
            // Vector3 spawnPosition = transform.position + new Vector3(0f, 0f, 2f);
            GameObject bullet = Instantiate(BulletPrefab, transform);
            bullet.transform.LookAt(Player);
            _radNum = Random.Range(minNum, maxNum);
        }



        if (Input.GetKeyDown(KeyCode.R))
        {
            Time.timeScale = 0.5f;
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            Time.timeScale = 1;
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            Time.timeScale = 10;
        }
    }
}
