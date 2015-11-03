using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KLab.Models
{
    public class ProcessChain
    {
        private readonly Dictionary<string, EpistemicProcess> _processes
            = new Dictionary<string, EpistemicProcess>();

        private readonly Dictionary<string, ModelConfiguration> _models
            = new Dictionary<string, ModelConfiguration>();

        private readonly Dictionary<string, ActionModel> _actionModels
            = new Dictionary<string, ActionModel>();

        private readonly EpistemicModel _epistemicModel;

        public ProcessChain(EpistemicModel epistemicModel)
        {
            _epistemicModel = epistemicModel;
            _epistemicModel.GenerateAllActionModelsFromInfos();
            _actionModels = _epistemicModel.GetActionModels();
        }

        public string[] GetProcessNames()
        {
            return _processes.Keys.ToArray();
        }

        public string[] GetModelNames()
        {
            return _models.Keys.ToArray();
        }

        public string[] GetActionModelNames()
        {
            return _actionModels.Keys.ToArray();
        }

        public bool ContainsProcessWithName(string name)
        {
            return _processes.ContainsKey(name);
        }

        public EpistemicProcess CreateNewProcess(string name)
        {
            EpistemicProcess ep = new EpistemicProcess();
            _processes.Add(name, ep);
            return ep;
        }

        public void RemoveProcess(string name)
        {
            _processes.Remove(name);
        }

        public bool ContainsModelWithName(string name)
        {
            return _models.ContainsKey(name);
        }

        public void CreateNewModel(string name)
        {
            _models.Add(name, new ModelConfiguration(name));
        }

        public void RemoveModel(string name)
        {
            _models.Remove(name);
        }

        public void SetProcessSource(string procName, string newSource)
        {
            _processes[procName].Start = _models[newSource];
        }

        public void SetProcessResault(string procName, string newResault)
        {
            _processes[procName].Resault = _models[newResault];
        }

        public void AddActionToProcess(string procName, string actionName)
        {
            _processes[procName].AddActionModel(_actionModels[actionName]);
        }

        public void ChangeActionOfProcessAtIndex(string procName, int index, string newActionName)
        {
            _processes[procName].AddActionModel(index, _actionModels[newActionName]);
        }

        public void RemoveActionFromProcess(string procName, int index)
        {
            _processes[procName].RemoveActionModel(index);
        }

        public EpistemicProcess GetProcess(string name)
        {
            return _processes[name];
        }

        public void Run()
        {
            EpistemicProcess[] processes
                = _processes.Values.ToArray();
            for (int i = 0; i < _processes.Count; i++)
            {
                processes[i].ProccessActions();
            }
        }

        public string[] SaveAsText()
        {
            List<string> lines = new List<string>();
            lines.AddRange(_epistemicModel.SaveModelAsText().ToList());
            lines.Add("START_MODEL_VARS");
            lines.Add(_models.Count.ToString());
            foreach (var model in _models)
            {
                lines.Add(model.Key);
            }
            lines.Add("END_MODEL_VARS");
            lines.Add("START_PROCESS");
            lines.Add(_processes.Count.ToString());
            foreach (var proc in _processes)
            {
                lines.Add(proc.Key);
                lines.AddRange(proc.Value.SaveAsText());;
            }
            lines.Add("END_PROCESS");

            return lines.ToArray();
        }

        public static ProcessChain FromText(string[] lines)
        {
            ProcessChain processChain = new ProcessChain(EpistemicModel.FromText(ref lines));
            int ln = 0;

            try
            {
                if (!lines.Any())
                    return processChain;

                if (lines[ln++] != "START_MODEL_VARS")
                    return null;
                int modelCount = int.Parse(lines[ln++]);
                for (int i = 0; i < modelCount; i++)
                {
                    processChain.CreateNewModel(lines[ln++]);
                }
                if (lines[ln++] != "END_MODEL_VARS")
                    return null;

                if (lines[ln++] != "START_PROCESS")
                    return null;
                int procCount = int.Parse(lines[ln++]);
                for (int i = 0; i < procCount; i++)
                {
                    string procName = lines[ln++];
                    EpistemicProcess ep = processChain.CreateNewProcess(procName);
                    ep.Start = new ModelConfiguration(lines[ln++]);
                    ep.Resault = new ModelConfiguration(lines[ln++]);
                    int actionCount = int.Parse(lines[ln++]);
                    for (int j = 0; j < actionCount; j++)
                    {
                        ep.AddActionModel(processChain._actionModels[lines[ln++]]);
                    }
                }
                if (lines[ln++] != "END_PROCESS")
                    return null;
            }
            catch (IndexOutOfRangeException)
            {

                return null;
            }
            
            return processChain;
        }

        public void Clear()
        {
            _epistemicModel.Clear();
            _models.Clear();
            _processes.Clear();
            _actionModels.Clear();
        }
    }
}
