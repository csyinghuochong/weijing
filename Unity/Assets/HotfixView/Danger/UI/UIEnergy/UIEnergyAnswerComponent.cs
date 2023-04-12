using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

namespace ET
{
    public class UIEnergyAnswerComponent : Entity, IAwake
    {
        public GameObject[] TextAnswers = new GameObject[2];
        public GameObject[] Button_List = new GameObject[2];
        public GameObject ItemNodeList;
        public GameObject TextQuestion;
        public GameObject TextTip;

        public EnergyComponent EnergyComponent;
        public QuestionBankConfig QuestionBankConfig;

        public int RightIndex;
    }


    public class UIEnergyAnswerComponentAwakeSystem : AwakeSystem<UIEnergyAnswerComponent>
    {
        public override void Awake(UIEnergyAnswerComponent self)
        {

            ReferenceCollector rc = self.GetParent<UI>().GameObject.GetComponent<ReferenceCollector>();

            self.ItemNodeList = rc.Get<GameObject>("ItemNodeList");
            self.TextAnswers[0] = rc.Get<GameObject>("TextAnswerA");
            self.TextAnswers[1] = rc.Get<GameObject>("TextAnswerB");

            self.Button_List[0] = rc.Get<GameObject>("Button_A");
            self.Button_List[1] = rc.Get<GameObject>("Button_B");

            self.Button_List[0].GetComponent<Button>().onClick.AddListener(() => { self.OnClickAnswer(0); });
            self.Button_List[1].GetComponent<Button>().onClick.AddListener(() => { self.OnClickAnswer(1); });

            self.GetParent<UI>().OnUpdateUI = () => { self.OnUpdateUI(); };

            self.TextQuestion = rc.Get<GameObject>("TextQuestion");
            self.TextTip = rc.Get<GameObject>("TextTip");
            self.EnergyComponent = self.ZoneScene().GetComponent<EnergyComponent>();

            self.OnInitUI();
        }
    }

    public static class UIEnergyAnswerComponentSystem
    {

        public static void OnInitUI(this UIEnergyAnswerComponent self)
        {
            GlobalValueConfig globalValueConfig = GlobalValueConfigCategory.Instance.Get(15);
            UICommonHelper.ShowItemList( globalValueConfig.Value, self.ItemNodeList, self );
        }

        public static void OnUpdateUI(this UIEnergyAnswerComponent self)
        {
            EnergyComponent energyComponent = self.ZoneScene().GetComponent<EnergyComponent>();
            if (energyComponent.QuestionIndex >= energyComponent.QuestionList.Count )
            {
                self.ShowAnswerEndUI();
            }
            else
            {
                self.UpdateQuestion();
            }
        }

        public static void ShowAnswerEndUI(this UIEnergyAnswerComponent self)
        {
            for (int i = 0; i < self.Button_List.Length; i++)
            {
                self.Button_List[i].SetActive(false);
            }
            self.TextTip.GetComponent<Text>().text = "今日已答完全部问题,请明日再来!";
            self.TextQuestion.GetComponent<Text>().text = "";
            self.ItemNodeList.SetActive(false);
        }

        public static void UpdateQuestion(this UIEnergyAnswerComponent self)
        {
            int questionId = self.EnergyComponent.QuestionList[self.EnergyComponent.QuestionIndex];
            self.QuestionBankConfig = QuestionBankConfigCategory.Instance.Get(questionId);

            self.TextTip.GetComponent<Text>().text = $"当前问答题{self.EnergyComponent.QuestionIndex + 1}/{self.EnergyComponent.QuestionList.Count}";
            self.TextQuestion.GetComponent<Text>().text = self.QuestionBankConfig.Question;

            string answerRight = self.QuestionBankConfig.Right;
            string answerError = self.QuestionBankConfig.Error;
            if (RandomHelper.RandFloat01() <= 0.5f)
            {
                self.RightIndex = 0;
                self.TextAnswers[0].GetComponent<Text>().text = answerRight;
                self.TextAnswers[1].GetComponent<Text>().text = answerError;
            }
            else
            {
                self.RightIndex = 1;
                self.TextAnswers[0].GetComponent<Text>().text = answerError;
                self.TextAnswers[1].GetComponent<Text>().text = answerRight;
            }
        }

        public static void OnClickAnswer(this UIEnergyAnswerComponent self, int index)
        {
            EnergyComponent energyComponent = self.ZoneScene().GetComponent<EnergyComponent>();
            int QusetionValue = 0;
            if (self.RightIndex != index)
            {
                FloatTipManager.Instance.ShowFloatTip("答错了！");
            }
            else {
                FloatTipManager.Instance.ShowFloatTip("回答正确,获得奖励！");
                QusetionValue = 1;
            }

            self.EnergyComponent.QuestionIndex++;
            if (self.EnergyComponent.QuestionIndex >= self.EnergyComponent.QuestionList.Count)
            {
                FloatTipManager.Instance.ShowFloatTip("已答完全部题目");
                self.ShowAnswerEndUI();
            }
            else
            {
                self.UpdateQuestion();
            }

            energyComponent.RequestSendAnswer(QusetionValue).Coroutine();
        }
    }

}
