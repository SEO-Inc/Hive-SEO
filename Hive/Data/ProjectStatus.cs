using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hive.Data.enums;
namespace Hive.Data
{
    public class ProjectStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }

        public ContractProjectType? ContractProjectType { get; set; }
        public int Order { get; set; }

        public bool IsActive { get; set; }
    }
}