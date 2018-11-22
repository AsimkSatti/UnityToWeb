using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckOut : MonoBehaviour {

    public CartAdder myCart;
	// Use this for initialization
    public void onSubmit() { 


        string url = "http://myWebSite.com";
        string mydata="HereGoesMyData"

        string newurl=url+"#"+mydata

        Application.OpenURL(newurl);

    }

	void Start () {
         
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
