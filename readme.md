# 📝 TodoList API

API RESTful desenvolvida em **ASP.NET Core** com arquitetura em camadas e separação de responsabilidades, focada no gerenciamento de tarefas (_todos_). A aplicação segue princípios de **Clean Architecture** e encapsula as **regras de negócio** na camada de aplicação.

> IDE utilizada: **JetBrains Rider**

---

## 📁 Estrutura do Projeto

A estrutura foi organizada em projetos distintos, visando clareza, escalabilidade e manutenção facilitada:

- **TodoList.Api**: Responsável pelas configurações da API (Program.cs, Controllers).
- **TodoList.Application**: Contém os casos de uso (UseCases) e regras de negócio da aplicação.
- **TodoList.Communication**: Define os contratos de entrada e saída entre as camadas.

---

## 🚀 Endpoints da API

### 🔸 Criar uma tarefa

**POST** `/todos`

**Requisição:**

```json
{
  "title": "Estudar TypeScript",
  "description": "Completar os exercícios de TypeScript"
}
```

**Resposta – 201 Created:**

```json
{
  "id": 1,
  "title": "Estudar TypeScript",
  "description": "Completar os exercícios de TypeScript",
  "done": false,
  "createdAt": "2025-04-19T12:00:00Z",
  "updatedAt": "2025-04-19T12:00:00Z"
}
```

---

### 🔸 Atualizar uma tarefa (título, descrição e status)

**PUT / PATCH** `/todos/{id}`

**Requisição:**

```json
{
  "title": "Estudar C# Avançado",
  "description": "Focar em LINQ e async/await",
  "done": true
}
```

**Resposta – 200 OK:**

```json
{
  "id": 1,
  "title": "Estudar C# Avançado",
  "description": "Focar em LINQ e async/await",
  "done": true,
  "createdAt": "2025-04-19T12:00:00Z",
  "updatedAt": "2025-04-19T15:00:00Z"
}
```

---

### 🔸 Listar todas as tarefas

**GET** `/todos`

**Resposta – 200 OK:**

```json
{
  "todos": [
    {
      "id": 1,
      "title": "Estudar TypeScript",
      "description": "Completar os exercícios",
      "done": true,
      "createdAt": "2025-04-19T12:00:00Z",
      "updatedAt": "2025-04-19T13:00:00Z"
    }
  ]
}
```

---

### 🔸 Deletar uma tarefa

**DELETE** `/todos/{id}`

**Resposta – 204 No Content:**  
Tarefa deletada com sucesso.

---

## 🧠 Regras de Negócio

- **Título e descrição** são obrigatórios para criar ou atualizar uma tarefa.
- Tarefas possuem status booleano (`done`) indicando se foram concluídas.
- Toda tarefa deve manter o histórico de `createdAt` e `updatedAt`.

---

## ⚙️ Tecnologias Utilizadas

- ASP.NET Core
- C#
- Clean Architecture
- RESTful API
- DTO Pattern
- Rider IDE

---

## ▶️ Executando o Projeto

> Pré-requisitos: [.NET 8 SDK](https://dotnet.microsoft.com/download) instalado

```bash
# Navegue até o diretório da API
cd TodoList.Api

# Execute a aplicação
dotnet run
```