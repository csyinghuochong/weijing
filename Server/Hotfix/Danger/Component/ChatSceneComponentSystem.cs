using System.Collections.Generic;

namespace ET
{
    [ObjectSystem]
    public class ChatSceneComponentDestroy : DestroySystem<ChatSceneComponent>
    {
        public override void Destroy(ChatSceneComponent self)
        {
            foreach (var chatInfoUnit in self.ChatInfoUnitsDict.Values)
            {
                chatInfoUnit?.Dispose();
            }
        }
    }

    public static class ChatSceneComponentSystem
    {
        public static void Add(this ChatSceneComponent self, ChatInfoUnit chatInfoUnit)
        {
            if (self.ChatInfoUnitsDict.ContainsKey(chatInfoUnit.Id))
            {
                Log.Error($"chatInfoUnit is exist! ： {chatInfoUnit.Id}");
                return;
            }
            self.ChatInfoUnitsDict.Add(chatInfoUnit.Id, chatInfoUnit);
        }


        public static ChatInfoUnit Get(this ChatSceneComponent self, long id)
        {
            self.ChatInfoUnitsDict.TryGetValue(id, out ChatInfoUnit chatInfoUnit);
            return chatInfoUnit;
        }


        public static void Remove(this ChatSceneComponent self, long id)
        {
            if (self.ChatInfoUnitsDict.TryGetValue(id, out ChatInfoUnit chatInfoUnit))
            {
                self.ChatInfoUnitsDict.Remove(id);
                chatInfoUnit?.Dispose();
            }
        }
    }
}
