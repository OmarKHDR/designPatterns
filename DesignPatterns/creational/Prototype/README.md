# Prototype Design Pattern
---
## What is Prototype Design Pattern?
- a creational design pattern it is used if creating an object is a heavy task so we create object by existing ones by copying existing objects
- Clone is the simplest approach to implementing a prototype pattern. However, it is your call to decide how to copy existing objects based on your business model.
- suppose you have a theme on an app and you want to have another theme that looks exactly like it with some minor modification => without Prototype pattern you would have to create the same theme from the start but with the prototype you can clone the theme and edit it.

## what does it consist of
- Prototype interface: for defining the structure of the prototype and making more loosely coupled system, and it ensure there is a way to clone the obj
- Concrete prototype: the actual object class
- Client: is the user interface which is actually used to clone and create new cloned object.