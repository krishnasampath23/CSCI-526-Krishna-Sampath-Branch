using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{   
    public float bulletSpeed = 15f;
    public float bulletDamage = 10f;
    public Rigidbody2D rb;

    private void FixedUpdate(){
        //rb.velocity = Vector2.right * bulletSpeed;
        rb.velocity = Vector2.down * bulletSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("person")){
            // Debug.Log("Hello");
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("goodPerson"))
        {
            // Debug.Log("Hello");
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("enemyFire"))
        {
            // Debug.Log("Hello");
            //Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.CompareTag("ground"))
        {
            // Debug.Log("Hello");
            Destroy(this.gameObject);
        }

    }
}
