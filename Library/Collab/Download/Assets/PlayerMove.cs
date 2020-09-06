using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public Text status;
    public int count;
    public int get_coin;


    // Start is called before the first frame update
    void Start()
    {
        
         status = gameObject.GetComponentInChildren<Text>();
         count = 5;
        get_coin = 0;
      

    }

    // Update is called once per frame
    void Update()
    {
        if (count == 0)
        {
            status.text = "Hurray! :D";
        }
        else
        {
            status.text = "you get " + get_coin + "coin";
            status.text = count + " more to go!";
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            count--;
            get_coin++;
        }
    }
}
