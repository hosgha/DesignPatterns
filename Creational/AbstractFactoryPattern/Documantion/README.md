﻿#Abstract Factory Pattern

The Abstract Factory design pattern provides an interface for **creating families of related or dependent objects without specifying their concrete classes**.

Abstract Factory patterns work around a super-factory which creates other factories. This factory is also called as factory of factories. This type of design pattern comes under creational pattern as this pattern provides one of the best ways to create an object.

![Abstract Factory Pattern UML Diagram](abstractfactory_pattern_uml_diagram.jpg)

##Implementation
We are going to create a Shape and Color interfaces and concrete classes implementing these interfaces. We create an abstract factory class AbstractFactory as next step. Factory classes ShapeFactory and ColorFactory are defined where each factory extends AbstractFactory. A factory creator/generator class FactoryProducer is created.

AbstractFactoryPatternDemo, our demo class uses FactoryProducer to get a AbstractFactory object. It will pass information (CIRCLE / RECTANGLE / SQUARE for Shape) to AbstractFactory to get the type of object it needs. It also passes information (RED / GREEN / BLUE for Color) to AbstractFactory to get the type of object it needs.