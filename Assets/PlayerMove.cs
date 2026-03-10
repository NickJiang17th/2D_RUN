using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    [SerializeField]private float moveSpeed;
    [SerializeField]private float jumpSpeed;
    private float MoveController;
    private bool jumpController;

    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveController=Input.GetAxisRaw("Horizontal");
        rb.velocity=new Vector2(moveSpeed*MoveController,rb.velocity.y);
        Debug.Log(MoveController);
        //if(Input.GetKey(KeyCode.D))
        //    rb.velocity=new Vector2(moveSpeed,rb.velocity.y);
        //if(Input.GetKey(KeyCode.A))
        //    rb.velocity=new Vector2(-moveSpeed,rb.velocity.y);
        //if(Input.GetKey(KeyCode.Space))
        if(Input.GetButtonDown("Jump"))
            rb.velocity=new Vector2(rb.velocity.x,jumpSpeed);
    }
}
