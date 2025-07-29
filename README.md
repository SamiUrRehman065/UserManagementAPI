
## 🧑‍💼 UserManagementAPI

A clean, scalable ASP.NET Core Web API built from scratch by **Sami Ur Rehman**, featuring full CRUD functionality, Swagger documentation, and in-memory data simulation.

---

## 🚀 Features

- `GET /api/User` → Fetch all users  
- `GET /api/User/{id}` → Fetch user by ID  
- `POST /api/User` → Create a new user  
- `PUT /api/User/{id}` → Update user info  
- `DELETE /api/User/{id}` → Remove user

---

## 🔧 Tech Stack

- ASP.NET Core (.NET 8)  
- Dependency Injection  
- RESTful Controllers  
- Swagger UI (OpenAPI 3.0.4)  
- In-Memory List (no DB yet)

---

## 🧪 Live Testing with Swagger UI

Just run the project and visit:  
`https://localhost:<your-port>/swagger`

Try out endpoints interactively with this sample payload:

```json
{
  "fullName": "Sami Developer",
  "email": "sami@example.com"
}
```

---

## 📂 Folder Structure

```
UserManagementAPI/
├── Controllers/
│   └── UserController.cs
├── Models/
│   ├── User.cs
│   └── UserDto.cs
├── Services/
│   ├── IUserService.cs
│   └── UserService.cs
└── Program.cs
```

---

## 👤 Author

Built with 💙 and curiosity by **Sami Ur Rehman**

- 🔗 [LinkedIn](https://www.linkedin.com/in/samiurrehman065)  
- 🔗 [GitHub](https://github.com/SamiUrRehman065)

---

## 💬 License

Open-source for educational and portfolio showcase use.

---

## 🗃️ Commit Strategy

Follow this model when pushing:

```bash
git init
git add .
git commit -m "Init UserManagementAPI project"
git commit -m "Add UserController with CRUD endpoints"
git commit -m "Integrate Swagger and test live endpoints"
git commit -m "Refactor service to use singleton for stateful data"
git remote add origin https://github.com/SamiUrRehman065/UserManagementAPI.git
git push -u origin main
```
```

---


