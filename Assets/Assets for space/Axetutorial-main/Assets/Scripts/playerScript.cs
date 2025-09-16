using System;
using UnityEngine;
using UnityEngine.UI;

public class first : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created


    public float playerspeeed = 5f;

    public GameObject Bullet;
    public float Playerhealth = 3f;
    float minTimer;

    public float cooldown = 2f;
    void Start()
    {
        this.transform.position = new Vector3(0, -1, 0);
        /* wwaaa
         * 
         */

    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerspeeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerspeeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * playerspeeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * playerspeeed * Time.deltaTime);
        }
        
        
        if (Input.GetKey(KeyCode.Space) && minTimer <= Time.time)
        {
            Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.rotation);
            minTimer = Time.time + cooldown;
        }
        //Debug.Log("Time is:" + Time.time + " and CD is: " + minTimer);


        if (transform.position.x <= -11)
        {
            transform.position = new Vector3(10.9f, transform.position.y, 0);
        }
        if (transform.position.x >= 11)
        {
            transform.position = new Vector3(-10.9f, transform.position.y, 0);
        }


        if (transform.position.y < -11)
        {
            transform.position = new Vector3(transform.position.x, 10.9f, 0);
        }
        if (transform.position.y >= 11)
        {
            transform.position = new Vector3(transform.position.x, -10.9f, 0);
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Playerhealth = Playerhealth - 1;
            if (Playerhealth == 0)
            {
                Destroy(gameObject);
            }

        }
        if (collision.gameObject.tag == "Big Enemy")
        {
            Playerhealth = Playerhealth - 2;
            if (Playerhealth == 0)
            {
                Destroy(gameObject);
            }

        }
        
         }

}
