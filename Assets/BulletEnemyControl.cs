using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyControl : MonoBehaviour
{
    public float bulletEnemySpeed;
    private Rigidbody2D _compRigidbody;

    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(0, bulletEnemySpeed * -1);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EnemiesLimit")
        {
            Destroy(this.gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
