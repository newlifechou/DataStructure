using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XS.DataStructure.String
{
    public interface IString
    {
        bool IsEmpty(string s);
        int GetLength(string s);
        void Empty(string s);
        void Copy(string s1,string s2);
        int Compare(string s1,string s2);
        string Concat(string s1, string s2);
        string SubString(string s, int start, int length);
        int Index(string s, string t, int start);
        void Replace(string s, string t, string v);
        void StrInsert(string s, int start, int t);
        void StrDelete(string s, int start, int length);
    }
}
