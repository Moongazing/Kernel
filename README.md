# Moongazing.Kernel

**Moongazing.Kernel** represents the core layer of the application, providing a modular structure designed with **SOLID** principles in mind. It aims to ensure scalability, maintainability, and consistency across the application.

## Project Structure

The solution is divided into several projects, each responsible for specific concerns. Below is an explanation of each project:

---

### 1. **Moongazing.Kernel.Application**
- **Purpose**: Handles application logic, business rules, and request processing.
- **Key Features**:
  - **CQRS**: Implements Command and Query patterns.
  - **DTOs**: Defines Data Transfer Objects for inter-layer communication.
  - **MediatR**: Enables in-process messaging to decouple components.

---

### 2. **Moongazing.Kernel.CrossCuttingConcerns**
- **Purpose**: Manages cross-cutting concerns like logging, validation, and caching.
- **Key Features**:
  - **Logging**: Provides a unified logging mechanism.
  - **Validation**: Ensures input data is validated.
  - **Caching**: Enhances performance by implementing caching mechanisms.

---

### 3. **Moongazing.Kernel.Localization**
- **Purpose**: Manages multi-language support and localization.
- **Key Features**:
  - **Resource Management**: Handles application texts for different languages.
  - **Globalization**: Ensures smooth internationalization and localization processes.

---

### 4. **Moongazing.Kernel.Mailing**
- **Purpose**: Provides email management and sending functionalities.
- **Key Features**:
  - **SMTP Support**: Facilitates email sending via SMTP.
  - **Email Templates**: Supports dynamic email template creation.

---

### 5. **Moongazing.Kernel.Persistence**
- **Purpose**: Handles database communication and entity management.
- **Key Features**:
  - **Entity Framework Core**: Implements an ORM for database operations.
  - **DbContext**: Manages database transactions and connections.
  - **Repository Pattern**: Organizes and standardizes data access.

---

### 6. **Moongazing.Kernel.Security**
- **Purpose**: Manages application security concerns.
- **Key Features**:
  - **Authentication & Authorization**: Handles user authentication and role-based authorization.
  - **JWT**: Implements JSON Web Token for secure API access.
  - **Encryption**: Provides data encryption mechanisms to ensure security.

---

## Usage Instructions

### Prerequisites
- .NET 7 SDK or later
- Entity Framework Core
- MediatR
- FluentValidation

### Setting Up
1. Clone the repository:
   ```bash
   git clone <repository-url>
