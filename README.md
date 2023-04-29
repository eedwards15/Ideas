# Ideas 

## Description
This is an api that allows users to create, read, update and delete ideas.

## Technologies
- C#
- ASP.NET Core

## Endpoints
- GET /api/ideas
- GET /api/ideas/{id}
- POST /api/ideas
- Delete /api/ideas/{id}
- PUT /api/ideas/{id}

## Models
### Idea
```
{
    "id": 1,
    "title": "Idea 1",
    "idea_text": "Idea 1",
    "created_at": "2021-09-20T00:00:00",
    "updated_at": "2021-09-20T00:00:00"
}
```