using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{

    List<string> title = new List<string>();
    List<string> link = new List<string>();
    List<string> des = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        title.Add("FB");
        title.Add("F.B.(FluffBusting)Purity");
        title.Add("A Note From Mark Zuckerberg | Facebook Newsroom");
        title.Add("Toolkit For FB");
        title.Add("Logout - Web SDKs");
        title.Add("FB QVC ? Facebook tries Live video shopping | TechCrunch");
        title.Add("DownAlbum");
        title.Add("Getafix: How Facebook tools learn to fix bugs automatically...");
        title.Add("Facebook's gaming hub Fb.gg launches into beta on Android ...");
        title.Add("Facebook Pixel Helper");

        link.Add("http://www.google.com/finance?q=NASDAQ:FB");
        link.Add("https://chrome.google.com/webstore/detail/fbfluffbustingpurity/nmkinhboiljjkhaknpaeaicmdjhagpep");
        link.Add("http://feedproxy.google.com/~r/HackernewsTop3Feed/~3/3pFgPnpi9CA/");
        link.Add("https://chrome.google.com/webstore/detail/toolkit-for-fb/fcachklhcihfinmagjnlomehfdhndhep");
        link.Add("https://groups.google.com/forum/#!msg/gwt-facebook/QNli4mCHOLg/JkM8PqECxLUJ");
        link.Add("http://feedproxy.google.com/~r/Techcrunch/~3/rMNyr5SSadA/");
        link.Add("https://chrome.google.com/webstore/detail/downalbum/cgjnhhjpfcdhbhlcmmjppicjmgfkppok");
        link.Add("http://feedproxy.google.com/~r/thechangelog/~3/sIM2xGiADjQ/");
        link.Add("https://feedproxy.google.com/~r/Techcrunch/~3/hvr0wjj8iz8/");
        link.Add("https://chrome.google.com/webstore/detail/facebook-pixel-helper/fdgfkebogiimcoedlicjlajpkdmockpc");
      /*  results.Add(new Result
        {
            Title = "FB",
            Link = "http://www.google.com/finance?q=NASDAQ:FB", // Description = "",
        });
        results.Add(new Result
        {
            Title = "FB2",
            Link = "http://www.google.com/finance?q=NASDAQ:FB", // Description = "",
        });
        results.Add(new Result
        {
            Title = "FB3",
            Link = "http://www.google.com/finance?q=NASDAQ:FB", // Description = "",
        });
        results.Add(new Result
        {
            Title = "FB4",
            Link = "http://www.google.com/finance?q=NASDAQ:FB", // Description = "",
        });
        results.Add(new Result
        {
            Title = "FB5",
            Link = "http://www.google.com/finance?q=NASDAQ:FB", // Description = "",
        });
        results.Add(new Result
        {
            Title = "FB6",
            Link = "http://www.google.com/finance?q=NASDAQ:FB", // Description = "",
        });
        results.Add(new Result
        {
            Title = "FB7",
            Link = "http://www.google.com/finance?q=NASDAQ:FB", // Description = "",
        });
        results.Add(new Result
        {
            Title = "FB8",
            Link = "http://www.google.com/finance?q=NASDAQ:FB", // Description = "",
        });
        results.Add(new Result
        {
            Title = "FB9",
            Link = "http://www.google.com/finance?q=NASDAQ:FB", // Description = "",
        });
        results.Add(new Result
        {
            Title = "FB10",
            Link = "http://www.google.com/finance?q=NASDAQ:FB", // Description = "",
        });
        */

        foreach (var i in title)
            Debug.Log(i);
        foreach (var i in link)
            Debug.Log(i);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
