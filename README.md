![SharperHacks logo](SHLLC-Logo.jpg)
# StringBuilderExtensions Library for .NET
## SharperHacks.CoreLibs.StringBuilderExtensions

Defines extensions to System.Text.StringBuilder.

Licensed under the Apache License, Version 2.0. See [LICENSE](LICENSE).

Contact: coders@sharperhacks.org

Nuget: https://www.nuget.org/packages/SharperHacks.CoreLibs.StringBuilderExtensions.

### Targets
- net8.0
- net9.0

### Classes

#### AppendIfExtensions

```
    public static StringBuilder AppendIf<T>(
        this StringBuilder sb,
        bool condition,
        T appendage)
        => condition ? sb.Append(appendage) : sb;
```

#### AppendIfElseExtensions

```
  public static StringBuilder AppendIfElse<T1, T2>(
      this StringBuilder sb,
      bool condition,
      T1 ifTrueAppendage,
      T2 ifFalseAppendage)
      => condition ? sb.Append(ifTrueAppendage) : sb.Append(ifFalseAppendage);
```

#### MiscellaneousExtensions

```
  public static StringBuilder AppendSpaces(
      this StringBuilder sb,
      int indentLevel)
      => sb.Append(Characters.Space, indentLevel);
```