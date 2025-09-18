using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.Rendering;

public class FoeSpawner : MonoBehaviour
{
    public GameObject foe;

    public float maxSpawns = 5;

    float timer;

    public float foeTimeBetween = 3;
    [Header ("Spawn points")]
    public float minusX = -11;
    public float plusX = 11;
    public float plusS = 0;
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (timer <= Time.time)
        {
            Vector2 spawnLocation = new Vector2(Random.Range(minusX, plusX), 11);
            Instantiate(foe, spawnLocation, transform.rotation);
            timer = Time.time + foeTimeBetween;
        }
    }
}
