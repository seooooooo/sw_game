using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guestMoves : MonoBehaviour
{
    public Sprite[] NextSprite;
    public Canvas orderCanvas;

    public static Canvas guest_orderCanvas;
    public static int i = 1;
    public static bool go = true;

    private float time;
    private SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (go)
            transform.position += Vector3.left * 1.5f * Time.deltaTime;

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

        if (!go)
            return;

        if (i == 1)
            i = 0;
        else
            i = 1;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("iceCream"))
        {
            go = false;
            orderCanvas.gameObject.SetActive(true);

            guest_orderCanvas = orderCanvas;
        }

        if (collision.gameObject.tag.Equals("endspot"))
        {
            Destroy(this.gameObject);
        }
    }
}
