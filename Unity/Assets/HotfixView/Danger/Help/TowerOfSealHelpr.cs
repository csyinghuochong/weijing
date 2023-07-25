using UnityEngine;

namespace ET
{
    public static class TowerOfSealHelpr
    {
        /// <summary>
        /// 封印之塔摇色子
        /// </summary>
        /// <param name="zoneScene"></param>
        /// <param name="costType"></param>
        public static async ETTask StartPlayDice(Scene zoneScene, int costType)
        {
            // 生成骰子
            var path = ABPathHelper.GetUnitPath("Component/shaizi");
            var bundleGameObject = await ResourcesComponent.Instance.LoadAssetAsync<GameObject>(path);
            GameObject gameObject = UnityEngine.Object.Instantiate(bundleGameObject, GlobalComponent.Instance.Unit);
            gameObject.transform.position = new Vector3(0, 1f, 0);

            // 给骰子随机一个向上的力和扭力
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            Vector3 force = new Vector3(0, Random.Range(6f, 7f), 0);
            Vector3 torque = new Vector3(Random.Range(-8f, 8f), Random.Range(-8f, 8f), Random.Range(-8f, 8f));
            rb.AddForce(force, ForceMode.Impulse);
            rb.AddTorque(torque, ForceMode.Impulse);

            await TimerComponent.Instance.WaitAsync(5000);

            // 算出骰子结果
            Vector3[] vertices = new Vector3 [8];
            BoxCollider diceCollider = gameObject.GetComponent<BoxCollider>();
            var bounds = diceCollider.bounds;
            Vector3 diceCenter = bounds.center;

            float dicex = bounds.size.x;
            float dicey = bounds.size.y;
            float dicez = bounds.size.z;

            //下面四个点
            vertices[0] = diceCenter + new Vector3(dicex, -dicey, dicez) * 0.5f;
            vertices[1] = diceCenter + new Vector3(-dicex, -dicey, dicez) * 0.5f;
            vertices[2] = diceCenter + new Vector3(-dicex, -dicey, -dicez) * 0.5f;
            vertices[3] = diceCenter + new Vector3(dicex, -dicey, -dicez) * 0.5f;

            //上面四个点
            vertices[4] = diceCenter + new Vector3(dicex, dicey, dicez) * 0.5f;
            vertices[5] = diceCenter + new Vector3(-dicex, dicey, dicez) * 0.5f;
            vertices[6] = diceCenter + new Vector3(-dicex, dicey, -dicez) * 0.5f;
            vertices[7] = diceCenter + new Vector3(dicex, dicey, -dicez) * 0.5f;

            Vector3[] newVertices = new Vector3 [8];
            for (int i = 0; i < newVertices.Length; i++)
            {
                newVertices[i] = diceCollider.transform.TransformPoint(vertices[i]);
            }

            float newVertice_0_y = Mathf.Round(newVertices[0].y);
            float newVertice_1_y = Mathf.Round(newVertices[1].y);
            float newVertice_2_y = Mathf.Round(newVertices[2].y);
            float newVertice_3_y = Mathf.Round(newVertices[3].y);
            float newVertice_4_y = Mathf.Round(newVertices[4].y);
            float newVertice_5_y = Mathf.Round(newVertices[5].y);
            float newVertice_6_y = Mathf.Round(newVertices[6].y);
            float newVertice_7_y = Mathf.Round(newVertices[7].y);

            int diceResult = 0;

            if (newVertice_0_y > newVertice_3_y && newVertice_1_y > newVertice_2_y && newVertice_4_y > newVertice_7_y &&
                newVertice_5_y > newVertice_6_y)
            {
                diceResult = 1;
            }

            if (newVertice_4_y > newVertice_0_y && newVertice_5_y > newVertice_1_y && newVertice_6_y > newVertice_2_y &&
                newVertice_7_y > newVertice_3_y)
            {
                diceResult = 6;
            }

            if (newVertice_1_y > newVertice_0_y && newVertice_2_y > newVertice_3_y && newVertice_5_y > newVertice_4_y &&
                newVertice_6_y > newVertice_7_y)
            {
                diceResult = 2;
            }

            if (newVertice_0_y > newVertice_1_y && newVertice_3_y > newVertice_2_y && newVertice_4_y > newVertice_5_y &&
                newVertice_7_y > newVertice_6_y)
            {
                diceResult = 5;
            }

            if (newVertice_0_y > newVertice_4_y && newVertice_1_y > newVertice_5_y && newVertice_2_y > newVertice_6_y &&
                newVertice_3_y > newVertice_7_y)
            {
                diceResult = 4;
            }

            if (newVertice_2_y > newVertice_1_y && newVertice_3_y > newVertice_0_y && newVertice_6_y > newVertice_5_y &&
                newVertice_7_y > newVertice_4_y)
            {
                diceResult = 3;
            }

            // 销毁骰子
            UnityEngine.Object.Destroy(gameObject);

            FloatTipManager.Instance.ShowFloatTip("骰子点数是:" + diceResult);

            M2C_TowerOfSealNextResponse m2CTowerOfSealNextResponse = (M2C_TowerOfSealNextResponse)await zoneScene
                    .GetComponent<SessionComponent>().Session.Call(new C2M_TowerOfSealNextRequest() { DiceResult = diceResult, CostType = costType });
            if (m2CTowerOfSealNextResponse.Error != ErrorCode.ERR_Success)
            {
                FloatTipManager.Instance.ShowFloatTip("操作错误！！");
                return;
            }

            // 更新面板信息
            UI uITowerOfSealMain = UIHelper.GetUI(zoneScene, UIType.UITowerOfSealMain);
            uITowerOfSealMain.GetComponent<UITowerOfSealMainComponent>().UpdateInfo();
        }
    }
}