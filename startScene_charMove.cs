using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScene_charMove : MonoBehaviour
{
    public Sprite[] NextSprite;
    private SpriteRenderer spriteRenderer;
    private int i = 1;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time > 1.0f)
        {
            changeAction();
            StartCoroutine(WaitForIt());
        }
    }
    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(0.2f);
    }

    void changeAction()
    {
        spriteRenderer.sprite = NextSprite[i];
        time = 0.0f;

        if (i == 1)
            i = 0;
        else
            i = 1;
    }
}

