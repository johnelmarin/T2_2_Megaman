using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject Enemy;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        for (int i = 0; i < 5; i++)
        {
            Instantiate(Enemy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-5, rb.velocity.y);
    }
}
