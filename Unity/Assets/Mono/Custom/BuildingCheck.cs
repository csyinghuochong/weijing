using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingCheck : MonoBehaviour
{

    private Material m_TMm;//一个透明的贴图
    private Dictionary<string, Material> m_ZMDic = new Dictionary<string, Material>(50);
    private Dictionary<string, MeshRenderer> m_ZMeshDic = new Dictionary<string, MeshRenderer>(50);
    private Vector3 m_CameraPos;
    private Camera _camera;
    private List<GameObject> oldMask = new List<GameObject>();
    private List<GameObject> newMask = new List<GameObject>();

    public Transform m_Pos;

    // Start is called before the first frame update

    private float lastTime;

    void Start()
    {
        _camera = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastTime < 1f)
        {
            return;
        }
        lastTime = Time.time;
       
        foreach (var item in m_ZMeshDic)
        {
            item.Value.sharedMaterial = m_ZMDic[item.Key];
        }
        m_CameraPos = new Vector3(_camera.transform.position.x, _camera.transform.position.y, _camera.transform.position.z - 5);
        RaycastHit[] hit = Physics.RaycastAll(m_CameraPos, m_Pos.position - m_CameraPos, 13);

        //Debug.DrawRay(m_CameraPos, (m_Pos.position - m_CameraPos) * 10, Color.yellow);
        for (int i = 0; i < hit.Length; i++)
        {
           // if (hit[i].transform.gameObject.layer == LayerMask.NameToLayer("Building"))    //    if (hit[i].collider.gameObject)
            {
                UnityEngine.Debug.Log("hit[i].transform.gameObject:  " + hit[i].transform.gameObject.name);

                MeshRenderer m = hit[i].transform.GetComponent<MeshRenderer>();
                if (m)
                {
                    if (!m_ZMDic.ContainsKey(m.gameObject.name))
                    {
                        m_ZMeshDic.Add(m.gameObject.name, m);
                        m_ZMDic.Add(m.gameObject.name, m.sharedMaterial);
                    }
                    m.sharedMaterial = m_TMm;
                }
            }
        }

        //for (int i = 0; i < oldMask.Count; i++)
        //{
        //    if (!newMask.Contains(oldMask[i]))
        //    {
        //        oldMask[i].SetActive(true);
        //    }
        //}
        //oldMask.Clear();
        //oldMask.AddRange(newMask);
    }
}
