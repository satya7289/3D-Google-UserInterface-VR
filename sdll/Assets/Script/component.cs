using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Net.Http;

public class component : MonoBehaviour
{
   
    //TextMeshProUGUI textpro;
    //Text text;
    public GameObject firstchild;
    public GameObject secondchild;
    public GameObject text,text2,pro,buton;
    public Transform m;
    private Button b;
    private TextMeshProUGUI t;
   // public GameObject canvas;
 
   
    // Start is called before the first frame update
    void Start()
    {
        
        Debug.Log("dhcv");
        var y = ("https://www.google.com/search?q=fb");
          var httpClient = new HttpClient();
           var html = httpClient.GetAsync(y);
          Debug.Log(html.Result);
        //Application.OpenURL("https://www.google.com/search?q=fb");
        //firstchild = transform.GetChild(0).gameObject;
        // m = this.transform.GetChild(0);

        //   firstchild = m.gameObject;
        // secondchild = firstchild.transform.Find("secondChild").gameObject;
        //  text = secondchild.transform.Find("Canvas/Text").gameObject;
        //  text2 = secondchild.transform.Find("Canvas/Text2").gameObject;
        //  pro = secondchild.transform.Find("Canvas/TextMeshPro").gameObject;
        //   buton = secondchild.transform.Find("Canvas/Button").gameObject;
        // b = buton.GetComponent<Button>();
        //  text.GetComponent<Text>().text = "Your Tcxvdcxbcgnext";
        //  text2.GetComponent<Text>().text = "fb";
        // t = pro.GetComponent<TextMeshProUGUI>();
        // t.text = "dskbuhvbbh";



        //  m = this.transform.GetChild(1);
        //  canvas = m.gameObject;

        // text2.GetComponent<TextMeshPro>().text = "dkc sc";







    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
