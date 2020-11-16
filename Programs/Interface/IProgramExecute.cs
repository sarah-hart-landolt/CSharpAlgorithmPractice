using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAlgorithmPractice.Programs
{
    interface IProgramExecute
    {
        public int SortOrder();
        public string GetMenuTitle();
        public void Execute();
    }
}