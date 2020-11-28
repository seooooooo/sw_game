using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guestMove : MonoBehaviour
{
    public GameObject[] guest;
    public Sprite[] guest1Sprite;
    public Canvas orderCanvas;

    private SpriteRenderer spriteRenderer;

    private int num;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        
        num = Random.Range(0, 3);
        
        //spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer = guest[num].gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = guest1Sprite[num];
        Instantiate(guest[num]);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 5.0f)
        {
            if (!GameObject.FindGameObjectWithTag("guest"))
            {
                num = Random.Range(0, 3);
                spriteRenderer = guest[num].gameObject.GetComponent<SpriteRenderer>();
                spriteRenderer.sprite = guest1Sprite[num];
                Instantiate(guest[num]);
            }

            time = 0.0f;
        }
    }



}
