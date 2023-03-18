# C
## Parte 1

```c
for (i=0; i<numrows; i++)
  for (j=0; j<numcols; j++);
    pixels++;
```
## Parte 2

```c
#include <stdio.h>

int main(void) {
	char test[] = { 'a', 'o', 'o', '\0' };
	printf("%c\n", 2[test]);
	printf("%c\n", 4[test]);
	return 0;
}
```

# C#
## Parte 1

```csharp
internal string RawOuterXml
{
  get => _rawOuterXml;

  set
  {
    if (string.IsNullOrEmpty(value))
    {
      _rawOuterXml = string.Empty;
    }

    _rawOuterXml = value;
  }
}
```
## Parte 3

```csharp
public static void DoWork(List<string> myWorkItems)
{
    if (myWorkItems?.Any() == false)
    {
        Console.WriteLine("Nothing to do");
        return;
    }
 
    Console.WriteLine("Doing work");
}
```

# Italiano

```
Un'avvocato dei palazzi nuovi si è licenziato per fare il metereologo, nonostante sia meno profiquo.
```

# Scala

```scala
case class Kek[A >: B <:B , B]()

object Main extends App {
	type A = Kek[Int, Int]
	type B = Kek[String, Int]
}
```

# Inglese

```
She’s married with a dentist, since three months.
```

# Java

```java
// Java
import java.util.*;
import java.lang.*;
import java.io.*;


class Main
{
	public static void main (String[] args) throws java.lang.Exception
	{
		System.out.println("Hello World!");
	}
}
```

# Meta

```
Trova l'errore in questo file di esercizi.
```