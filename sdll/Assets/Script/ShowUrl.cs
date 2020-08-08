using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class script : MonoBehaviour
{
    const string IP_ADDRESS = "https://peaceful-crag-49779.herokuapp.com/";
    public  string SearchUrl = "https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.webbrowser?view=netcore-3.1";
    string uri_image;
    public Renderer meshRender;

    public void main()
    {
        Debug.Log("main clicked");
    }

    private void Start()
    {
        uri_image = IP_ADDRESS + "webshot?url=" + SearchUrl;
        // meshRender.material.color = Color.red;
        StartCoroutine(GetWebShotFromUrl(uri_image, true, IP_ADDRESS + "webshot"));
    }
    IEnumerator GetWebShotFromUrl(string url, bool isMain, string query)
    {
        Debug.Log(url);
        UnityWebRequest www = UnityWebRequest.Get(url);
        yield return www.SendWebRequest();
        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
            Debug.Log("praksh");
        }
        else
        {
            byte[] imageBytes = www.downloadHandler.data;
            Debug.Log("satya");
            Debug.Log(www.downloadHandler.text);
            LoadTexture(imageBytes);
        }
    }

    private void LoadTexture(byte[] imageBytes)
    {
        StartCoroutine(LoadTextureCoroutine(imageBytes));
    }

    IEnumerator LoadTextureCoroutine(byte[] imageBytes)
    {
        Texture2D tempTex = new Texture2D(1024, 768);
        tempTex.LoadImage(imageBytes);
        Debug.Log("WIDTH: " + tempTex.width + " HEIGHT: " + tempTex.height);
        meshRender.material.mainTexture = tempTex;
        // meshRender.material = screenMat;
        yield return new WaitForSeconds(1f);
    }

}
