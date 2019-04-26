using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using PraiseHtml;
using UnityEngine.UI;
using System.Net.Http;
using TMPro;
using HtmlAgilityPack;
using SpraiseHtml;


public class SecondScript : MonoBehaviour
{
    public GameObject Page = null;
    public GameObject inputField = null;
    public GameObject NextPage = null;

    private GameObject temp1, temp2, temp3, inputTextTemp;
    private Transform _transform;
    private TextMeshProUGUI text1, text2, text3;
    private InputField input;


    public string NextIndex = "";
    public string SearchTerm = "google";


    public Class1 SpraiseHtmlDll = new Class1();

    public class Result { public string title { get; set; } public string link { get; set; } public string snippet { get; set; } }

    public void SearchUrl()
    {
        /*
        List<Result> results = new List<Result>();
        results.Add(new Result
        {
            title = "FB",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB2",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB3",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB4",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB5",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB6",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB7",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB8",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB9",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB10",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        */
        inputTextTemp = inputField.transform.GetChild(0).gameObject;
        input = inputTextTemp.GetComponent<InputField>();
        var search = input.text;
        Debug.Log(search);
        
        var results = SpraiseHtmlDll.Search(search);
        SearchTerm = SpraiseHtmlDll.search_terms;
        NextIndex = SpraiseHtmlDll.next_index;
        Debug.Log(NextIndex + "search" + SearchTerm);
        
        int i = 0;
        int ChildIndex = 0;



        foreach (var result in results)
        {

            //Debug.Log(url);
            if (i <= 5)
            {

                Debug.Log(i + "2nd");
                temp2 = Page.transform.GetChild(ChildIndex).gameObject;
                temp2.SetActive(true);
                temp2 = temp2.transform.GetChild(0).gameObject;
                text2 = temp2.GetComponent<TextMeshProUGUI>();
                text2.text = result.title;
                text2.text = text2.text + "\n" + result.link;
                text2.text = text2.text + "\n" + result.snippet;
                ChildIndex++;

            }

            i++;
        }

        NextPage.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void SearchNextPage()
    {
        /*
        List<Result> results = new List<Result>();
        results.Add(new Result
        {
            title = "FB",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "sattyaFB2",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB3",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB4",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB5",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB6",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB7",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB8",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB9",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
        results.Add(new Result
        {
            title = "FB10",
            link = "http://www.google.com/finance?q=NASDAQ:FB",
            snippet = "Oct 28, 2016 - With the new Unity UI, working with text labels on buttons can be tedious ... using the Button element that I think other developers would find useful. ... with a couple more button-related examples (clicking and holding) which I'll ...",
        });
             */
        Debug.Log(NextIndex + "and" + SearchTerm);

          var results = SpraiseHtmlDll.nextPage(SearchTerm, NextIndex);
          SearchTerm = SpraiseHtmlDll.search_terms;
          NextIndex = SpraiseHtmlDll.next_index;
          Debug.Log(NextIndex + "and2" + SearchTerm);
     
        int i = 0;
        int ChildIndex = 0;

        foreach (var result in results)
        {

            //Debug.Log(url);
            if (i <= 5)
            {

                Debug.Log(i + "2nd");
                temp2 = Page.transform.GetChild(ChildIndex).gameObject;
                temp2.SetActive(true);
                temp2 = temp2.transform.GetChild(0).gameObject;
                text2 = temp2.GetComponent<TextMeshProUGUI>();
                text2.text = result.title;
                text2.text = text2.text + "\n" + result.link;
                text2.text = text2.text + "\n" + result.snippet;
                ChildIndex++;

            }

            i++;
        }
    }
}



    