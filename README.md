﻿![logo](https://raw.githubusercontent.com/HTO3/Hto3.StringHelpers/master/nuget-logo-small.png)

Hto3.StringHelpers
========================================

[![License](https://img.shields.io/github/license/HTO3/Hto3.StringHelpers)](https://github.com/HTO3/Hto3.StringHelpers/blob/master/LICENSE)
[![Hto3.StringHelpers](https://img.shields.io/nuget/v/Hto3.StringHelpers.svg)](https://www.nuget.org/packages/Hto3.StringHelpers/)
[![Downloads](https://img.shields.io/nuget/dt/Hto3.StringHelpers)](https://www.nuget.org/stats/packages/Hto3.StringHelpers?groupby=Version)
[![Build Status](https://github.com/HTO3/Hto3.StringHelpers/actions/workflows/publish.yml/badge.svg)](https://github.com/HTO3/Hto3.StringHelpers/actions/workflows/publish.yml)
[![codecov](https://codecov.io/gh/HTO3/Hto3.StringHelpers/branch/master/graph/badge.svg)](https://codecov.io/gh/HTO3/Hto3.StringHelpers)
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/99d52281fbba4ad7b174b3f8ab167aee)](https://www.codacy.com/gh/HTO3/Hto3.StringHelpers/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=HTO3/Hto3.StringHelpers&amp;utm_campaign=Badge_Grade)

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

### LettersOnly

Strip all others caracters from a text lefting only letters.

```csharp
"df89é#dKf".LettersOnly() == "dfédKf";
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

### TrySubstring

Try to execute substring over a string.
Returns false if the operation is impossible, else true.

```csharp
String resultString = null;
bool success = "abc".TrySubstring(2, out resultString);
```

### CenterAlignText

Center a text inside a fixed length using space characters ' '.

```csharp
"job".CenterAlignText(30) == "             job            ";
```

### MaskText

Mask text with a replacement char. 

```csharp
var text = "The cat is a good friend too.";
var coverage = 0.5f; //50%
var mode = MaskTextMode.Begining;

//Possible modes:
//var mode = MaskTextMode.Ending;
//var mode = MaskTextMode.Center;
//var mode = MaskTextMode.Intervaled;
//var mode = MaskTextMode.Ends;
//var mode = MaskTextMode.Random;

var result = StringHelpers.MaskText(text, coverage, mode);

//result by mode:
result == "*** *** ** * ***d friend too."; //Begining
//result == "The cat is a go** ****** ****"; //Ending
//result == "The cat ** * **** *****d too."; //Center
//result == "**e *a* i* a *o*d *r*e*d *o*."; //Intervaled
//result == "*** *** is a good frie** ****"; //Ends
//result == Th* c** i* a *oo* **i*n* t**.; //Random
```

Do not mask some chars:

```csharp
var text = "111.111.111-00";
var coverage = 0.7f; //70%
var mode = MaskTextMode.Intervaled;
var replacementChar = '°';
var skip = new[] { '.', '-' };

//Act
var result = StringHelpers.MaskText(text, coverage, mode, replacementChar, skip);

result == "°°1.°°°.1°°-°0";
```

### NormalizePathSlashes

Normalize the slashes in a path. If the application is running on Windows, all '/' will be replaced by '\\', else all '\\' will be replaced by '/'.

```csharp
//on Windows
"/var/lib/file.txt".NormalizePathSlashes() == "\\var\\lib\\file.txt";
```

### TrimExtraSpaces

Remove extra space between words.

```csharp
"abc     abc".TrimExtraSpaces() == "abc abc";
```

### CalcBase64SizeBytes

Calculate the content size of a base64 string. Return size in Bytes.

```csharp
"AA==".CalcBase64SizeBytes() == 1;
```

### ContainsAnyOfTheseWords

Check if the text contains any of the provided words.

```csharp
var text = @"Historically, the world of data and the world of objects " +
           @"have not been well integrated. Programmers work in C# or Visual Basic " +
           @"and also in SQL or XQuery. On the one side are concepts such as classes, " +
           @"objects, fields, inheritance, and .NET APIs. On the other side " +
           @"are tables, columns, rows, nodes, and separate languages for dealing with " +
           @"them. Data types often require translation between the two worlds; there are " +
           @"different standard functions. Because the object world has no notion of query, a " +
           @"query can only be represented as a string without compile-time type checking or " +
           @"IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to " +
           @"objects in memory is often tedious and error-prone.";

var words = new[] { "memory", "jeopardize" };

//The word "memory" is in the text
text.ContainsAnyOfTheseWords(words) == true;
```

### ContainsAllOfTheseWords

Check if the text contains all of the provided words.

```csharp
var text = @"Historically, the world of data and the world of objects " +
           @"have not been well integrated. Programmers work in C# or Visual Basic " +
           @"and also in SQL or XQuery. On the one side are concepts such as classes, " +
           @"objects, fields, inheritance, and .NET APIs. On the other side " +
           @"are tables, columns, rows, nodes, and separate languages for dealing with " +
           @"them. Data types often require translation between the two worlds; there are " +
           @"different standard functions. Because the object world has no notion of query, a " +
           @"query can only be represented as a string without compile-time type checking or " +
           @"IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to " +
           @"objects in memory is often tedious and error-prone.";

var words = new[] { "object", "without" };

//The words "object" and "without" are in the text
text.ContainsAllOfTheseWords(words) == true;
```