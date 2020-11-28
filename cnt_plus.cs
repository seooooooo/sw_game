using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cnt_plus : MonoBehaviour
{
    public static int cnt = 0;
    public static bool click = true;

    private int clickTag;
    private int myTag;

    public Text txt;
    public Text txt2;

    public static int[] iceCreamcnt = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
    public static int[] compareOrder = new int[8] { 0,0,0,0,0,0,0,0 };

// Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        clickTag = int.Parse(btnMenu.tagNum);
        myTag = int.Parse(this.gameObject.tag);

        if (this.gameObject.tag.Equals(btnMenu.tagNum) && click)
        {
            if (icecream_rest.iceCreamrest[clickTag] <= 0)
               return;
            iceCreamcnt[clickTag]++;
            compareOrder[clickTag]++;
            icecream_rest.iceCreamrest[clickTag]--;
            click = false;
        }
        txt.text = "cnt : " + iceCreamcnt[myTag];
        txt2.text = "rest : " + icecream_rest.iceCreamrest[myTag];
    }
}
