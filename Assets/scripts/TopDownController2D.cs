using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController2D : MonoBehaviour
{
  public float moveSpeed = 3f; 
    Rigidbody2D rb2d;
    Vector2 movement;
    Vector2 mousePos;
    public GameObject zombiePrefab;
    public HealthManager playerHp;
    //testing an array of int XD
    //int[] tab={1,2,2,4};
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        InvokeRepeating("Spawn", .5f, 2);
        playerHp=GetComponent<HealthManager>();
        // testing the for loop for fun XD 
        /*
        for (int i = 0; i < tab.Length; i++)
        {
            Debug.Log("order of "+i+" is : "+tab[i]);
        }
        */
    }
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = Camera.main.ScreenPointToRay(Input.mousePosition).origin;
        // destroy player if health < 0 :
        if (playerHp.health<=0)
        {
         Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        rb2d.MovePosition(rb2d.position + movement * moveSpeed * Time.fixedDeltaTime);
                
        //Vector Math stuff ...
        Vector2 lookDir = mousePos - rb2d.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb2d.rotation = angle;
    }
    Vector3 RandomCircle ( Vector3 center ,   float radius  )
    {
     float ang = Random.value * 360;
     Vector3 pos;
     pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
     pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
     pos.z = center.z;
     return pos;
    }
    void Spawn()
    {
        Vector2 position = RandomCircle(Vector3.zero, 20);
        Instantiate(zombiePrefab, position, Quaternion.identity);
    }
}
