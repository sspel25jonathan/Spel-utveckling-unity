using UnityEngine;

public class FoeBehavior : MonoBehaviour
{

    public GameObject enemy;
    public float enemyhp = 1f;

    public float eneymyShootCooldown = 1f;
    public float enemySpeed = 2f;

    public float enemyMaxCount = 5;
    public float enemySpawnCooldown = 10;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);

        if (enemyhp == 0)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < -11)
        {
            float randnumspawn = Random.Range(-5, 5);
            transform.position = new Vector2(randnumspawn, 11);
        }



    }
}
