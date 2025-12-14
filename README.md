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

---

## 🧱 Architecture Overview

```
Client
  │
  ▼
Command API
  │
  ▼
Command Handlers ──► Aggregates ──► Domain Events
                                     │
                                     ▼
                               Event Store (MongoDB)
                                     │
                                     ▼
                               Kafka Event Bus
                                     │
              ┌──────────────────────┴──────────────────────┐
              ▼                                             ▼
        Read Model Builder                          Other Consumers
        (Event Replay)                               (Future services)
              │
              ▼
        PostgreSQL Query Store
```

---

## 📦 Services & Components

### 1. Command Side (Write Model)

Responsible for **handling intent and enforcing invariants**.

* Accepts commands such as:

    * `CreatePost`
    * `AddComment`
    * `LikePost`
* Loads aggregates from event history
* Applies business rules
* Emits domain events

**Technologies:**

* C# (.NET)
* MS SQL (transactional consistency)
* MongoDB (event store)

---

### 2. Domain Layer

Pure domain logic with no infrastructure dependencies.

* Aggregates
* Entities
* Value Objects
* Domain Events

This layer is **fully testable in isolation**.

---

### 3. Event Store

* Stores immutable domain events
* Enables full state reconstruction
* Acts as the source of truth

**Technology:** MongoDB

---

### 4. Event Bus

* Publishes events to Kafka topics
* Enables loose coupling between services
* Supports horizontal scalability

**Technology:** Apache Kafka

---

### 5. Read Side (Query Model)

Optimized for **fast reads** and **simple queries**.

* Subscribes to Kafka events
* Builds denormalized projections
* Supports event replay

**Technology:** PostgreSQL

---
