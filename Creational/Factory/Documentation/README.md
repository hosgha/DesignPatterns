#Design Pattern
##Factory Pattern

A creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to decide which class to instantiate.

Implementation
We're going to create a Shape interface and concrete classes implementing the Shape interface. A factory class ShapeFactory is defined as a next step.

FactoryPatternDemo, our demo class will use ShapeFactory to get a Shape object. It will pass information (CIRCLE / RECTANGLE / SQUARE) to ShapeFactory to get the type of object it needs.