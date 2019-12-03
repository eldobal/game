using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{

    public float timer = 0.0f;
    public float Maxtime = 2.0f;
    public GameObject prefab;
    private GameObject[] gameObjects;
    

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    private void Update()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Pick Up");
        if (gameObjects.Length == 0) {
            timer += Time.deltaTime;
        }
        if (timer >= Maxtime) {
            Instantiate(prefab);
            timer = 0.0f;
        }

    }




}
