namespace ET
{


    public static class EnergyComponentSystem
    {

        public static async ETTask RequestEnergyInfo(this EnergyComponent self)
        {
            C2M_EnergyInfoRequest c2M_EnergyInfoRequest = new C2M_EnergyInfoRequest();
            M2C_EnergyInfoResponse r2c_roleEquip = (M2C_EnergyInfoResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_EnergyInfoRequest);

            self.GetRewards = r2c_roleEquip.GetRewards;
            self.QuestionList = r2c_roleEquip.QuestionList;
            self.QuestionIndex = r2c_roleEquip.QuestionIndex;
        }

        public static async ETTask RequestSendAnswer(this EnergyComponent self, int index)
        {
            C2M_EnergyAnswerRequest c2M_EnergyReceiveRequest = new C2M_EnergyAnswerRequest() { AnswerIndex = index };
            M2C_EnergyAnswerResponse r2c_roleEquip = (M2C_EnergyAnswerResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_EnergyReceiveRequest);
        }

        public static async ETTask RequestEnergyReward(this EnergyComponent self, int index)
        {
            if (self.GetRewards[index] == 1)
            {
                return;
            }

            C2M_EnergyReceiveRequest c2M_EnergyReceiveRequest = new C2M_EnergyReceiveRequest() {   RewardType = index };
            M2C_EnergyReceiveResponse r2c_roleEquip = (M2C_EnergyReceiveResponse)await self.DomainScene().GetComponent<SessionComponent>().Session.Call(c2M_EnergyReceiveRequest);

            self.GetRewards[index] = 1;
        }
    }
}
