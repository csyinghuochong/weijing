using System;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Options;

namespace ET
{

    //string url = $"http://{taphost}:{tapport}/wjtaprep?idfa=asedfstUfe&time=1605432321&ip=10.33.25.54&anid={SystemInfo.deviceUniqueIdentifier}&game_id=13&game_name=游戏名称&adset_id=132214&adset_net=计划名称&device_brand=苹果&device_model=iPhone3,2&creative_id=131232&conversion_type=TapRep&device=1&OAID=&callback=https%dcc.iem.taptap.cn&tap_track_id=xYTKx4rSFFWx&tap_project_id=13";
    [BsonIgnoreExtraElements]
    public class DBCenterTaprepRequest : Entity, IAwake
    {
        public string anid;
        public string callback;
        public string tap_project_id;
        public string tap_track_id;

        public bool actived;
    }
}
