using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;
    public TMP_Text prompt;
    public int waiting = 0;

    public int keyPressed = 0;
    
    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        prompt = GetComponent<TMP_Text>();
    }
    
    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);
    }
    
    void Update()
    {
        if(transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        EnemyController e = other.collider.GetComponent<EnemyController>();
        if (e != null)
        {
            
            e.Fix();
        }
    
        Destroy(gameObject);
    }
}