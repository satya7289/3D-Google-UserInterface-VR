using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using PraiseHtml;
using UnityEngine.UI;
using System.Net.Http;
using TMPro;
using HtmlAgilityPack;
using SpraiseHtml;


public class MainScript : MonoBehaviour
{
    public GameObject firstPage = null;
    public GameObject secondPage = null;
    public GameObject thirdPage = null;
    public GameObject inputField = null;
    public GameObject NextPage = null;

    private GameObject temp1, temp2, temp3,inputTextTemp;
    private Transform _transform;
    private TextMeshProUGUI text1, text2, text3;
    private InputField input;


    public string NextIndex = "";
    public string SearchTerm = "google";


    public Class1 SpraiseHtmlDll = new Class1();

    public class Result { public string title { get; set; } public string link { get; set; } public string snippet { get; set; } }

    public void SearchUrl()
    {
        inputTextTemp = inputField.transform.GetChild(0).gameObject;
        input = inputTextTemp.GetComponent<InputField>();
        var search = input.text;
        Debug.Log(search);

        var results = SpraiseHtmlDll.Search(search);
        SearchTerm = SpraiseHtmlDll.search_terms;
        NextIndex = SpraiseHtmlDll.next_index;
        Debug.Log(NextIndex +"search"+ SearchTerm);
             int i = 0;
             int FirstChildIndex = 0;
             int SecondChildIndex = 0;
             int ThirdChildIndex = 0;

             foreach (var result in results)
             {

                 //Debug.Log(url);
                 if (i <= 2)
                 {

                    Debug.Log(i + "2nd");
                    temp2 = secondPage.transform.GetChild(SecondChildIndex).gameObject;
                    temp2.SetActive(true);
                    temp2 =temp2.transform.GetChild(0).gameObject;
                    text2 = temp2.GetComponent<TextMeshProUGUI>();
                    text2.text = result.title;
                    text2.text = text2.text + "\n" + result.link;
                    text2.text = text2.text + "\n" + result.snippet;
                    SecondChildIndex++;

                 }

                 if (i >= 3 && i <= 5)
                 {
                    Debug.Log(i + "1nd");
                    temp1 = firstPage.transform.GetChild(FirstChildIndex).gameObject;
                    temp1.SetActive(true);
                    temp1 =temp1.transform.GetChild(0).gameObject;
                    text1 = temp1.GetComponent<TextMeshProUGUI>();
                    text1.text = result.title;
                    text1.text = text1.text + "\n" + result.link;
                    text1.text = text1.text + "\n" + result.snippet;
                    FirstChildIndex++;

                 }
                 if (i >= 6 && i <= 8)
                 {

                     Debug.Log(i + "3nd");
                    temp3 = thirdPage.transform.GetChild(ThirdChildIndex).gameObject;
                    temp3.SetActive(true);
                    temp3 = temp3.transform.GetChild(0).gameObject;
                    text3 = temp3.GetComponent<TextMeshProUGUI>();
                    text3.text = result.title;
                    text3.text = text3.text + "\n" + result.link;
                    text3.text = text3.text + "\n" + result.snippet;
                    ThirdChildIndex++;

                 }
                 i++;
             }

        NextPage.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void SearchNextPage()
    {
        
        Debug.Log(NextIndex + "and" + SearchTerm);
     
        var results = SpraiseHtmlDll.nextPage(SearchTerm, NextIndex);
        SearchTerm = SpraiseHtmlDll.search_terms;
        NextIndex = SpraiseHtmlDll.next_index;
        Debug.Log(NextIndex + "and2" + SearchTerm);

        int i = 0;
        int FirstChildIndex = 0;
        int SecondChildIndex = 0;
        int ThirdChildIndex = 0;

        foreach (var result in results)
        {

            //Debug.Log(url);
            if (i <= 2)
            {

                Debug.Log(i + "2nd");
                temp2 = secondPage.transform.GetChild(SecondChildIndex).gameObject;
                temp2.SetActive(true);
                temp2 = temp2.transform.GetChild(0).gameObject;
                text2 = temp2.GetComponent<TextMeshProUGUI>();
                text2.text = result.title;
                text2.text = text2.text + "\n" + result.link;
                text2.text = text2.text + "\n" + result.snippet;
                SecondChildIndex++;

            }

            if (i >= 3 && i <= 5)
            {
                Debug.Log(i + "1nd");
                temp1 = firstPage.transform.GetChild(FirstChildIndex).gameObject;
                temp1.SetActive(true);
                temp1 = temp1.transform.GetChild(0).gameObject;
                text1 = temp1.GetComponent<TextMeshProUGUI>();
                text1.text = result.title;
                text1.text = text1.text + "\n" + result.link;
                text1.text = text1.text + "\n" + result.snippet;
                FirstChildIndex++;

            }
            if (i >= 6 && i <= 8)
            {

                Debug.Log(i + "3nd");
                temp3 = thirdPage.transform.GetChild(ThirdChildIndex).gameObject;
                temp3.SetActive(true);
                temp3 = temp3.transform.GetChild(0).gameObject;
                text3 = temp3.GetComponent<TextMeshProUGUI>();
                text3.text = result.title;
                text3.text = text3.text + "\n" + result.link;
                text3.text = text3.text + "\n" + result.snippet;
                ThirdChildIndex++;

            }
            i++;
        }
    }



    public void AllLinks()
    {
        var url= "https://docs.unity3d.com/ScriptReference/UI.Button-onClick.html";

        HtmlWeb web = new HtmlWeb();

        var htmlDoc = web.Load(url);

        var node = htmlDoc.DocumentNode.Descendants("a");
        foreach (var n in node)
            //Console.WriteLine(n.Attributes["href"].Value);	
            Debug.Log(n.OuterHtml);
    }

/*   private void Assign()
      {
          /*  int urlCount, descriptionCount;
          urlCount = link.Count;
          descriptionCount = title.Count;
          urlCount = x.Urls.Count;
           descriptionCount = x.Urls.Count;
           Debug.Log(urlCount + " " + descriptionCount);

           int urlPerPage = urlCount / 3;
           int descriptionPerPage = descriptionCount / 3;
           

            int resultCount = results.Count;

             int i = 0;
      
             int FirstChildIndex = 0;
             int SecondChildIndex = 0;
             int ThirdChildIndex = 0;

             foreach (var result in results)
             {

                 //Debug.Log(url);
                 if (i <= 2)
                 {
 
                     Debug.Log(i + "2nd");
                     temp2 = secondPage.transform.GetChild(SecondChildIndex).gameObject.transform.GetChild(0).gameObject;
                     text2 = temp2.GetComponent<TextMeshProUGUI>();
                     text2.text = result.Title;
                     text2.text = text2.text + "\n" + result.Link;
                     SecondChildIndex++;
               
                 }

                 if (i >=3 && i<=5)
                 {
                    Debug.Log(i + "1nd");
                    temp1 = firstPage.transform.GetChild(FirstChildIndex).gameObject.transform.GetChild(0).gameObject;
                    text1 = temp1.GetComponent<TextMeshProUGUI>();
                    text1.text = result.Title;
                    text1.text = text1.text + "\n" + result.Link;
                    FirstChildIndex++;

                 }
                if (i >= 6 && i <= 8)
                {

                    Debug.Log(i + "3nd");
                    temp3 = thirdPage.transform.GetChild(ThirdChildIndex).gameObject.transform.GetChild(0).gameObject;
                    text3 = temp3.GetComponent<TextMeshProUGUI>();
                    text3.text = result.Title;
                    text3.text = text3.text + "\n" + result.Link;
                    ThirdChildIndex++;
                    
                 }
                 i++;
            Debug.Log(i + "i"+ resultCount);
             }

             // initialize again for description text
           /*  i = 0;
             j = 0;
             FirstChildIndex = 0;
             SecondChildIndex = 0;
             ThirdChildIndex = 0;

             foreach (var description in x.Description)
             {

                 Debug.Log(description);
                 if (i < 4)
                 {
                     temp1 = firstPage.transform.GetChild(FirstChildIndex).gameObject.transform.GetChild(0).gameObject;
                     text1 = temp1.GetComponent<TextMeshProUGUI>();
                     text1.text = text1.text + "\n" + description;
                     FirstChildIndex++;
                 }

                 else if (i > 3 && i < 6)
                 {
                     temp2 = secondPage.transform.GetChild(SecondChildIndex).gameObject.transform.GetChild(0).gameObject;
                     text2 = temp2.GetComponent<TextMeshProUGUI>();
                     text2.text = text2.text + "\n" + description;
                     SecondChildIndex++;
                 }
                 else
                 {
                     temp3 = thirdPage.transform.GetChild(ThirdChildIndex).gameObject.transform.GetChild(0).gameObject;
                     text3 = temp3.GetComponent<TextMeshProUGUI>();
                     text3.text = text3.text + "\n" + description;
                     ThirdChildIndex++;
                 }
                 i++;
             }


      }       */   
    
}

