using ET;
using libx;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIYinSi : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject TextButton_2;
    public GameObject TextButton_1;

    public GameObject TextYinSi;
    public GameObject YongHuXieYiClose;
    public GameObject YinSiXieYiClose;
    public GameObject YongHuXieYi;

    public GameObject YinSiXieYi;
    public GameObject ButtonRefuse;
    public GameObject ButtonAgree;
    public GameObject ButtonClose;

    public int AgreeNumber = 0;


    public string GetYingSiText(int platform)
    {
        try
        {
            WebClient MyWebClient = new WebClient();
            MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            string dataurl = platform == 5 ? "http://verification.weijinggame.com/weijing/yinsi3.txt" : "http://verification.weijinggame.com/weijing/yinsi1.txt";
            Byte[] pageData = MyWebClient.DownloadData(dataurl); //从指定网站下载数据
            string pageHtml = Encoding.UTF8.GetString(pageData);
            return pageHtml;
        }

        catch (WebException webEx)
        {
            Log.Debug(webEx.ToString());
        }
        return "服务器维护中！";
    }

    public void ShowTextList(GameObject textItem)
    {
        int platform = GameObject.Find("Global").GetComponent<Init>().Platform;
        string pageHtml = GetYingSiText(platform);

        string tempstr = string.Empty;
        string leftValue = pageHtml;
        int indexlist = pageHtml.IndexOf('\n');
        int whileNumber = 0;

        List<string> allString = new List<string>();

        while (indexlist != -1)
        {
            whileNumber++;
            if (whileNumber >= 1000)
            {
                break;
            }

            tempstr = leftValue.Substring(0, indexlist);
            allString.Add(tempstr);

            indexlist += 1;
            leftValue = leftValue.Substring(indexlist, leftValue.Length - indexlist);

            indexlist = leftValue.IndexOf('\n');

            if (indexlist == -1)
            {
                allString.Add(leftValue);
            }
        }

        string lineStr = string.Empty;

        Transform parentobject = textItem.transform.parent;
        int totalLength = allString.Count;
        for (int i = 0; i < totalLength; i++)
        {
            lineStr += allString[i] + '\n';

            if (lineStr.Length > 1000 || i == totalLength - 1)
            {
                lineStr = lineStr.Substring(0, lineStr.Length - 1);

                GameObject textGo = GameObject.Instantiate(textItem);
                textGo.transform.SetParent( parentobject);
                textGo.transform.localScale = Vector3.one;
                textGo.transform.localPosition = Vector3.zero;
                Text text = textGo.GetComponent<Text>();

                text.text = lineStr;

                text.GetComponent<RectTransform>().sizeDelta = new Vector2(1400, text.preferredHeight);

                text.gameObject.SetActive(false);
                text.gameObject.SetActive(true);

                lineStr = string.Empty;
            }


        }
    }


    private bool LoadYinSi = false;
    private void ShowYinSi()
    {
        this.YongHuXieYi.SetActive(true);
        if (!LoadYinSi)
        {
            LoadYinSi = true;
            ShowTextList(this.TextYinSi);
        }
    }

    void Start()
    {
        ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();


        this.YongHuXieYi = rc.Get<GameObject>("YongHuXieYi");
        this.YinSiXieYi = rc.Get<GameObject>("YinSiXieYi");

        this.TextButton_2 = rc.Get<GameObject>("TextButton_2");
        this.TextButton_1 = rc.Get<GameObject>("TextButton_1");
        this.TextButton_2.GetComponent<Button>().onClick.AddListener(() => { this.YinSiXieYi.SetActive(true); });
        this.TextButton_1.GetComponent<Button>().onClick.AddListener(ShowYinSi);

        this.TextYinSi = rc.Get<GameObject>("TextYinSi");
        this.TextYinSi.SetActive(false);
       
        this.YongHuXieYiClose = rc.Get<GameObject>("YongHuXieYiClose");
        this.YongHuXieYiClose.GetComponent<Button>().onClick.AddListener(() => { this.YongHuXieYi.SetActive(false); });

        this.YinSiXieYiClose = rc.Get<GameObject>("YinSiXieYiClose");
        this.YinSiXieYiClose.GetComponent<Button>().onClick.AddListener(() => { this.YinSiXieYi.SetActive(false); });

        this.ButtonRefuse = rc.Get<GameObject>("ButtonRefuse");
        this.ButtonRefuse.GetComponent<Button>().onClick.AddListener(this.OnButtonRefuse);

        this.ButtonAgree = rc.Get<GameObject>("ButtonAgree");
        this.ButtonAgree.GetComponent<Button>().onClick.AddListener(this.OnButtonAgree);

        this.ButtonClose = rc.Get<GameObject>("ButtonClose");
        this.ButtonClose.GetComponent<Button>().onClick.AddListener(this.OnButtonRefuse);

        GameObject.Find("Global").GetComponent<Init>().OnGetPermissionsHandler = this.onRequestPermissionsResult;

        this.AgreeNumber = 0;

        if (PlayerPrefs.GetString("UIYinSi_0111").Equals("1"))
        {
            Log.ILog.Debug($"UIYinSi == 1: StartUpdate");
            this.gameObject.SetActive(false);
            GameObject.Find("Global").GetComponent<Init>().TikTokInit();
            GameObject.Find("Global/UI/Hidden/Updater").GetComponent<Updater>().StartUpdate();
        }
    }

    public void OnButtonRefuse(  )
    {
        Application.Quit();
    }

    public  void onRequestPermissionsResult(string permissons)
    {
        Log.ILog.Debug($"onRequestPermissionsResult: {permissons}");
        string[] values = permissons.Split('_');
        if (values[1] == "0")
        {
            Application.Quit();
            return;
        }
        this.AgreeNumber++;
        int needAgreeNumber = 2;
        if (this.AgreeNumber >= needAgreeNumber || permissons == "1_1")
        {
            PlayerPrefs.SetString("UIYinSi_0111", "1");
            Log.ILog.Debug($"onRequestPermissionsResult: StartUpdate");

            GameObject.Find("Global").GetComponent<Init>().TikTokInit();
            GameObject.Find("Global/UI/Hidden/Updater").GetComponent<Updater>().StartUpdate();
            this.AgreeNumber = -1000;
        }
    }

    public  void OnButtonAgree()
    {
        this.gameObject.SetActive(false);
        GameObject.Find("Global").GetComponent<Init>().SetIsPermissionGranted();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
