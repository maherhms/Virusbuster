# VirusBuster

VirusBuster is a 2D Arcade game prototype built with MonoGame and structured for scalability, clarity, and future systems development.  
The project uses a simple scene architecture to keep screens modular while leaving room for complex gameplay, stat progression, and skill‑tree mechanics.

## Overview

The current version includes:
- A lightweight scene system (clean separation of screens)
- A custom engine layer (`Core`) that handles graphics, content, and scene flow

```mermaid
sequenceDiagram
    participant BreachScene
    participant EnemySpawner
    participant EnemyManager
    participant PlayerAttackManager
    participant PlayerMouse
    participant GeometryFactory
    participant SpriteBatch

    BreachScene->>GeometryFactory: (during LoadContent) CreateFilledTexture(device,w,h,color)
    GeometryFactory-->>PlayerMouse: Texture2D (attack / aim)
    BreachScene->>PlayerMouse: LoadPlayerMouseContent()
    BreachScene->>EnemyManager: ctor / ready
    BreachScene->>EnemySpawner: ctor(enemyManager)

    loop each frame
      BreachScene->>EnemySpawner: Update(gameTime)
      EnemySpawner-->>EnemyManager: AddEnemy(new Enemy at offscreen pos)
      BreachScene->>EnemyManager: Update(gameTime)
      BreachScene->>PlayerAttackManager: Update()
      PlayerAttackManager->>PlayerMouse: Update() / Draw(spriteBatch)
      PlayerMouse->>SpriteBatch: Draw(attackTexture / aimTexture, positions)
      EnemyManager->>SpriteBatch: Draw(enemies)
    end


```

## Tech Stack

- MonoGame 3.8+
- .NET 9
- MGCB Content Pipeline

## Roadmap

- Core gameplay loop  
- Player stats + scaling system  
- Skill tree with branching upgrades  
- Enemy waves + difficulty progression  
- UI and menu scenes  
- Visual effects + polish  

## Launch Game

- dotnet run --project VirusBuster.csproj
