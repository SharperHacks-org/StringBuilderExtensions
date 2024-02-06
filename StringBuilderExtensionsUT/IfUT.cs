// Copyright and trademark notices at the end of this file.

using SharperHacks.CoreLibs.StringBuilderExtensions;

using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SharperHacks.CoreLibs.StringBuilderExtensionsUT;

[ExcludeFromCodeCoverage]
[TestClass]
public class IfUT
{
    internal static void IfTest<T1>(T1 ifTrue, string result)
    {
        var sb = new StringBuilder();

        sb.AppendIf(true, ifTrue)
          .AppendIf(false, ifTrue);

        Console.WriteLine($"{typeof(T1).Name}, \"{sb}\"");
        Assert.AreEqual(result, sb.ToString());
    }

    [TestMethod]
    public void AppendIf()
    {
        var sb1 = new StringBuilder().Append("sb1");

        IfTest(sb1, "sb1");         // StringBuilder
        IfTest("true", "true");     // String
        IfTest(sb1, "sb1");         // StringBuilder
        IfTest(41, "41");           // Int32
        IfTest("42", "42");         // String
        IfTest('a', "a");           // Char
        IfTest('z', "z");           // Char
        IfTest(3.14, "3.14");       // Double
        IfTest(11.22M, "11.22");    // Decimal
        IfTest((byte)97, "97");     // Byte
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
