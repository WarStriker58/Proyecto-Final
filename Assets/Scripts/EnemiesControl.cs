using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesControl : MonoBehaviour
{
    public GameObject explosionPrefab;
    private Rigidbody2D _compRigidbody;
    public float SpeedY;
    public GameManagerControlSS gameManager;
    public GameObject bulletEnemyPrefab;
    public float spawnInterval = 1.0f;
    private AudioSource explosionSound;

    void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
        explosionSound = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemyBullet", spawnInterval);
    }

    void SpawnEnemyBullet()
    {
        Instantiate(bulletEnemyPrefab, transform.position, bulletEnemyPrefab.transform.rotation);
        Invoke("SpawnEnemyBullet", spawnInterval);
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
            explosionSound.Play();
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
