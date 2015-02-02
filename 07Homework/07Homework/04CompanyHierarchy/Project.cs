using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04CompanyHierarchy
{
    public enum State {Open, Closed}
    class Project
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private State state;

        public Project(string projectName, DateTime projectStartDate, string details) 
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = State.Open;
        }
        
        public string ProjectName 
        {
            get { return this.projectName; }
            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Project name cannot be empty");
                }
                this.projectName = value; 
            }
        }

        public DateTime ProjectStartDate
        {
            get { return this.projectStartDate; }
            set
            {
                if (value>DateTime.Now.AddDays(1))
                {
                    throw new ArgumentOutOfRangeException("The date cannoto be in the future");
                }
                this.projectStartDate = value;
            }
        }
        public string Details
        {
            get { return this.details; }
            set
            {
                this.details = value;
            }
        }

        public State State
        {
            get { return this.state; }
            private set
            {
                this.state= value;
            }
        }

        public void CloseProject()
        {
            this.state = State.Closed;
        }
    }
}
