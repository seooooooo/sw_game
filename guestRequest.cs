using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guestRequest : MonoBehaviour
{
    public Text order;
    public static bool getOrder = true;
    public static string[] iceCream;
    public static int[] compareRequest;
    public static int ran;
    public static int ran2;

    // Start is called before the first frame update
    void Start()
    {
        iceCream = new string[] { "yogurt", "chocolate", "vanilla", "strawberry", "rice",
            "coffee", "pistachio", "mint chocolate"};
        compareRequest = new int[] { 0,0,0,0,0,0,0,0 };
    }

    // Update is called once per frame
    void Update()
    {
        orderIcecream();
    }

    void orderIcecream()
    {
        int num;
        if (!guestMoves.go && getOrder)
        {
            num = Random.Range(0, 2);
            ran = Random.Range(0, 8);

            if (num == 1)
            {
                ran2 = Random.Range(0, 8);
                order.text = "Can I have a\n" + iceCream[ran] + "\n" + iceCream[ran2] + "\nice cream?";
                compareRequest[ran2]++;
            }
            else
                order.text = "Can I have a\n" + iceCream[ran] + "\nice cream?";

            compareRequest[ran]++;

            getOrder = false;
        }
    }
}
