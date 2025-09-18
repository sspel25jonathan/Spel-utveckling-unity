using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FoeBehavior : MonoBehaviour
{

    public GameObject enemy;
    public float enemyhp = 1f;
    public float horizontalMovmet = 0f;
    public float eneymyShootCooldown = 1f;
    public float enemySpeed = 2f;

    public float enemySpawnCooldown = 10;

    private float timeMove = 3;
    public int randomLeftRight = 0;
    float timer;
    

    


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= Time.time)
        {
            //Debug.Log("Code is running");
            randomLeftRight = Random.Range(-1, 2);
            timer = timeMove + Time.time;
        }
        transform.Translate(Vector3.right * enemySpeed* Time.deltaTime * randomLeftRight);
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
                scoreB.instance.scoreAddPoint();
            }
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}
