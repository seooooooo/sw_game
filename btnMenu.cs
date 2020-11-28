using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnMenu : MonoBehaviour
{
    public Canvas makeBtn;
    public Canvas deliveryBtn;

    public static bool orderCanvas_set;
    public static string tagNum;
    public static string tagNum_delivery;

    private bool menu_openClose = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameStart()
    {
        SceneManager.LoadScene(1);
    }
    public void gamerestart()
    {
        SceneManager.LoadScene(0);
    }

    public void gameEnd()
    {
        Application.Quit();
    }

    public void makeIce()
    {
        if (!guestMoves.go)
        {
            makeBtn.gameObject.SetActive(true);         
        }
    }
    public void deliveryIce()
    {
        deliveryBtn.gameObject.SetActive(true);
    }
    public void deliveryIceend()
    {
        deliveryBtn.gameObject.SetActive(false);
    }

    public void finishMakeIce()
    {
        makeBtn.gameObject.SetActive(false);

        guestMoves.guest_orderCanvas.gameObject.SetActive(false);

        guestMoves.i = 1;
        guestMoves.go = true;
        calculate.calculate_iceCream = true;
        guestRequest.getOrder = true;

    }

    public void iceCreamOrder(GameObject target)
    {
        tagNum = target.gameObject.tag;
        cnt_plus.click = true;
    }

    public void iceCreamDelivery(GameObject target)
    {
        tagNum_delivery = target.gameObject.tag;
        delivery_icecream.click = true;
    }

}
