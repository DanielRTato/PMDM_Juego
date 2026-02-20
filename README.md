# Roll-a-Ball 


![Captura de pantalla](Captura%20de%20pantalla%202026-02-05%20221436.png)

---

## Cambios sobre el tutorial base

### Escenario
- El suelo se duplicó en tamaño (x2) para ampliar el área de juego.
- Se añadió un segundo nivel elevado, accesible únicamente a través de una rampa.

### Jugador
- **Salto**: el jugador puede saltar con detección de suelo para evitar saltos en el aire.
- **Zona de muerte**: si el jugador cae por debajo de un límite de altura, pierde la partida.

### Enemigos
- Se añadieron enemigos adicionales que persiguen al jugador usando **NavMesh**.
- Si el jugador toca a un enemigo, pierde la partida.
- Al recoger todos los coleccionables, los enemigos desaparecen.

### Coleccionables
- Se añadieron más objetos coleccionables al escenario.
- Al recoger 6 objetos, el jugador gana la partida.

### Portales
- Hay portales en cada extremo del mapa que teletransportan al jugador al extremo opuesto.
- Incluyen un cooldown de 0.5 s para evitar teletransportes en cadena.

### Visual
- Se aplicaron texturas al suelo, jugador, coleccionables y portales.

---

## Controles

| Acción | Tecla |
|--------|-------|
| Mover  | `W A S D` / flechas |
| Saltar | `Space` |

---

## Scripts

| Script | Descripción |
|--------|-------------|
| `PlayerController.cs` | Movimiento, salto, zona de muerte y recogida de objetos |
| `EnemyMovement.cs` | IA del enemigo con NavMesh que persigue al jugador |
| `Portall.cs` | Lógica de teletransporte entre portales |
| `CamaraController.cs` | Seguimiento de la cámara al jugador |
| `Rotator.cs` | Rotación de los objetos coleccionables |

---

## Condiciones de victoria y derrota

- **Victoria**: recoger los 6 coleccionables del mapa.
- **Derrota**: ser tocado por un enemigo o caer fuera del mapa.


- **Paquetes**: Input System, NavMesh, TextMeshPro
