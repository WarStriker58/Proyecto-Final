using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesControl : MonoBehaviour
{
    public GameObject explosionPrefab;
    private Rigidbody2D _compRigidbody;
    public float SpeedY;
    public GameManagerControlSS gameManager;

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
        _compRigidbody.velocity = new Vector2(0, SpeedY);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
            Instantiate(explosionPrefab, transform.position, transform.rotation);
            gameManager.UpdatePoints(100);
        }
        else if (collision.gameObject.tag == "EnemiesLimit")
        {
            Destroy(this.gameObject);
        }
    }
    public void SetGameManager(GameManagerControlSS gm)
    {
        gameManager = gm;
    }
}
