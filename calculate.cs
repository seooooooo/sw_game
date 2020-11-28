using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calculate : MonoBehaviour
{
    public Text cashtxt;

    public static bool calculate_iceCream = false;
    public static int account;

    private int choice1_cnt;
    private int choice2_cnt;
    private int n1, n2;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (calculate_iceCream)
        {
            n1 = guestRequest.ran;
            n2 = guestRequest.ran2;

            choice1_cnt = cnt_plus.compareOrder[n1];

            if (n2 != -1)
                choice2_cnt = cnt_plus.compareOrder[n2];
            else
                choice2_cnt = -1;

            if (n1 == n2)
            {
                if (guestRequest.compareRequest[n1] == choice1_cnt)
                    account += 1000;
            }
            else 
            {
                if (guestRequest.compareRequest[n1] == choice1_cnt &&
                    guestRequest.compareRequest[n2] == choice2_cnt)
                    account += 1000;
                else if (guestRequest.compareRequest[n1] != choice1_cnt &&
                    guestRequest.compareRequest[n2] != choice2_cnt)
                    account -= 250;
                else
                    account += 500;
            }
            //guestRequest.compareRequest[1] == cnt_plus.compareOrder[1];
            calculate_iceCream = false;
            guestRequest.compareRequest = new int[] { 0, 0, 0, 0, 0, 0, 0, 0 };
        }

        cashtxt.text = "cash : " + account;
    }
}

/*
 * choice1_cnt = cnt_plus.compareOrder[guestRequest.ran];

            if (guestRequest.ran2 != -1)
                choice2_cnt = cnt_plus.compareOrder[guestRequest.ran2];
            else
                choice2_cnt = -1;

            if (choice1_cnt == cnt_plus.compareOrder[guestRequest.ran])
            {
                if (choice2_cnt == cnt_plus.compareOrder[guestRequest.ran2])
                    account += 1000;
                else
                    account -= 250;
            }
            else 
            {
                if (choice2_cnt == cnt_plus.compareOrder[guestRequest.ran2])
                    account += 500;
                else
                    account -= 500;
            }
 */
