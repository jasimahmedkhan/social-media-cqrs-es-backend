# social-media-cqrs-es-backend

A **.NET microservices backend** that models core social media interactions—**posts, comments, and likes**—using **CQRS (Command Query Responsibility Segregation)** and **Event Sourcing**.

This project is designed as a **hands-on, framework-free reference implementation** showcasing how to build scalable, decoupled systems with **Domain-Driven Design (DDD)**, **Apache Kafka**, and multiple data stores for specialized responsibilities.

---

## ✨ Key Features

* **CQRS architecture** with strong separation of write and read models
* **Event Sourcing** for all state changes
* **Kafka-based event streaming** for service decoupling
* **Aggregate-root driven domain model** (DDD)
* **Event replay** to rebuild read models
* **Polyglot persistence**:

    * MongoDB for event storage
    * MS SQL for command-side consistency
    * PostgreSQL for query-side projections
* **Mediator pattern** for command and event dispatching
* **No application frameworks** (no ASP.NET Core, no MassTransit, no Orleans, etc.)

