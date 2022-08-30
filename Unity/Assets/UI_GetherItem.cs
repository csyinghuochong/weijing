using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_GetherItem : MonoBehaviour {

    public string SceneItemOnlyID;              //场景物唯一ID,用于存储只显示一次的宝箱,手工配置
    public string SceneItmeID;
	public GameObject DropNamePosition;
	//public string DropItemID;                 //掉落的道具ID
	//public int DropItemNum;                   //掉落的道具数据,一般默认为1 像金币或其他货币会用的上
	public bool IfRoseTake;                     //道具是否被拾取
	private bool DropNameUpdateStatus;          //掉落更新 表示执行一次
	private GameObject obj_dropName;            //掉落物体的UI
	private Vector3 vec3_droName;               //掉落道具名字在UI中的位置
	private GameObject dropItemModel;			//3D道具模型
	private bool openStatus;					//打开状态
	public float openTime;						//打开时间
	public float openTimeSum;					//打开时间累计
	public bool openStatusOnce;				//打开宝箱第一次实例化UI
	public GameObject mainUIGetherItem;		    //主界面打开进度条UI
	public string CostItemID;					//开启宝箱消耗的道具ID
	public string CostItemNum;					//开启宝箱消耗的道具数量
	public bool IfNeedItem;						//开启宝箱是否消耗道具
    private string sceneItemName;               //宝箱名称
    private string sceneItemQuality;            //宝箱品质
    private string sceneItemType;               //场景物类型
    private int sceneItemApearPro;              //场景物出现的概率
    public GameObject[] sceneItemCreateMonsterList;     //触发场景物出现怪物
    private string sceneItemStr;

}