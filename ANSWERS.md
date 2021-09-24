# Extension Methods

```csharp
IEnumerable<int>[] xs;

int[] ys;
```

## Q1: Flatten the numbers in `xs`

```csharp
xs.SelectMany(items => items).Select(item => item);
```

## Q2: Select numbers in `ys` which are divisible by `7` and greater than `42`

```csharp
ys.Where(n => n % 7 == 0 && n > 42).Select(n => n)
```

## Q3: Select numbers in `ys` which are *leap years*

```csharp
ys.Where(n => n > 1582 && (n % 400 == 0 || n % 4 == 0) && n % 100 != 0)
```