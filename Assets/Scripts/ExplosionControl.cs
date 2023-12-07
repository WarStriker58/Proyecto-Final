using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionControl : MonoBehaviour
{
    private Animator _compAnimator;
    public float TimeToDestroy;
    void Awake()
    {
        _compAnimator = GetComponent<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyObject", TimeToDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DestroyObject()
    {
        Destroy(this.gameObject);
    }
}
