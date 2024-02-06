// Copyright and trademark notices at the end of this file.

using System.Runtime.CompilerServices;
using System.Text;

namespace SharperHacks.CoreLibs.StringBuilderExtensions;

/// <summary>
/// A collection of AppendIf(condition,...) StringBuilder extensions.
/// </summary>
public static class AppendIfExtensions
{
    /// <summary>
    /// Conditionally append <paramref name="appendage"/> to this instance.
    /// </summary>
    /// <typeparam name="T">
    /// Must be one of the types supported by StringBuilder.Append().
    /// https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append?view=net-7.0.
    /// </typeparam>
    /// <param name="sb"></param>
    /// <param name="condition"></param>
    /// <param name="appendage"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static StringBuilder AppendIf<T>(
        this StringBuilder sb,
        bool condition,
        T appendage)
        => condition ? sb.Append(appendage) : sb;
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
