using OT.Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YFramework.Service.Core
{
    public abstract class BusinessModule:Module
    {
        private string m_name = "";

        public string Name { get => m_name = this.GetType().Name; }

        public string Title;

        public BusinessModule()
        {

        }

        internal BusinessModule(string name)
        {
            m_name = name;
        }

        private EventTable m_tblEvent;

        internal void SetEventTable(EventTable tblEvent)
        {
            m_tblEvent = tblEvent;
        }

        public ModuleEvent Event(string type)
        {
            return m_tblEvent.GetEvent(type);
        }

        protected EventTable GetEventTable()
        {
            if(m_tblEvent == null)
            {
                m_tblEvent = new EventTable();
            }
            return m_tblEvent;
        }

        public virtual void Create(object args = null)
        {
            this.Log("Create() args = {0}",args);
        }

        public override void Release()
        {
            if(m_tblEvent != null)
            {
                m_tblEvent.Clear();
                m_tblEvent = null;
            }

            base.Release();
        }

        public virtual void Show()
        {
            this.Log("Show()");
        }
    }
}
