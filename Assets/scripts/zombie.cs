using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie : MonoBehaviour
{
	Transform player;
    Vector2 dir;
    Rigidbody2D rb;
    public float speed = 2f;
    public HealthManager ZombieHp;
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      player = GameObject.Find("Player").transform;  
      ZombieHp=GetComponent<HealthManager>();
      ZombieHp.health=Random.Range(10,100);
    }
    
    void Update()
    {
      if (player) {
        dir = (player.position - transform.position).normalized;
      }
      // destroy zombie if health < 0 :
      if (ZombieHp.health<=0)
      {
        Destroy(gameObject);
      }
    }
    void FixedUpdate()
    {
          rb.velocity = dir * speed;
          float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
          rb.rotation = angle;
    }
    /*
    private void OnCollisionEnter2D(Collision2D other) {
      if(other.gameObject.name=="bullet")
      {
        Destroy(this.gameObject);
      }else{
        Destroy(this.gameObject);
      }
    }
    */
}
