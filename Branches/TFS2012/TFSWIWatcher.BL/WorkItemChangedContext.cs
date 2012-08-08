﻿using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Server;
using TFSWIWatcher.BL.Configuration;

namespace TFSWIWatcher.BL
{
    public class WorkItemChangedContext
    {
        #region Properties

        public WorkItemChangedEvent WorkItemChangedEvent
        {
            get; internal set;
        }

        public WorkItemChangeInfo WorkItemChangeInfo
        {
            get; internal set;
        }

        public TfsTeamProjectCollection TeamProjectCollection
        {
            get; internal set;
        }

        public int WorkItemID
        {
            get; internal set;
        }

        public int WorkItemRevision
        {
            get; internal set;
        }

        public ConfigSettingsConfigurationSection ConfigSettings
        {
            get;
            internal set;
        }

        #endregion

        #region Constructors

        public WorkItemChangedContext(WorkItemChangeInfo changeInfo, TfsTeamProjectCollection teamProjectCollection, int workItemID, int workItemRevision, ConfigSettingsConfigurationSection configSettings, WorkItemChangedEvent workItemChangedEvent)
        {
            WorkItemChangeInfo = changeInfo;
            TeamProjectCollection = teamProjectCollection;
            WorkItemID = workItemID;
            WorkItemRevision = workItemRevision;
            ConfigSettings = configSettings;
            WorkItemChangedEvent = workItemChangedEvent;
        }

        #endregion
    }
}