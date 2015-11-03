using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using KLab.Models.ActionModels;
using KLab.Models.ActionModels.Announcement;

namespace KLab.Models
{
    public class EpistemicModel
    {

        private readonly Dictionary<string, Agent> _agents = new Dictionary<string, Agent>();
        private readonly Dictionary<string, Atomic> _atomics = new Dictionary<string, Atomic>();


        private readonly Dictionary<string, SecretAnnouncementInfo> _secretAnnouncementInfos
            = new Dictionary<string, SecretAnnouncementInfo>();

        private readonly Dictionary<string, PublicAnnouncementInfo> _publicAnnouncementInfos
            = new Dictionary<string, PublicAnnouncementInfo>();

        private readonly Dictionary<string, ActionModel> _actionModels 
            = new Dictionary<string, ActionModel>();


        //==AGENTS & ATOMICS===========================================================

        public bool AddAgent(string agentName)
        {
            Agent agent = null;
            if (_agents.TryGetValue(agentName, out agent))
            {
                return false;
            }

            agent = new Agent(agentName);
            _agents.Add(agentName, agent);
            return true;

        }

        public void RemoveAgent(string agentName)
        {
            _agents.Remove(agentName);
        }

        public bool AddAtomic(string atomicName)
        {
            Atomic atomic = null;
            if (_atomics.TryGetValue(atomicName, out atomic))
            {
                return false;
            }

            atomic = new Atomic(atomicName);
            _atomics.Add(atomicName, atomic);
            return true;

        }

        public void RemoveAtomic(string atomicName)
        {
            _atomics.Remove(atomicName);
        }

        //==ACTION MODELS=============================================================

        public bool IsActionsEmpty
        {
            get { return _actionModels.Count == 0; }
        }

        public ActionModelType? FindTypeOfAction(string name)
        {
            if (_secretAnnouncementInfos.ContainsKey(name))
                return ActionModelType.SecretAnnouncement;

            if (_publicAnnouncementInfos.ContainsKey(name))
                return ActionModelType.PublicAnnouncement;

            return null;
        }

        public void RemoveActionModel(string amName)
        {
            _actionModels.Remove(amName);
        }

        public ActionModel GetActionModel(string name)
        {
            ActionModel aModel = null;
            _actionModels.TryGetValue(name, out aModel);
            return aModel;
        }

        public bool IsNameConsistentForAnnounceInfo(string name)
        {
            return
                !_secretAnnouncementInfos.ContainsKey(name) &&
                !_publicAnnouncementInfos.ContainsKey(name);
        }

        public SecretAnnouncementInfo CreateSecretAnnouncementInfo(string name)
        {
            if (IsNameConsistentForAnnounceInfo(name))
            {
                SecretAnnouncementInfo newSInfo = new SecretAnnouncementInfo();
                _secretAnnouncementInfos.Add(name, newSInfo);
                return newSInfo;
            }
            return null;
        }

        public PublicAnnouncementInfo CreatePublicAnnouncementInfo(string name)
        {
            if (IsNameConsistentForAnnounceInfo(name))
            {
                PublicAnnouncementInfo newSInfo = new PublicAnnouncementInfo();
                _publicAnnouncementInfos.Add(name, newSInfo);
                return newSInfo;
            }
            return null;
        }

        public SecretAnnouncementInfo GetSecretAnnouncementInfo(string name)
        {
            return _secretAnnouncementInfos[name];
        }

        public PublicAnnouncementInfo GetPublicAnnouncementInfo(string name)
        {
            return _publicAnnouncementInfos[name];
        }

        public void RemoveActionModelInfo(string name)
        {
            _secretAnnouncementInfos.Remove(name);
            _publicAnnouncementInfos.Remove(name);
        }

        private void AddSecretAnnouncement(string actionModelName , string secretAnnouncementInfoName)
        {
            SecretAnnouncementInfo saInfo = _secretAnnouncementInfos[secretAnnouncementInfoName];

            SecretAnnouncement aModel 
                = new SecretAnnouncement(actionModelName , _agents , saInfo.Audience , saInfo.Announcement);
            _actionModels.Add(actionModelName, aModel);
        }

        private void AddPublicAnnouncement(string actionModelName, string publicAnnouncementInfoName)
        {
            PublicAnnouncementInfo saInfo = _publicAnnouncementInfos[publicAnnouncementInfoName];

            PublicAnnouncement aModel
                = new PublicAnnouncement(actionModelName, _agents, saInfo.Audience, saInfo.Announcement);
            _actionModels.Add(actionModelName, aModel);
        }

        public void GenerateAllActionModelsFromInfos()
        {
            _actionModels.Clear();
            foreach (var info in _secretAnnouncementInfos)
            {
                AddSecretAnnouncement(info.Key, info.Key);
            }

            foreach (var info in _publicAnnouncementInfos)
            {
                AddPublicAnnouncement(info.Key, info.Key);
            }
        }

        public string[] GetActionModelNames()
        {
            return _actionModels.Keys.ToArray();
        }

        public Dictionary<string, ActionModel> GetActionModels()
        {
            return _actionModels;
        }

        public bool CheckActionModelsForError(out ActionModelCheckReport report)
        {
            //TODO
            //throw new NotImplementedException();
            report = null;
            return false;
        }

        //==SAVING/LOADING=====================================================================

        private string[] SaveAgentsAsText()
        {
            string[] toret = new string[_agents.Count+1];
            toret[0] = _agents.Count.ToString();
            for (int i = 1; i <= _agents.Count; i++)
            {
                toret[i] = _agents.Keys.ToArray()[i-1];
            }
            return toret;
        }

        private string[] SaveAtomicAsText()
        {
            string[] toret = new string[_atomics.Count + 1];
            toret[0] = _atomics.Count.ToString();
            for (int i = 1; i <= _atomics.Count; i++)
            {
                toret[i] = _atomics.Keys.ToArray()[i-1];
            }
            return toret;
        }

        private string[] SaveSecretAnnouncementAsText(string name)
        {
            SecretAnnouncementInfo info = _secretAnnouncementInfos[name];
            int lineNum = 4 + info.Audience.Count;
            string[] toret = new string[lineNum];
            toret[0] = "Secret";
            toret[1] = name;
            toret[2] = info.Announcement.Expression;
            toret[3] = info.Audience.Count.ToString();
            for (int i = 0; i < info.Audience.Count; i++)
            {
                toret[i + 4] = info.Audience.Keys.ToArray()[i];
            }
            return toret;
        }

        private string[] SavePublicAnnouncementAsText(string name)
        {
            PublicAnnouncementInfo info = _publicAnnouncementInfos[name];
            int lineNum = 4 + info.Audience.Count;
            string[] toret = new string[lineNum];
            toret[0] = "Public";
            toret[1] = name;
            toret[2] = info.Announcement.Expression;
            toret[3] = info.Audience.Count.ToString();
            for (int i = 0; i < info.Audience.Count; i++)
            {
                toret[i + 4] = info.Audience.Keys.ToArray()[i];
            }
            return toret;
        }

        public string[] SaveModelAsText()
        {
            List<string> toret = new List<string>();

            toret.Add("START_AGENTS");
            toret.AddRange(SaveAgentsAsText());
            toret.Add("END_AGENTS");

            toret.Add("START_ATOMICS");
            toret.AddRange(SaveAtomicAsText());
            toret.Add("END_ATOMICS");

            toret.Add("START_ANN_INFO");
            toret.Add(GetTotalNumberOfAnnInfos().ToString());
            foreach (var info in _secretAnnouncementInfos)
            {
                toret.AddRange(SaveSecretAnnouncementAsText(info.Key));
            }
           
            foreach (var info in _publicAnnouncementInfos)
            {
                toret.AddRange(SavePublicAnnouncementAsText(info.Key));
            }
            toret.Add("END_ANN_INFO");

            return toret.ToArray();
        }

        private int GetTotalNumberOfAnnInfos()
        {
            return _publicAnnouncementInfos.Count + _secretAnnouncementInfos.Count;
        }

        public static EpistemicModel FromText(ref string[] lines)
        {
            EpistemicModel model = new EpistemicModel();
            int lineNum = 0;
            if (lines[lineNum++] == "START_AGENTS")
            {
                int agentCount = int.Parse(lines[lineNum++]);
                int i;
                for (i = lineNum; i < agentCount+lineNum; i++)
                {
                    model.AddAgent(lines[i]);
                }
                lineNum = i;
                if (lines[lineNum++] != "END_AGENTS")
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
            if (lines[lineNum++] == "START_ATOMICS")
            {
                int atomicCount = int.Parse(lines[lineNum++]);
                int i;
                for (i = lineNum; i < atomicCount + lineNum; i++)
                {
                    model.AddAtomic(lines[i]);
                }
                lineNum = i;
                if (lines[lineNum++] != "END_ATOMICS")
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

            
            if (lines[lineNum++] == "START_ANN_INFO")
            {
                int infoCount = int.Parse(lines[lineNum++]);
                for (int i = 0; i < infoCount ; i++)
                {
                      if (lines[lineNum] == "Secret")
                      {
                          lineNum++;
                          SecretAnnouncementInfo info = new SecretAnnouncementInfo();
                          string infoName = lines[lineNum++];
                          info.Announcement.Expression = lines[lineNum++];
                          int audienceCount = int.Parse(lines[lineNum++]);
                          for (int j = 0; j < audienceCount; j++)
                          {
                              info.AddNewAudience(lines[lineNum++]);
                          }
                          model._secretAnnouncementInfos.Add(infoName , info);
                      }
                      else if(lines[lineNum] == "Public")
                      {
                          lineNum++;
                          PublicAnnouncementInfo info = new PublicAnnouncementInfo();
                          string infoName = lines[lineNum++];
                          info.Announcement.Expression = lines[lineNum++];
                          int audienceCount = int.Parse(lines[lineNum++]);
                          for (int j = 0; j < audienceCount; j++)
                          {
                              info.AddNewAudience(lines[lineNum++]);
                          }
                          model._publicAnnouncementInfos.Add(infoName, info);
                      }
                }
                if (lines[lineNum++] != "END_ANN_INFO")
                {
                    return null;
                }
            }
            else
            {
                return null;
            }

            List<string> newData = lines.ToList();
            newData.RemoveRange(0, lineNum);
            lines = newData.ToArray();
            
            return model;
        }

        //==============================================================================


        public string[] GetAgentNames()
        {
            return _agents.Keys.ToArray();
        }

        public string[] GetAtomicNames()
        {
            return _atomics.Keys.ToArray();
        }

        public string[] GetSecretAnnouncementInfoNames()
        {
            return _secretAnnouncementInfos.Keys.ToArray();
        }

        public string[] GetPublicAnnouncementInfoNames()
        {
            return _publicAnnouncementInfos.Keys.ToArray();
        }

        public void Clear()
        {
            _atomics.Clear();
            _agents.Clear();
            _actionModels.Clear();
            _publicAnnouncementInfos.Clear();
            _secretAnnouncementInfos.Clear();
        }
    }
}
