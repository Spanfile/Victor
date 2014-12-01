Victor
======
*Because nobody likes writing massive qualifiers and type names over and over.*

##So concise, your fingers will thank you.

Between annoying type names (e.g. `IEnumerable<T>`) and annoying method names (e.g. `Tuple.Create`, `Console.writeLine`), you may realize that these two simple things can clutter up your code a lot. You could use type name aliases, but this is a process you would need to repeat for every source file you have. Even if you don't mind that, utility methods can sometimes be pretty long by themselves (e.g. `String.IsNullOrWhitespace`) and cumulatively take up a considerable chunk of your time to write.

These problems end here.

**Victor** is a collection of commonly used data types, remastered with one-letter naming conventions. Here's what it has so far:

###Tuples

I hate `System.Tuple`. I hate it so much. Not because it's bad (quite the contrary), but because its naming scheme makes me want to stick my hand into the nearest blender.

```cs
var t = Tuple.Create("A", "B", "C"); // Tuple<string, string, string>
var concat = t.Item1 + t.Item2 + t.Item3; // "ABC"
```

Victor tackles this problem by providing a ridiculously shorter version of `Tuple.Create`. Add a using directive for `Victor.Make` and turn the above mess into this:

```cs
using Victor.Make;

// Later on in the code...

var t = T("A", "B", "C"); // T<string, string, string>
var concat = t.a + t.b + t.c; // "ABC";
```

###Vectors

Victor has 2D and 3D vecors (so far). They are just as easy to work with:
```cs
// Vector creation
V3 pos = V(0, 10, 0);
V3 target = V(100, 50, 20);
float dist = pos.dist(target);

// Unit shortcuts
WriteLine(X3); // (1, 0, 0)
WriteLine(Y3); // (0, 1, 0)
WriteLine(Z3); // (0, 0, 1)
WriteLine(X3 + Y3 + Z3); // (1, 1, 1)
```

##Development
Victor is in the early stages of development. Eventually, I hope to add more useful data structures like vectors, matrices, bit fields, and more. The idea is to make them as easy as possible to work with, and drastically reduce messy code.
