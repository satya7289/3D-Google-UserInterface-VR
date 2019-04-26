using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PraiseHtml;
using UnityEngine.UI;
using System.Net.Http;
using TMPro;
using System.Web;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using Microsoft.CSharp;



public class Test : MonoBehaviour
{
  /*  public GameObject firstPage = null;
    public GameObject secondPage = null;
    public GameObject thirdPage = null;

    private GameObject temp1, temp2, temp3;

    private Transform _transform;
    private TextMeshProUGUI text1, text2, text3;
    */
   // public Class1 x = new Class1();
    void Start()
    {
        string cx = "000758091533793376942:vei8xgbnvio";
        string key = "AIzaSyBy84tCaoDdsWp1OtzeObhxGpTYku0FwJ4";
        string search = "google";
        var url = ("https://www.googleapis.com/customsearch/v1?key=" + key + "&cx=" + cx + "&q=" + search);
        var request = WebRequest.Create(url);
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        Stream dataStream = response.GetResponseStream();
        StreamReader reader = new StreamReader(dataStream);
        string responseString = reader.ReadToEnd();
        dynamic jsonData = JsonConvert.DeserializeObject(responseString);
        foreach(var x in jsonData.items)
        {
            Debug.Log(x.link);
        }
            //   var httpClient = new HttpClient();
            //  var html = httpClient.GetStringAsync(y);
            // Debug.Log(html.Result);

            /*  temp1 = secondPage.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
              text1 = temp1.GetComponent<TextMeshProUGUI>();

              temp2 = thirdPage.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
              text2 = temp2.GetComponent<TextMeshProUGUI>();

              temp3 = thirdPage.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
              text3 = temp3.GetComponent<TextMeshProUGUI>();

              Debug.Log("dfnvcjhjh");

              foreach (var url in x.Urls)
                {
                   Debug.Log("dfn");
                     Debug.Log(url);
                  }
                  foreach (var u in x.Description)
                 {
                      Debug.Log(u);
                  }
                  */



        }
 }

