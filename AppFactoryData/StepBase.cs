using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFactoryData
{
    public class StepBase : StepAbstract
    {

        #region Basics

        public bool IsActive
        {
            get;
            set; 
        }

        public StepType Type
        {
            get;
            set;    
        }

        public string Name
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;   
        }

        public Translation TranslationName
        {
            get;
            set;
        }

        public Translation TranslationDescription
        {
            get;
            set;
        }

        #endregion

        #region Lookups

        public StepBase LookupInheritance
        {
            get;
            set;
        }


        public StepBase LookupMain
        {
            get;
            set;
        }

        public StepBase LookupSecond
        {
            get;
            set; 
        }

        #endregion


    }
}
