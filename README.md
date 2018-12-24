<img alt="logo" width="150" height="150" src="nuget-logo.png">

Hto3.StringHelpers
========================================

#### Nuget Package
[![Dapper](https://img.shields.io/nuget/v/Hto3.StringHelpers.svg)](https://www.nuget.org/packages/Hto3.StringHelpers/)

Features
--------
A set of extension methods that can be used to facilitate the manipulation of strings solving common dev problems.

### RemoveCharactersAtBegining

```csharp
"Apple".RemoveCharactersAtBegining(1) == "pple";
```

### RemoveCharactersAtEnd

```csharp
"Apple".RemoveCharactersAtEnd(1) == "Appl";
```

### RemoveSpaces

```csharp
"Five steps to complish".RemoveSpaces() == "Fivestepstocomplish";
```

### RemoveLineBreaks

```csharp
"Line\r\nbreaks\r\nare\r\ngreat!".RemoveLineBreaks() == "Linebreaksaregreat!";
```

### PrependMissing

```csharp
@":\Program Files (x86)\Java".PrependMissing("C") == @"C:\Program Files (x86)\Java";
```

### AppendMissing

```csharp
@"C:\Program Files (x86)\Java".AppendMissing("\\") == @"C:\Program Files (x86)\Java\";
```

### NullIf

```csharp
"0".NullIf("0") == null;
```

### Coalesce

```csharp
Helpers.Coalesce(null, null, "123", "abc") == "123";
```

### RandomString

```csharp
Helpers.RandomString(8) == "a84583fc";
```

### IsAlphanumeric

```csharp
"azAZ09".IsAlphanumeric() == true;
```

### ToAlphanumeric

```csharp
"[a-z|A-Z|0-9]".ToAlphanumeric() == "azAZ09";
```

### ToCsvSafe

```csharp
" Cave rats,\r\ngiant cats!".ToCsvSafe() == "\" Cave rats,\r\ngiant cats!\"";
```

### NumbersOnly

```csharp
"df89e#dKf".NumbersOnly() == "89";
```

### ExceptNumbers

```csharp
"59385gg#451".ExceptNumbers() == "gg#";
```

### Right

```csharp
"Apple".Right(3) == "ple";
```

### Left

```csharp
"Apple".Left(3) == "App";
```

### Reverse

```csharp
"Apple".Reverse() == "elppA";
```

### ReplaceIgnoringCase

```csharp
"The ReCiPe of madness".ReplaceIgnoringCase("recipe", "master") == "The master of madness";
```

### ReplaceWholeWord

```csharp
"So far so good".ReplaceWholeWord("far", "long") == "So long so good";
```

### ReplaceFirstOccurrence

```csharp
"Car car car car".ReplaceFirstOccurrence("car", "bus") == "Car bus car car";
```

### TryGetFirstName

```csharp
String test = null;
Assert.AreEqual("John Doe".TryGetFirstName(out test), true);
Assert.AreEqual(test, "John");
```

### TryGetLastName

```csharp
String test = null;
Assert.AreEqual("John Doe".TryGetLastName(out test), true);
Assert.AreEqual(test, "Doe");
```

### FormatCPF

```csharp
"11111111111".FormatCPF() == "111.111.111-11";
```

### FormatCNPJ

```csharp
"11111111111111".FormatCNPJ() == "11.111.111/1111-11";
```

### FormatCEP

```csharp
"11111111".FormatCEP() == "11111-111";
```

### IsNumber

```csharp
"1111".IsNumber() == true;
```

### RemoveNonASCIICharacters

```csharp
"jäspion-".RemoveNonASCIICharacters() == "jspion-";
```

### RemoveAccents

```csharp
"jäspion".RemoveAccents() == "jaspion";
```

### CenterAlignText

```csharp
"job".CenterAlignText(30) == "             job            ";
```