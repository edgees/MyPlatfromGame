using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Security;
using Unity.VisualScripting;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody2D rb2d;
    private BoxCollider2D bc2d;
    private Animator anim;
    private SpriteRenderer sprite;
    private AudioSource JumpAudio;

    [SerializeField] private LayerMask jumpableGround;
    [SerializeField] private LayerMask jumpableWall;
    public float lr;
    [SerializeField]public float movespeed = 1f;
    [SerializeField]private float jumpheight = 1f;

    private SpawnPos _spawnpos;
    public float pos;

    private enum playeraction { standing,moving,jumping,falling}
    private playeraction state = playeraction.standing;

    // Start is called before the first frame update
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        JumpAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (rb2d == null) 
        { return; }
        if (bc2d == null) 
        {  return; }
        if (anim == null) 
        { return; }
        if (sprite == null) 
        { return; }

        
        rb2d.velocity = new Vector2(lr * movespeed, rb2d.velocity.y);
        lr = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && onground())
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpheight);
            JumpAudio.Play();
        }

        pos = 0;
        movinganimation();


    }

    private void movinganimation()
    {
        playeraction state;
        if (lr > 0f) 
        {
            state = playeraction.moving;
            sprite.flipX = true;
            pos = 1f;
            
        }
        else if (lr < 0f)
        {
            state = playeraction.moving;
            sprite.flipX = false;
            pos = -1f;
        }
        else
        { state = playeraction.standing; }

        if (rb2d.velocity.y > 0.1f)
        {
            state = playeraction.jumping;
        }
        else if (rb2d.velocity.y < -0.001f)
        {
            state = playeraction.falling;
        }

        anim.SetInteger("state", (int)state);
    }

    private bool onground()
    {
        return Physics2D.BoxCast(bc2d.bounds.center, bc2d.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }

    public void SpawnFeedback(GameObject Feedbacks)
    {

        GameObject.Instantiate(Feedbacks, transform.position, transform.rotation);

    }

}
