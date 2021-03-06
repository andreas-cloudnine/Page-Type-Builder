﻿using System;
using EPiServer.DataAbstraction;
using EPiServer.Editor;

namespace PageTypeBuilder
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class PageTypePropertyAttribute : Attribute
    {
        private const bool DefaultDisplayInEditMode = true;

        public PageTypePropertyAttribute()
        {
            DisplayInEditMode = DefaultDisplayInEditMode;    
        }

        public virtual Type Type { get; set; }

        public virtual string EditCaption { get; set; }

        public virtual string HelpText { get; set; }

        public virtual Type Tab { get; set; }

        public virtual bool Required { get; set; }

        public virtual bool Searchable { get; set; }

        public virtual object DefaultValue { get; set; }

        public virtual DefaultValueType DefaultValueType { get; set; }

        public virtual bool UniqueValuePerLanguage { get; set; }

        public virtual bool DisplayInEditMode { get; set; }

        public virtual int SortOrder { get; set; }

        public virtual EditorToolOption LongStringSettings { get; set; }

        public virtual bool ClearAllLongStringSettings { get; set; }
    }
}