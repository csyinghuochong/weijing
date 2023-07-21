using ET;
using libx;
using System;
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


    public string GetYingSiText()
    {
        try
        {
            WebClient MyWebClient = new WebClient();
            MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            Byte[] pageData = MyWebClient.DownloadData("http://verification.weijinggame.com/weijing/yinsi1.txt"); //从指定网站下载数据
            string pageHtml = Encoding.UTF8.GetString(pageData);
            return pageHtml;
        }

        catch (WebException webEx)
        {
            Log.Debug(webEx.ToString());
        }
        return "服务器维护中！";
    }

    void Start()
    {
        ReferenceCollector rc = gameObject.GetComponent<ReferenceCollector>();


        this.YongHuXieYi = rc.Get<GameObject>("YongHuXieYi");
        this.YinSiXieYi = rc.Get<GameObject>("YinSiXieYi");

        this.TextButton_2 = rc.Get<GameObject>("TextButton_2");
        this.TextButton_1 = rc.Get<GameObject>("TextButton_1");
        this.TextButton_2.GetComponent<Button>().onClick.AddListener(() => { this.YinSiXieYi.SetActive(true); });
        this.TextButton_1.GetComponent<Button>().onClick.AddListener(() => { this.YongHuXieYi.SetActive(true); });

        this.TextYinSi = rc.Get<GameObject>("TextYinSi");
        this.TextYinSi.GetComponent<TextMeshProUGUI>().text = GetYingSiText();

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

        if (PlayerPrefs.GetString("UIYinSi_0").Equals("1"))
        {
            Log.ILog.Debug($"UIYinSi == 1: StartUpdate");
            this.gameObject.SetActive(false);
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
        if (this.AgreeNumber >= 3 || permissons == "1_1")
        {
            PlayerPrefs.SetString("UIYinSi_0", "1");
            Log.ILog.Debug($"onRequestPermissionsResult: StartUpdate");
            GameObject.Find("Global/UI/Hidden/Updater").GetComponent<Updater>().StartUpdate();
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
