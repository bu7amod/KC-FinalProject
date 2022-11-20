using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class idk : MonoBehaviour
{


    bool facingright = true;
    SpriteRenderer sprite;

    Animator animation;


    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();


        sprite = GetComponent<SpriteRenderer>(); 
    }


    // Update is called once per frame
    void Update()
    {
        player();
        Flip();
    }

    void Flip()
    {
         if (facingright == true && Input.GetKeyDown(KeyCode.A))
         {
            sprite.flipX = true;
            facingright = false;
         }
         else if (facingright == false && Input.GetKeyDown(KeyCode.D))
         {
            sprite.flipX = false;
            facingright = true;
         } 
    }
    void player()
    {
        float speed = Input.GetAxis("Horizontal");

        animation.SetFloat("speed", Mathf.Abs(speed));
    }


}
