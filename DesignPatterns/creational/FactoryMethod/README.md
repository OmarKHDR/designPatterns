Factory method is a part of the creational design pattern. It provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.


## When to Use

1. **Complex Object Creation:**
	- When object creation process is complex
	- When creation varies under different conditions
	- Simplifies client code and promotes reusability

2. **Loose Coupling:**
	- Create objects through interface/abstract class
	- Hides concrete implementation details
	- Reduces dependencies
	- Easier system modification

3. **Product Variations:**
	- Creating different versions of products
	- Future-proofing for new product types
	- Flexible handling through specific factory methods

4. **Configuration Management:**
	- Encapsulates configuration logic
	- Customizable object creation
	- Parameter-based instantiation


factory method consist of:
- **Product:** defines the interface of objects the factory method creates
- **ConcreteProduct:** implements the Product interface
- **Creator:** declares the factory method, which returns an object of type Product
- **ConcreteCreator:** overrides the factory method to return an instance of a ConcreteProduct