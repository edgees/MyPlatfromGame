using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGraphic : enemymovement
{

    float etp = 1f;
    float ptp = 1f;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null)
            player = GameObject.FindWithTag("Player").transform;

        etp = transform.position.x;
        ptp = player.transform.position.x;
        if (etp < ptp)
        { spriteRenderer.flipX = false; }
        else if (etp > ptp)
        { spriteRenderer.flipX = true; }
    }
}
