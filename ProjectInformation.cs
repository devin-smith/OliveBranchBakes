using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveBranchBakes
{
    internal static class ProjectInformation
    {
        public const string ProjectName = "Olive Branch Bakes";
        public const string StudentName = "Devin Smith";
        public const string Phase = "Phase 1: Requirements and Scope";
        public const string ClassName = "CS3388 - Object Oriented Programming";
        public static string CurrentDate => DateTime.Now.ToString("MMMM dd, yyyy");
        public const string Description = "A Windows Forms application designed to help Olive Branch Bakes manage customer information, orders, allergy information, and order status.";
    }
}
