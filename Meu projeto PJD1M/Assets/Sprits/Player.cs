using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade = 10f;
    public float focapulo = 10f;

      public bool noChao = false;
      
      private Rigidbody2D _rigidbody2D
      private SpriteRenderer SpriteRenderer;
      
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = 
            gameObject.GetComponent<Rigidbody2D>();
        SpriteRenderer = 
            gameObject.GetComponent<SpriteRenderer>();
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chao")
        {
            noChao = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
    }
}
