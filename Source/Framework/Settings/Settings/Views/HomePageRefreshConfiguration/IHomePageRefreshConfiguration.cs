#region Copyright(C) 2008 NCS Pte. Ltd. All rights reserved.

// ==================================================================================================
// Copyright(C) 2008 NCS Pte. Ltd. All rights reserved.
//
// SYSTEM NAME       :   Housing Integrated Information Program
// COMPONENT ID      :   Settings
// COMPONENT DESC    :  
//
// CREATED DATE/BY   : 06/11/2008/Yang Jian Hua
//
// REVISION HISTORY  : DATE/BY                    SR#/CS/PM#/OTHERS          DESCRIPTION OF CHANGE
// ==================================================================================================

#endregion

namespace HiiP.Framework.Settings
{
    public interface IHomePageRefreshConfiguration
    {
        string AlertRefreshSeconds
        {
            get;
            set;
        }

        string MessageRefreshSeconds
        {
            get;
            set;
        }

        string ToDoListRefreshSeconds
        {
            get;
            set;
        }

        string MyAppointmentsRefreshSeconds
        {
            get;
            set;
        }

        string MyReportRefreshSeconds
        {
            get;
            set;
        }

        string MyDashboardRefreshSeconds
        {
            get;
            set;
        }
    }
}

