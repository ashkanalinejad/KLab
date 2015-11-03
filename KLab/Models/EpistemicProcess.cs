using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KLab.Models
{
    public class EpistemicProcess
    {
        private ModelConfiguration _start;
        private readonly List<ActionModel> _actions = new List<ActionModel>();
        private ModelConfiguration _resault;

        public ModelConfiguration Start
        {
            set { _start = value; }
        }

        public ModelConfiguration Resault
        {
            set { _resault = value; }
        }

        public void AddActionModel(ActionModel model)
        {
            _actions.Add(model);
        }

        public void AddActionModel(int index, ActionModel model)
        {
            if (model != null && index>=0 && index<_actions.Count)
            {
                _actions[index] = model;
            }
        }

        public void ProccessActions()
        {
            if(_start==null || _resault==null)
                return;

            ModelConfiguration mc = new ModelConfiguration(_start);

            for (int i = 0; i < _actions.Count; i++)
            {
                mc = mc*_actions[i];
            }
            _resault.CopyFrom(mc);
        }

        public void RemoveActionModel(ActionModel actionModel)
        {
            _actions.Remove(actionModel);
        }

        public void RemoveActionModel(int index)
        {
            _actions.RemoveAt(index);
        }

        public string[] SaveAsText()
        {
            string[] toret = new string[3+_actions.Count];
            toret[0] =_start.Name;
            toret[1] = _resault.Name;
            toret[2] = _actions.Count.ToString();
            for (int i = 0; i < _actions.Count; i++)
            {
                toret[i + 3] = _actions[i].Name;
            }

            return toret;
        }

        public string GetStartName()
        {
            return _resault == null ? "" : _start.Name;
        }

        public string GetResaultName()
        {
            return _resault == null ? "" : _resault.Name;
        }

        public string[] GetActionNames()
        {
            string[] toret = new string[_actions.Count];
            for (int i = 0; i < _actions.Count; i++)
            {
                toret[i] = _actions[i].Name;
            }
            return toret;
        }
    }
}
