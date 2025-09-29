using UnityEngine;

public class HealthScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    


    public float Playerhealth = 3f;
    public SpriteRenderer PlayerSp;
    public first PlayerScript;

    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Playerhealth = Playerhealth - 1;
            if (Playerhealth == 0)
            {
                PlayerSp.enabled = false;
                PlayerScript.enabled = false;
            }

        }
        if (collision.gameObject.tag == "Big Enemy")
        {
            Playerhealth = Playerhealth - 2;
            if (Playerhealth == 0)
            {
                PlayerSp.enabled = false;
                PlayerScript.enabled = false;
            }

        }

    }
    
}
