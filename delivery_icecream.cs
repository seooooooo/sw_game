using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class delivery_icecream : MonoBehaviour
{
    public static bool click = true;

    private int clickTag;
    private int myTag;

    public Text txt;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        clickTag = int.Parse(btnMenu.tagNum_delivery);
        myTag = int.Parse(this.gameObject.tag);

        if (this.gameObject.tag.Equals(btnMenu.tagNum_delivery) && click)
        {
            icecream_rest.iceCreamrest[clickTag]++;
            calculate.account -= 100;
            click = false;
        }
        txt.text = "rest : " + icecream_rest.iceCreamrest[myTag];
    }
}
