using Sitecore.WFFM.Abstractions.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.Support.Forms.Core.Pipelines
{
    public class EnsureFieldsCollection
    {
        public void Process(ProcessMessageArgs args)
        {
            if (args.Fields == null)
            {
                args.Fields = new WFFM.Abstractions.Actions.AdaptedResultList(new WFFM.Abstractions.Actions.AdaptedControlResult[0]);
            }
        }
    }
}