using System.Collections.Generic;

namespace ET
{
    public static class GMHelp
    {

        public static List<string> GmAccount = new List<string>()
        {
            "tcg01",
            "tcg02",
            "test01",
            "testcn01",
            "18319670288",
            "13752404158",
            "18652422521",
        };

        public static List<long> BanChatPlayer = new List<long>()
        {

        };

        public static List<string> GetChuJi()
        {
            List<string> vs = new List<string>();
            vs.Add("1#1#1000000");
            vs.Add("1#3#1000000");
            vs.Add("6#20");
            vs.Add("8#10");
            vs.Add("1#10030301#1");
            vs.Add("1#10030303#1");
            vs.Add("1#10030305#1");
            vs.Add("1#10030307#1");
            vs.Add("1#10030309#1");
            vs.Add("1#10030311#1");
            vs.Add("1#10030313#1");
            vs.Add("1#10030315#1");
            vs.Add("1#10030316#1");
            vs.Add("1#10030317#1");
            vs.Add("1#10030320#1");
            vs.Add("1#10010083#999");
            vs.Add("1#10010026#99");


            return vs;
        }

        public static List<string> GetZhongJi()
        {
            List<string> vs = new List<string>();
            vs.Add("6#35");
            vs.Add("1#1#9999999");
            vs.Add("1#3#9999999");
            vs.Add("1#6#9999999");
            vs.Add("8#15");
            vs.Add("1#10030401#1");
            vs.Add("1#10030403#1");
            vs.Add("1#10030405#1");
            vs.Add("1#10030407#1");
            vs.Add("1#10030409#1");
            vs.Add("1#10030411#1");
            vs.Add("1#10030413#1");
            vs.Add("1#10030415#1");
            vs.Add("1#10030416#1");
            vs.Add("1#10030418#1");
            vs.Add("1#10030420#1");
            vs.Add("1#10020212#10");
            vs.Add("1#10020056#99");
            vs.Add("1#10011002#10");
            vs.Add("1#10010083#999");
            vs.Add("1#10010026#99");
            vs.Add("1#10020015#10");

            return vs;
        }

        public static List<string> GetGaopJi()
        {
            List<string> vs = new List<string>();
            vs.Add("6#50");
            vs.Add("6#60");
            vs.Add("1#1#9999999");
            vs.Add("1#3#9999999");
            vs.Add("1#6#9999999");
            vs.Add("8#25");
            vs.Add("1#10030630#1");
            vs.Add("1#10030631#1");
            vs.Add("1#10030632#1");
            vs.Add("1#10030633#1");
            vs.Add("1#10030634#1");
            vs.Add("1#10030635#1");
            vs.Add("1#10030636#1");
            vs.Add("1#10030637#1");
            vs.Add("1#10030638#1");
            vs.Add("1#10030639#1");
            vs.Add("1#10030640#1");
            vs.Add("1#10020212#10");
            vs.Add("1#10020056#99");
            vs.Add("1#10011004#10");
            vs.Add("1#10010083#999");
            vs.Add("1#10010026#99");
            vs.Add("1#10020015#10");
            vs.Add("1#10020063#50");
            vs.Add("1#10020110#50");
            vs.Add("1#10020161#50");
            vs.Add("1#10020215#50");
            vs.Add("1#10020216#50");
            vs.Add("1#10010532#1");
            vs.Add("1#10020209#50");
            vs.Add("1#10020210#50");
            vs.Add("1#10020211#50");

            return vs;
        }

#if !SERVER
        public static void ExcurteGmList(Scene zongscene, List<string> gms)
        {
            for (int i = 0; i < gms.Count; i++)
            {
                SendGmCommand(zongscene, gms[i]);
            }
        }

        public static void SendGmCommand(Scene zongscene, string gm)
        {
            C2M_GMCommandRequest c2M_GMCommandRequest = new C2M_GMCommandRequest() { 
                GMMsg = gm,
                Account = zongscene.GetComponent<AccountInfoComponent>().Account   
            };
            zongscene.GetComponent<SessionComponent>().Session.Send(c2M_GMCommandRequest);
        }

        public static void SendGmCommands(Scene zongscene, string gmlist)
        {
            if (gmlist.Contains("chuji"))
            {
                ExcurteGmList(zongscene, GetChuJi());
                return;
            }
            if (gmlist.Contains("zhongji"))
            {
                ExcurteGmList(zongscene, GetZhongJi());
                return;
            }
            if (gmlist.Contains("gaoji"))
            {
                ExcurteGmList(zongscene, GetGaopJi());
                return;
            }
        }
#endif

    }
}
