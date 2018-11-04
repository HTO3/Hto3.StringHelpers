Hto3.StringHelpers
========================================

Features
--------
A set of extension methods that can be used to facilitate the manipulation of strings solving common dev problems.

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
"O ônIbUs já chegou".ReplaceIgnoringCase("Ônibus", "ubber") == "O ubber já chegou";
```

### ReplaceWholeWord

```csharp
"O rato roeu a roupa".ReplaceWholeWord("roeu", "comeu") == "O rato comeu a roupa";
```

### ReplaceFirstOccurrence

```csharp
"Carro carro carro carro".ReplaceFirstOccurrence("carro", "ônibus") == "Carro ônibus carro carro";
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

### TryGetExceptFirstName

```csharp
String test = null;
Assert.AreEqual("John Master Doe".TryGetExceptFirstName(out test), true);
Assert.AreEqual(test, "Master Doe");
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