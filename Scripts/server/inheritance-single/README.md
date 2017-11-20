# Inheritance Single

Explanation in this [link](http://rosettacode.org/wiki/Inheritance/Single)


**Explanation**

Inheritance is an operation of type algebra that creates a new type from one or several parent types. The obtained type is called derived type. It inherits some of the properties of its parent types. Usually inherited properties are:

* methods
* components
* parts of the representation

The class of the new type is a subclass of the classes rooted in the parent types. When all (in certain sense) properties of the parents are preserved by the derived type, it is said to be a Liskov subtype. When properties are preserved then the derived type is substitutable for its parents in all contexts. Usually full substitutability is achievable only in some contexts.

Inheritance is 
	
* single, when only one parent is allowed
* multiple, otherwise

Some single inheritance languages usually allow multiple inheritance for certain abstract types, interfaces in particular.

Inheritance can be considered as a relation parent-child. Parent types are sometimes called supertype, the derived ones are subtype. This relation is transitive and reflexive. Types bound by the relation form a wp:Directed_acyclic_graph directed acyclic graph (ignoring reflexivity). With single inheritance it becomes a tree.


**Task**

Show a tree of types which inherit from each other. The top of the tree should be a class called Animal. The second level should have Dog and Cat. Under Dog should be Lab and Collie. None of the classes need to have any functions, the only thing they need to do is inherit from the specified superclasses (overriding functions should be shown in Polymorphism). The tree should look like this:




		Animal
		  /\
		 /  \
		/    \
	      Dog    Cat
              /\        
             /  \
            /    \
          Lab    Collie


In most languages inheritance doesn't have any runtime cost.  
What does have cost and we can measure is the dynamic dispatch of a method based on the type of the object.
Therefore, we are using the following portion of code for our test.


class Animal {
        speak() {...}
        final walk() {...}
}
class Dog extends Animal {
        @override speak() {...}
}
class Lab extends Dog {
	@override speak() {...}
}
class Collie extends Dog {
	@override speak() {...}
}
class Cat extends Cat {
	@override speak() {...}
}

main()
{
        Animal a = new Lab();
        // Dynamic dispatch (requires vtable lookup)
        a.speak();
        // Static dispatch (for comparison; in C++ this is a single machine instruction)
        a.walk();
}       
