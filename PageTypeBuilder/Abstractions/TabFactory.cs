﻿using EPiServer.DataAbstraction;

namespace PageTypeBuilder.Abstractions
{
    public class TabFactory : ITabFactory
    {
        public virtual TabDefinition GetTabDefinition(string name)
        {
            return TabDefinition.Load(name);
        }

        public virtual void SaveTabDefinition(TabDefinition tabDefinition)
        {
            tabDefinition.Save();
        }

        public virtual TabDefinitionCollection List()
        {
            return TabDefinition.List();
        }
    }
}
