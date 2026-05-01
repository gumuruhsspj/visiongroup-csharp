
---

# C# Assignment

This repository contains two core services built with .NET, orchestrated using Docker Compose: a **REST API** and a **WebSocket Chat** server.

## 🚀 Quick Start

Ensure you have **Docker** and **Docker Compose** installed on your machine.

### 1. Run the Services
Execute the following command in the root directory to build and start both containers:

```bash
docker-compose up --build
```

### 2. Service Access Points
Once the containers are healthy, the services will be available at:

*   **REST API:** `http://localhost:5188`
*   **WebSocket Chat:** `ws://localhost:5200`

---

## 🛠 Project Structure

| Service | Directory | Port | Description |
| :--- | :--- | :--- | :--- |
| **REST API** | `./csharp-restapi` | `5188` | Handles standard HTTP requests and data management. |
| **WebSocket** | `./csharp-websocket` | `5200` | Manages real-time, bidirectional communication for chat features. |

---