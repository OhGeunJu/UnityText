using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerContorller : MonoBehaviour
{
    Rigidbody2D rigid2D;
    Animator animator;
    float jumpForce = 400f;
    public float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;

    void Start()
    {
        Application.targetFrameRate = 60;
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && rigid2D.velocity.y == 0)
        {
            animator.SetTrigger("JumpTrigger");
            rigid2D.AddForce(transform.up * jumpForce);
            // rigid2D.AddForce(new Vector2(0,1) * jumpForce);
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedX = Mathf.Abs(rigid2D.velocity.x);

        if (speedX < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if(rigid2D.velocity.y == 0)
        {
            animator.speed = speedX / 2.0f;
        }
        else
        {
            animator.speed = 1.0f;
        }


        if (transform.position.y < -10)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("ClearScene");
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Cloud") return;

        transform.SetParent(collision.gameObject.transform);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Cloud") return;
        
        transform.SetParent(null);
    }
}