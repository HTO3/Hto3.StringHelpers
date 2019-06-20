<img alt="logo" width="150" height="150" src="nuget-logo.png">

Hto3.StringHelpers
========================================

#### Nuget Package
[![Hto3.StringHelpers](https://img.shields.io/nuget/v/Hto3.StringHelpers.svg)](https://www.nuget.org/packages/Hto3.StringHelpers/)

Features
--------
A set of extension methods that can be used to manipulate strings solving common dev problems.

### RemoveCharactersAtBegining

Remove a specified amout of characters at the begining of string.

```csharp
"Apple".RemoveCharactersAtBegining(1) == "pple";
```

### RemoveCharactersAtEnd

Remove a specified amout of characters at the end of string.

```csharp
"Apple".RemoveCharactersAtEnd(1) == "Appl";
```

### RemoveSpaces

Remove all spaces ' '.

```csharp
"Five steps to complish".RemoveSpaces() == "Fivestepstocomplish";
```

### RemoveLineBreaks

Remove all line breaks.

```csharp
"Line\r\nbreaks\r\nare\r\ngreat!".RemoveLineBreaks() == "Linebreaksaregreat!";
```

### PrependMissing

If the text does not start with a especified text, then this specified text will be added to the string.

```csharp
@":\Program Files (x86)\Java".PrependMissing("C") == @"C:\Program Files (x86)\Java";
```

### AppendMissing

If the text does not end with a especified text, then this specified text will be added to the string.

```csharp
@"C:\Program Files (x86)\Java".AppendMissing("\\") == @"C:\Program Files (x86)\Java\";
```

### NullIf

If the text is equal to a specified value, then return null.

```csharp
"0".NullIf("0") == null;
```

### Coalesce

Return the first non-null value.

```csharp
Helpers.Coalesce(null, null, "123", "abc") == "123";
```

### RandomString

Generate a ramdom string containing letters and numbers.

```csharp
Helpers.RandomString(8) == "a84583fc";
```

### IsAlphanumeric

Verify if a text is alpha numeric.

```csharp
"azAZ09".IsAlphanumeric() == true;
```

### ToAlphanumeric

Converts the specified text to an alpha-numeric string by removing all non-alpha-numeric characters.

```csharp
"[a-z|A-Z|0-9]".ToAlphanumeric() == "azAZ09";
```

### ToCsvSafe

Makes a string safe to to be used in a CSV file by including double quotes when needed.

```csharp
" Cave rats,\r\ngiant cats!".ToCsvSafe() == "\" Cave rats,\r\ngiant cats!\"";
```

### NumbersOnly

Strip all others caracters from a text lefting only numbers.

```csharp
"df89e#dKf".NumbersOnly() == "89";
```

### ExceptNumbers

Strip all others caracters from a text lefting only non-numbers.

```csharp
"59385gg#451".ExceptNumbers() == "gg#";
```

### Right

Extract some characters from right to left.

```csharp
"Apple".Right(3) == "ple";
```

### Left

Extract some characters from left to right.

```csharp
"Apple".Left(3) == "App";
```

### Reverse

Reverse the characters sequence.

```csharp
"Apple".Reverse() == "elppA";
```

### ReplaceIgnoringCase

Replace a text with another one ignoring case.

```csharp
"The ReCiPe of madness".ReplaceIgnoringCase("recipe", "master") == "The master of madness";
```

### ReplaceWholeWord

Replace whole word.

```csharp
"So far so good".ReplaceWholeWord("far", "long") == "So long so good";
```

### ReplaceFirstOccurrence

Returns a new string in which only the first occurrence of a specified string in the current instance are replaced with another specified string.

```csharp
"Car car car car".ReplaceFirstOccurrence("car", "bus") == "Car bus car car";
```

### TryGetFirstName

Tries to get the first name of a full name.

```csharp
String test = null;
Assert.AreEqual("John Doe".TryGetFirstName(out test), true);
Assert.AreEqual(test, "John");
```

### TryGetLastName

Tries to get the last name of a full name.

```csharp
String test = null;
Assert.AreEqual("John Doe".TryGetLastName(out test), true);
Assert.AreEqual(test, "Doe");
```

### FormatCPF

Format a brazilian CPF.

```csharp
"11111111111".FormatCPF() == "111.111.111-11";
```

### FormatCNPJ

Format a brazilian CNPJ.

```csharp
"11111111111111".FormatCNPJ() == "11.111.111/1111-11";
```

### FormatCEP

Format a brazilian zip code.

```csharp
"11111111".FormatCEP() == "11111-111";
```

### IsNumber

Verify if a text is a number.

```csharp
"1111".IsNumber() == true;
```

### RemoveNonASCIICharacters

Remove all non-ASCII characters from a text.

```csharp
"jäspion-".RemoveNonASCIICharacters() == "jspion-";
```

### RemoveNonANSICharacters

Remove all non-ANSI characters from a text.

```csharp
"jäspion-ﮝ".RemoveNonANSICharacters() == "jäspion-";
```

### ReplaceNonASCIICharactersWith

Replace all non-ASCII characters with a character.

```csharp
"jäspion-".ReplaceNonASCIICharactersWith('?') == "j?spion-";
```

### ReplaceNonANSICharactersWith

Replace all non-ANSI characters with a character.

```csharp
"jäspion-ﮝ".ReplaceNonANSICharactersWith('?') == "jäspion-?";
```

### RemoveAccents

Remove accents replacing the character with the equivalent without accent.

```csharp
"jäspion".RemoveAccents() == "jaspion";
```

### CenterAlignText

Center a text inside a fixed length using space characters ' '.

```csharp
"job".CenterAlignText(30) == "             job            ";
```

### NormalizePathSlashes

Normalize the slashes in a path. If the application is running on Windows, all '/' will be replaced by '\\', else all '\\' will be replaced by '/'.

```csharp
//on Windows
"/var/lib/file.txt".NormalizePathSlashes() == "\\var\\lib\\file.txt";
```