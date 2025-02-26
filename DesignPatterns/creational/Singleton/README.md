# Singleton Pattern

## What is Singleton?
| insures that a class has only one instance and provide a global access to it

## Characteristics of Singleton PATTERN
- Only one instance of class can be created in the project
- provides global access to that instance
- thread safety to prevent multiple threads from making instances at same time
- forces the use of an access point by making the class constructor private
- Lazy and Eager intialization as it allow creating an instance when needed or as soon as class is looded

## This pattern is often used in situations like logging, managing connections to hardware or databases, caching data, or handling thread pools, where having just one instance makes sense
