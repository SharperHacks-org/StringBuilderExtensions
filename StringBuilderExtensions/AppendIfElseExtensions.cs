// Copyright and trademark notices at the end of this file.

using System.Runtime.CompilerServices;
using System.Text;

namespace SharperHacks.CoreLibs.StringBuilderExtensions;

/// <summary>
/// A collection of AppendIfElse(condition,...) StringBuilder extensions.
/// </summary>
public static class AppendIfElseExtensions
{
    /// <summary>
    /// Conditionally append either <paramref name="ifTrueAppendage"/> or
    /// <paramref name="ifFalseAppendage"/> to this instance.
    /// </summary>
    /// <typeparam name="T1">
    /// Must be one of the types supported by StringBuilder.Append().
    /// https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append?view=net-7.0.
    /// </typeparam>
    /// <typeparam name="T2">
    /// Must be one of the types supported by StringBuilder.Append().
    /// https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.append?view=net-7.0.
    /// </typeparam>
    /// <param name="sb">StringBuilder to append to.</param>
    /// <param name="condition">Boolean epression.</param>
    /// <param name="ifTrueAppendage">Value to append to this instance if condition is true.</param>
    /// <param name="ifFalseAppendage">Value to append to this instance if condition is false.</param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1715:Identifiers should have correct prefix", Justification = "Some VS features are useless.")]
    public static StringBuilder AppendIfElse<T1, T2>(
        this StringBuilder sb,
        bool condition,
        T1 ifTrueAppendage,
        T2 ifFalseAppendage)
        => condition ? sb.Append(ifTrueAppendage) : sb.Append(ifFalseAppendage);
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
