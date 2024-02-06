// Copyright and trademark notices at the end of this file.

using System.Diagnostics.CodeAnalysis;
using System.Text;

using SharperHacks.CoreLibs.StringBuilderExtensions;

namespace SharperHacks.CoreLibs.StringBuilderExtensionsUT;

[ExcludeFromCodeCoverage]
[TestClass]
public class IfElseUT
{
    internal static void IfElseTest<T1, T2>(T1 ifTrue, T2 ifFalse, string result)
    {
        var sb = new StringBuilder();

        sb.AppendIfElse(true, ifTrue, ifFalse).Append(',')
          .AppendIfElse(false, ifTrue, ifFalse);

        Console.WriteLine($"{typeof(T1).Name}, {typeof(T2).Name}, \"{sb}\"");
        Assert.AreEqual(result, sb.ToString());
    }

    [TestMethod]
    public void AppendIfElse()
    {
        var sb1 = new StringBuilder().Append("sb1");
        var sb2 = new StringBuilder().Append("sb2");

        IfElseTest(sb1, sb2, "sb1,sb2");                 // StringBuilder, StringBuilder
        IfElseTest("true", "false", "true,false");       // String, String
        IfElseTest(sb1, "false", "sb1,false");           // StringBuilder, string
        IfElseTest(41, 43, "41,43");                     // Int32, Int32
        IfElseTest("42", 52f, "42,52");                  // String, Single
        IfElseTest('a', 'A', "a,A");                     // Char, Char
        IfElseTest('z', "YX", "z,YX");                   // Char, String
        IfElseTest(3.14, 2.71828, "3.14,2.71828");       // Double, Double
        IfElseTest(11.22M, 52L, "11.22,52");             // Decimal, Int64
        IfElseTest((byte)97, (sbyte)98, "97,98");        // Byte, Sbyte
    }
}

// Copyright Joseph W Donahue and Sharper Hacks LLC (US-WA)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// SharperHacks is a trademark of Sharper Hacks LLC (US-Wa), and may not be
// applied to distributions of derivative works, without the express written
// permission of a registered officer of Sharper Hacks LLC (US-WA).
