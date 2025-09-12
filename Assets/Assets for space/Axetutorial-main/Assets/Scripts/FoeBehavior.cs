using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class FoeBehavior : MonoBehaviour
{

    public GameObject enemy;
    public float enemyhp = 1f;
    public float horizontalMovmet = 1f;
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

        float randomLeftRight = Random.Range(0, 1);
        if (randomLeftRight == 1)
        {
            transform.Translate(Vector3.left * horizontalMovmet  * Time.deltaTime * 3);
        }
        else if (randomLeftRight == 0)
        {
             transform.Translate(Vector3.right * horizontalMovmet * Time.deltaTime * 3);
        }

        transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);

        if (transform.position.y < -11)
        {
            float randnumspawn = Random.Range(-5, 5);
            transform.position = new Vector2(randnumspawn, 11);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player Bullet")
        {
            enemyhp = enemyhp - 1;
            if (enemyhp == 0)
            {
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}
