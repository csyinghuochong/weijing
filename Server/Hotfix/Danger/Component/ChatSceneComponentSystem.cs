using System.Collections.Generic;

namespace ET
{

    public static class ChatSceneComponentSystem
    {

        public static void OnUnitChangeStatus(this ChatSceneComponent self, M2A_ChangeStatusRequest request)
        {
            if ( request.UnitId != 0)
            {
                bool have = false;
                for (int i = 0; i < self.WordActorList.Count; i++)
                {
                    if (self.WordActorList[i].UserId == request.UserID)
                    {
                        have = true;
                        self.WordActorList[i].UnionId = request.UnionId;
                        self.WordActorList[i].GateSessionActorId = request.GateSessionId;
                    }
                }
                if (!have)
                {
                    self.WordActorList.Add(new ChatUnitInfo() { UserId = request.UserID, UnionId = request.UnionId, GateSessionActorId = request.GateSessionId });
                }
            }
            else
            {
                for (int i = self.WordActorList.Count - 1; i >= 0; i--)
                {
                    if (self.WordActorList[i].UserId == request.UserID)
                    {
                        self.WordActorList.RemoveAt(i);
                    }
                }
            }
        }

        public static void OnUnitExitScene(this ChatSceneComponent self)
        {

        }
    }
}
