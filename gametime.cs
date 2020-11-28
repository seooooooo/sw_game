using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gametime : MonoBehaviour
{
    private float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if (time >= 80.0f)
        {
            if (calculate.account >= 10000)
            {
                calculate.account = 0;
                icecream_rest.iceCreamrest = new int[8] { 3, 3, 3, 3, 3, 3, 3, 3 };
                guestMoves.go = true;
                SceneManager.LoadScene(2);
            }
            else
            {
                calculate.account = 0;
                icecream_rest.iceCreamrest = new int[8] { 3, 3, 3, 3, 3, 3, 3, 3 };
                guestMoves.go = true;
                SceneManager.LoadScene(3);
            }
        }
    }
}
