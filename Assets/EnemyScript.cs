using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rb;
    [SerializeField]
    Transform player;
    Vector2 dir;
    [SerializeField]
    float speed;
    [HideInInspector]
    public float currentHealth;
    [SerializeField]
    float maxHealth;
    private void Start()
    {
        currentHealth = maxHealth;
        player = GameObject.FindObjectOfType<PlayerControl> ().transform;
    }
    void Update()
    {
        dir = player.position - transform.position;
        transform.up = dir;
        if (currentHealth <= 0)
        {
            Destroy(gameObject); //lowercase g attacks the current game object
        }
    }
    

    private void FixedUpdate()
    {
        rb.velocity = dir * speed;   
    }
}