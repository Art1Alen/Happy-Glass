using UnityEngine;

public class GlassLine : MonoBehaviour
{
    public int hitCount;
    manager manager;

    void Start()
    {
        manager = FindObjectOfType<manager>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Water")
        {
            collision.tag = "WaterInGlass";
            collision.GetComponent<Rigidbody2D>().gravityScale = .3f;
            collision.GetComponent<Rigidbody2D>().velocity =
            collision.GetComponent<Rigidbody2D>().velocity / 4;
            hitCount++;
            if (hitCount > 60)
            {
                GetComponentInParent<Glass>().ChnageSpriteToHappy();
                if (manager == null) return;               
                    manager.gameCleared = true;
                
                if (hitCount > 80)
                {                 
                    manager.starCount = 3;
                }

                else if(hitCount > 70)
                {                 
                    manager.starCount = 2;
                }

                else
                {
                    manager.starCount = 1;
                }

            }
            else
            {
                GetComponentInParent<Glass>().ChnageSpriteToSad();
                if (manager == null) return;
                
                    manager.gameCleared = false;
                            
            }
        }
    }
}
