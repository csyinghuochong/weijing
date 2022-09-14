using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera_1 : MonoBehaviour
{

    //观察目标
    public Transform Target;

    //上次碰撞到的物体
    private List<GameObject> lastColliderObject = new List<GameObject>();

    //本次碰撞到的物体
    private List<GameObject> colliderObject = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*射线可以从头部起始*/

        //这里是计算射线的方向，从主角发射方向是射线机方向
        //Vector3 aim = Target.position;
        ////得到方向
        //Vector3 ve = (Target.position - transform.position).normalized;
        //float an = transform.eulerAngles.y;
        //aim -= an * ve;

        ////在场景视图中可以看到这条射线
        ////Debug.DrawLine(target.position, aim, Color.red);
        //RaycastHit[] hit;
        //hit = Physics.RaycastAll(Target.position, aim, 100f);//起始位置、方向、距离

        if (Target == null)
        {
            return;
        }
        Vector3 m_CameraPos = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 5);
        RaycastHit[] hit = Physics.RaycastAll(m_CameraPos, Target.position - m_CameraPos, 13);

        //将 colliderObject 中所有的值添加进 lastColliderObject
        for (int i = 0; i < colliderObject.Count; i++)
        {
            lastColliderObject.Add(colliderObject[i]);
        }

        colliderObject.Clear();//清空本次碰撞到的所有物体
        for (int i = 0; i < hit.Length; i++)//获取碰撞到的所有物体
        {
            //if (hit[i].collider.gameObject.name != "Npc"//护栏
            //    && hit[i].collider.gameObject.name != "Map"//地面
            //    && hit[i].collider.gameObject.tag != "Player")//角色
            if (hit[i].transform.gameObject.layer == LayerMask.NameToLayer("Building"))
            {
                //Debug.Log(hit[i].collider.gameObject.name);
                colliderObject.Add(hit[i].collider.gameObject);
                SetMaterialsColor(hit[i].collider.gameObject.GetComponent<Renderer>(), 0.4f);//置当前物体材质透明度
            }
        }

        //上次与本次对比，本次还存在的物体则赋值为null
        for (int i = 0; i < lastColliderObject.Count; i++)
        {
            for (int ii = 0; ii < colliderObject.Count; ii++)
            {
                if (colliderObject[ii] != null)
                {
                    if (lastColliderObject[i] == colliderObject[ii])
                    {
                        lastColliderObject[i] = null;
                        break;
                    }
                }
            }
        }

         // 当值为null时则可判断当前物体还处于遮挡状态
         //值不为null时则可恢复默认状态(不透明)
         for (int i = 0; i < lastColliderObject.Count; i++)
        {
            if (lastColliderObject[i] != null)
            {
                SetMaterialsColor(lastColliderObject[i].GetComponent<Renderer>(), 1f);//恢复上次物体材质透明度
            }
        }
    }


    /// 置物体所有材质球颜色 <summary>
    /// 置物体所有材质球颜色
    /// </summary>
    /// <param name="_renderer">材质</param>
    /// <param name="Transpa">透明度</param>
    private void SetMaterialsColor(Renderer _renderer, float Transpa)
    {
        if (_renderer == null)
        {
            return;
        }
        _renderer.enabled = Transpa == 1f ? true : false;


        ////获取当前物体材质球数量
        //int materialsNumber = _renderer.sharedMaterials.Length;
        //for (int i = 0; i < materialsNumber; i++)
        //{
        //    //获取当前材质球颜色
        //    Color color = _renderer.materials[i].color;

        //    //设置透明度  取值范围：0~1;  0 = 完全透明
        //    color.a = Transpa;

        //    //置当前材质球颜色
        //    _renderer.materials[i].SetColor("_Color", color);
        //}
    }
}
