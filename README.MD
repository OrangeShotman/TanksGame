#Code example project

This is my project which can provide understanding of my code writing approach.
###Notice

There are some modules which are not presented in this repository, so you can't launch the game or take a look at the multiplayer core part. The main goal of the repository is introducing myself as a game developer and showing my approach. If you want to try playing the game, you can use this link to play the demo.
## Project Structure

- **/Scripts**: This folder contains the source code for the project.
  - **/Scripts/Controllers**: Controllers which are represented as states.
  - **/Scripts/Model**: This folder mostly contains classes related to ECS.
  - **/Scripts/View**: There are views and interpolation logic in the folder.

##Features

- Prediction and reconciliation. Player input applies before sending to the server. Every received snapshot is compared with prediction and the input is reapplied in case of misprediction.
- Lag compensation. Every launched projectile is marked by a tick, which a player saw when a projectile was created. Also there is a system which makes a history record of snapshots. It helps to calculate collisions in the past.
- Interpolation. There are two different approaches to interpolating in the repository.
  - Without history and only by the last received snapshot.
  - Interpolation by history. It is a more flexible approach which allows you to hide network's fluctuations.

##Out of scope

As was mentioned above there are some modules which are not included into the repository. 

- Transport layer. I am using custom lightweight UDP library and WebSocket plugin for WebGL.
- Network service layer. Responsibilities of this layer is process new connections, messages and authorising.
- Multiplayer game facade. Responsibilities of this layer is ticking the logic and snapshot syncing. I am using "Overwatch" approach to synchronize snapshots.
- ECS. I am using table based ECS with code generation. There are some features as data compression, serialization, interpolation, snapshot merge, etc.