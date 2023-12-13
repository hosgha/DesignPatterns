## Design Patterns
A design pattern is a general repeatable solution to a commonly occurring problem in software design. According to GOF, there are 3 types of design patterns, which include 22 patterns:
### 1. Creational Design Patterns: 
<br>Focus on **object creation** (class instantiation). These patterns often use for **reducing complexity** of class instantiation and providing **flexibility** in creating objects while **decoupling** the system from specific classes or implementations. These patterns aim to ensure that the process of creating objects is **efficient, extensible, and easily maintainable**. They can be further divided into **class-creation patterns** and **object-creational patterns**. While class-creation patterns use **inheritance** effectively in the instantiation process, object-creation patterns use **delegation** to get the job done. 
<br> Creational patterns list: 1. **Singltone**  2. **Factory Method**  3. **Abstraction Factory**  4. **Prototype**  5. **Builder**
### 2. Structural Design Patterns: (composition and relationships)
<br> Structural patterns deal with **composition and relationships**. These patterns are intended for organizing larger class structures and compositions. The main goal of most of these patterns is to **increase the functionality of the class(es) involved, without changing much of its composition**. 
 These patterns **help define relationships between objects, ensuring flexibility, and ease of modification**.
<br> Structural patterns list: 1. **Adapter**  2. **Facade**  3. **Composition**  4. **Proxy**  5. **Decorator**  6. **Bridge**  7. **Flyweight**
### 3. Behavioral Design Patterns: (interaction and communication)
<br>Behavioral patterns focus on the **interaction and communication** between objects. These patterns define communication patterns and the delegation of responsibilities between objects.
<br> Behavioral patterns list: 1. **Strategy**  2. **Observer**  3. **Command**  4. **Template method**  5. **State**  6. **Vistor**  7. **Chain of responsibility**  8. **Iterator**  9. **Mediator**  10. **Memento**

#### After GOF, some other types of design patterns are defined, such as Architectural design patterns and Cloud design patterns:
### Architectural design patterns: 
<br>Architectural patterns focus on the **overall structure and organization** of a software system. These patterns provide guidelines and **high-level structures** for designing **large-scale applications**.
<br>Architectural patterns list: 1. **Model-View-Controller (MVC)**  2. **Model-View-ViewModel (MVVM)**  3. **Microservices Architecture**  4. **Event-Driven Architecture (EDA)** and etc.
### Cloud design patterns:
<br>These patterns provide **guidance and best practices for designing and implementing cloud-based systems**, and are widely used in the industry to ensure that cloud applications are reliable, scalable, and secure. They provide solutions for a wide range of problems, including **data management**, **messaging**, and **application resilience** (Design and Implemention). Cloud design patterns are essential for ensuring that cloud-based applications are **well-architected** and **can meet the demands of modern, distributed systems**. 

<br>Cloud patterns list: 1. **Ambassador pattern**  2. **Retry pattern**  3. **Circuit Breaker pattern**  4. **Anti-Corruption Layer**  5. **Bulkhead**  6. **Queue-based load leveling**  7. **Throttling**  8. **Saga**  9. **CQRS** and etc. 

### Resources:
1.    https://www.freecodecamp.org/news/the-basic-design-patterns-all-developers-need-to-know/
2.    https://arindam-das.medium.com/design-patterns-demystified-unlocking-the-power-of-creational-structural-behavioral-and-f50e3a5b6cd7#:~:text=Creational%20patterns%20focus%20on%20object%20creation%2C%20structural%20patterns%20deal%20with,guide%20the%20overall%20system%20structure.
