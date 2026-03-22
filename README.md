# Edwin Romero - Projects

This repository contains different experiments and utilities related to:

- .NET development
- Clean Architecture
- Authorization systems
- SaaS development

# PermissionAuthorization

Clean and scalable permission-based authorization for ASP.NET Core using dynamic policies.

## 🚀 Why?

Authorization logic often ends up scattered across controllers:

- Repeated permission checks
- Business logic mixed with security
- Hard to maintain as the application grows

This library centralizes authorization in a clean and reusable way.

---

## ⚡ Quick Start

### 1. Register services

```csharp
services.AddPermissionAuthorization<YourPermissionService>();
